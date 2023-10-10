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
}