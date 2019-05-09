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
    class SST003
    {
        public const string username = "admin";
        public const string password = "2VLu=j^ykC";
        const string eMail = "ilka@mailinator.com";

        [Test]
        public void ClientSearchPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());
                var logInPage = new LogInPage(driver);
                logInPage.FillOutUsername(username);
                logInPage.FillOutPassword(password);
                logInPage.ClickLogin();

                var clientSearchPage = new ClientSearchPage(driver);
                clientSearchPage.ClickSearchClient();
                clientSearchPage.Search(eMail);
                clientSearchPage.ClickSearch();
                Thread.Sleep(5000);
            }
        }
    }
}