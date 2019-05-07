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
        [Test]
        public void LogInPage()
        {
            var user = new User();           

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Navigate().GoToUrl(Config.GetUrl());

                var logInPage = new LogInPage(driver);
                Thread.Sleep(1000);
                logInPage.ClickUsername("admin");
                logInPage.ClickPassword("2VLu=j^ykC");
                logInPage.ClickLogin();

                Thread.Sleep(10000);
            }


        }
    }
}
