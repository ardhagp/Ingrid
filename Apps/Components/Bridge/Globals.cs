//using System;
//using Sentry;
//using System.Windows.Forms;
//using BetterStack.Logs;
//using Bridge.Security;
using Microsoft.Extensions.Configuration;
//using Microsoft.VisualBasic;
using Serilog;
//using System.Reflection.Metadata;
//using System.Security.Cryptography.X509Certificates;
//using System.Security.Principal;

namespace Bridge.Security
{
    public class GETKEY
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SALT()
        {
            /*
             * this code for .net 6, not working on .net 7
             * 
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();

            string? v = configuration.GetSection("KEYS")["SALT"];
            string V_KEY = v;

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
            */
            /*
             * var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("secret.json")
                .AddUserSecrets<GETKEY>()
                .Build();
            */

            var config = new ConfigurationBuilder()
                .AddUserSecrets<GETKEY>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["SALT"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }

        public string SYNCFUSION()
        {
            /*
             * this code for .net 6, not working on .net 7
             * 
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();

            string? v = configuration.GetSection("KEYS")["SYNCFUSION"];
            string V_KEY = v;

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
            */

            var config = new ConfigurationBuilder()
                .AddUserSecrets<GETKEY>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["SYNCFUSION"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }

        public string BETTERSTACK_LOG()
        {
            /*
             * this code for .net 6, not working on .net 7
             * 
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            
            string? v = configuration.GetSection("KEYS")["BETTERSTACK_LOG"];
            string V_KEY = v;

            if (V_KEY != null) {
                return V_KEY;
            }
            else
            {
                return "";
            }
            */

            var config = new ConfigurationBuilder()
                .AddUserSecrets<GETKEY>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["BETTERSTACK_LOG"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }
    }
    
    public class WRITELOG
    {

        public enum LogType
        {
            Information,
            Error
        }

        public static async void SENDLOG(string Messages, LogType TypeOfLog)
        {
            try
            {
                WRITELOGS(Messages, TypeOfLog);
            }
            catch (Exception ex)
            {
                string a = ex.Message;                
            }
        }
        private static async void WRITELOGS(string Messages, LogType TypeOfLog)
        {
            await Task.Delay(0);

            Bridge.Security.GETKEY KEYLOG = new Bridge.Security.GETKEY();

            Serilog.Log.Logger = new LoggerConfiguration()
                .WriteTo.BetterStack(sourceToken: KEYLOG.BETTERSTACK_LOG())
                .MinimumLevel.Information()
                .CreateLogger();

            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;

            DateTime currentUTC = localZone.ToUniversalTime(currentDate);
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);

            string OccuredAt = string.Format(Environment.NewLine + "--- Occured at: ---" + Environment.NewLine + "UTC: {0}" + Environment.NewLine + "Offset: {1}" + Environment.NewLine + "Device DateTime: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), currentUTC.ToString("yyyy-MM-dd HH:mm:ss"), currentOffset);

            Messages += OccuredAt;

            if (TypeOfLog == LogType.Information)
            {
                Serilog.Log.Information(Messages);
            }
            else
            {
                Serilog.Log.Error(Messages);
            }

            Serilog.Log.CloseAndFlush();
        }
    }
}

