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
    public class LogInTest
    {
        [Test, Order (1)]
        public void LogInPage()
        {

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());

                var logInPage = new LogInPage(driver);
                Thread.Sleep(1000);
                logInPage.ClickUsername();
                logInPage.FillOutUsername("admin");
                logInPage.ClickPassword();
                logInPage.FillOutPassword("2VLu=j^ykC");
                logInPage.ClickLogin();
                Thread.Sleep(1000);

                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();
                

                addClientPage.Company("Bredemann");
                
                var user = new User();
                addClientPage.FilloutContactInformation(user);
                Thread.Sleep(1000);
            }
        }
       /* [Test, Order (2)]
        public void ClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();
                Thread.Sleep(1000);


            }
        }*/
    }
}
