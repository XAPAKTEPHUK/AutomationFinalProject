using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AutomationFinalProject.PageObjects;
using AutomationFinalProject.TestData;
using Shouldly;
using AutomationFinalProject.Configuration;
using AutomationFinalProject.WebDriver;

namespace AutomationFinalProject.Tests
{
    [TestFixture]
    
	class SST003ClientSearch
    {
       
        [Test]
        public void ClientSearchPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl(Config.GetUrl());

                var logInPage = new LogInPage(driver);

                logInPage.LogIn(LogInLogOut.Username(), LogInLogOut.Password());

                var clientSearchPage = new ClientSearchPage(driver);
                clientSearchPage.ClickSearchClient();
                clientSearchPage.SearchBy(ClientSearch.Email());
                clientSearchPage.ClickSearch();

                var tableText = clientSearchPage.GetTableText();
                Console.WriteLine(tableText);

                clientSearchPage.GetFirstName().ShouldBe(ClientSearch.Iryna());
                Console.WriteLine($"First Name: {clientSearchPage.GetFirstName()}");

                clientSearchPage.GetLastName().ShouldBe(ClientSearch.Shch());
                Console.WriteLine($"Last Name: {clientSearchPage.GetLastName()}");
            }
        }
    }
}