using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFinalProject.TestData
{
    static class Constants
    {
        public static string Username()
        {
            return Constant("admin");
        }

        public static string Password()
        {
            return Constant("2VLu=j^ykC");
        }

        public static string AdminURL()
        {
            return Constant("https://nitro.duckdns.org/sst-classes/#username");
        }

        public static string LogInPage()
        {
            return Constant("SST - Login");
        }

        public static string ClientPage()
        {
            return Constant("SST - Clients");
        }

        public static string EditClientPage()
        {
            return Constant("SST - Edit Client");
        }

        public static string TeacherID()
        {
            return Constant("Teacher One");
        }

        public static string Email()
        {
            return Constant("ilka@mailinator.com");
        }

        public static string Iryna()
        {
            return Constant("Iryna");
        }

        public static string Shch()
        {
            return Constant("Shch");
        }

        public static string NoR()
        {
            return Constant("No records found");
        }

        public static string FirstName()
        {
            return Constant("Ivan");
        }

        public static string LastName()
        {
            return Constant("Boychuk");
        }

        public static string Email2()
        {
            return Constant("ivanboychuk@bredemann.com");
        }


        private static string Constant(string v)
        {
            return v;
        }
    }
}
