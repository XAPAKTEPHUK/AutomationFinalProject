using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFinalProject.TestData
{
     
    static class EditClient
    {
        public const string firstName = "Ivan";
        public const string lastName = "Boychuk";
        public const string eMail = "ivanboychuk@bredemann.com";
        public const string editClientPage = "SST - Edit Client";


        public static string EditClientPage()
        {
            return editClientPage;
        }

        public static string FirstName()
        {
            return firstName;
        }

        public static string LastName()
        {
            return lastName;
        }

        public static string Email()
        {
            return eMail;
        }
    }
}
