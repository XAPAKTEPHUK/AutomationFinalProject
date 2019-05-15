using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomationFinalProject.TestData
{
    
    static class LogInLogOut
    {
        public const string loginPage = "SST - Login";
        public const string userName = "admin";
        public const string passWord = "2VLu=j^ykC";
        public const string clientPage = "SST - Clients";
        public const string adminURL = "https://nitro.duckdns.org/sst-classes/#username";

        public static string LogInPage()
        {
            return loginPage;
        }

        public static string Username()
        {
            return userName;
        }

        public static string Password()
        {
            return passWord;
        }

        public static string ClientPage()
        {
            return clientPage;
        }

        public static string AdminURL()
        {
            return adminURL;
        }
    }
}
