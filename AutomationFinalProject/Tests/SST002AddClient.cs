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
   
	class SST002AddClient
    {
        
        [Test]
        public void AddClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
                driver.Navigate().GoToUrl(Config.GetUrl());
                				
                var logInPage = new LogInPage(driver);

                logInPage.LogIn(LogInLogOut.Username(), LogInLogOut.Password());

                logInPage.ClickAddClient();

                                                
                var addClientPage = new AddClientPage(driver);

                driver.Title.ShouldBe(AddClient.AddClientPage());
                Console.WriteLine($"{AddClient.AddClientPage()} opens.");

                addClientPage.SelectTeacherID(AddClient.TeacherID());
                
                var client = new AddClient();
                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                Thread.Sleep(1000);

                var tableText = addClientPage.GetTableText();

                Console.WriteLine(tableText);
                tableText.ShouldContain(client.FirstName);
                tableText.ShouldContain(client.LastName);
                tableText.ShouldContain(client.Email);
			}
		}
    }
}
