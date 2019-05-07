/* Config Class
 * Used to get Environment, Browser and corresponding URLs variable values` from > App.config <
 **/using System;
using System.Collections.Generic; 
using System.Configuration; //need to add System.Configuration in References in order to use
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFinalProject.Configuration
{

    public class Config
    {
        public static string GetEnvironment()
        {
            return GetConfigValue("Environment");
        }
        public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }
        public static string GetUrl()
        {
            string key = "SST." + GetEnvironment();
            return GetConfigValue(key);
        }
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key]; //need to add System.Configuration in References in order to use > ConfigurationManager <
        }
    }
}
