﻿using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFinalProject.TestData
{
    public class Client
    {
        public Client()
        {
            SeedRandomData();       
        }

        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Company;


        public void SeedRandomData()
        {
            var faker = new Faker();
            PhoneNumber = faker.Phone.PhoneNumber();
            Email = faker.Internet.Email();
            this.FirstName = faker.Name.FirstName();
            this.LastName = faker.Name.LastName();
            this.Company = faker.Company.CompanyName();
        }       

    }
}
