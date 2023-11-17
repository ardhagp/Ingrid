//using System;
//using Sentry;
//using System.Windows.Forms;
using BetterStack.Logs;
using Bridge.Security;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Bridge.Security
{
    public class GETKEY
    {
        public string SALT()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            string? v = configuration.GetSection("KEYS")["SALT"];
            string V_KEY = v;

            return V_KEY;
        }

        public string SYNCFUSION()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            string? v = configuration.GetSection("KEYS")["SYNCFUSION"];
            string V_KEY = v;

            return V_KEY;
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
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            string? v = configuration.GetSection("KEYS")["BETTERSTACK_LOG"];
            string V_KEY = v;

            Serilog.Log.Logger = new LoggerConfiguration()
                .WriteTo.BetterStack(sourceToken: V_KEY)
                .MinimumLevel.Information()
                .CreateLogger();

            TimeZone localZone   = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
        
            DateTime currentUTC  = localZone.ToUniversalTime(currentDate);
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);

            string OccuredAt = string.Format(Environment.NewLine + "--- Occured at: ---" + Environment.NewLine + "UTC: {0}" + Environment.NewLine + "Offset: {1}" + Environment.NewLine + "Device DateTime: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), currentUTC.ToString("yyyy-MM-dd HH:mm:ss"), currentOffset);

            Messages += OccuredAt;

            if (TypeOfLog == LogType.Information) {
                Serilog.Log.Information(Messages);
            }
            else {
                Serilog.Log.Error(Messages);
            }

            Serilog.Log.CloseAndFlush();
        }
    }
}

