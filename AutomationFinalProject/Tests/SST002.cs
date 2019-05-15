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
    //TODO: the name of the class is difficult to understand
	class SST002
    {
        
        [Test]
        public void AddClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());

				//TODO: you perform this verification in the LogIn test. Do not repeat verification again.
                //Thread.Sleep(1000);
                //driver.Title.ShouldBe(Constants.LogInPage());

                var logInPage = new LogInPage(driver);
                logInPage.FillOutUsername(Constants.Username());
                logInPage.FillOutPassword(Constants.Password());
                logInPage.ClickLogin();

				//TODO: same as above
                Thread.Sleep(1000);
                driver.Title.ShouldBe(Constants.ClientPage());

				//TODO: technically you are not on the AddClientPage yet. After LogIn you are getting on Clients page. And then from Clients page you can click Add Client and only then new AddClientPage should be created

				var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();

                addClientPage.SelectTeacherID(Constants.TeacherID());
                
                var client = new Client();
                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                Thread.Sleep(1000);

				//TODO:Verify a table with your student record appears.
			}
		}
    }
}
