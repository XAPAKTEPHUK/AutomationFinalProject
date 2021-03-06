﻿using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFinalProject.TestData
{
    public class AddClient
    {
        public AddClient()
        {
            SeedRandomData();       
        }

        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Company;
        public const string teacherID = "Teacher One";
        public const string zipCode = "60634";
        public const string State = "Illinois";
        public const string addClientPage = "SST - Add Client";


        public void SeedRandomData()
        {
            var faker = new Faker();
            PhoneNumber = faker.Phone.PhoneNumber();
            Email = faker.Internet.Email();
            this.FirstName = faker.Name.FirstName();
            this.LastName = faker.Name.LastName();
            this.Company = faker.Company.CompanyName();
        }

        public static string TeacherID()
        {
            return teacherID;
        }

        public static string AddClientPage()
        {
            return addClientPage;
        }
    }
}
