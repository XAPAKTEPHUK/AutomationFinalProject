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
    class SST002
    {
        public const string username = "admin";
        public const string password = "2VLu=j^ykC";

        [Test]
        public void AddClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());
                var logInPage = new LogInPage(driver);
                logInPage.FillOutUsername(username);
                logInPage.FillOutPassword(password);
                logInPage.ClickLogin();
                

                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();

                addClientPage.SelectTeacherID("Teacher One");
                
                var client = new Client();
                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                Thread.Sleep(1000);
            }
        }
    }
}
