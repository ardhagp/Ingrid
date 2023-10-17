//using System;
//using Sentry;
//using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Bridge
{
    public class GETKEY
    {
        public string Salt()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            string? v = configuration.GetSection("KEYS")["SALT"];
            string V_KEY = v;

            return V_KEY;
        }

        public string Syncfusion()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            IConfiguration configuration = configurationBuilder.AddUserSecrets<GETKEY>().Build();
            string? v = configuration.GetSection("KEYS")["SYNCFUSION"];
            string V_KEY = v;

            return V_KEY;
        }
    }
    
    //public class APP
    //{
        //[STAThread]
        //static void Run()
        //{
            // Init the Sentry SDK
            //SentrySdk.Init(o =>
            //{
                // Tells which project in Sentry to send events to:
                //o.Dsn = "https://15ec113790e44bc4788549ca549bf2c9@o4506037577777152.ingest.sentry.io/4506037581512704";
                // When configuring for the first time, to see what the SDK is doing:
                //o.Debug = true;
                // Set TracesSampleRate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                //o.TracesSampleRate = 1.0;
            //});

            // Configure WinForms to throw exceptions so Sentry can capture them.
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            // Any other configuration you might have goes here...
            //Application.Run(new Form1());
        //}
    //} 
    
}