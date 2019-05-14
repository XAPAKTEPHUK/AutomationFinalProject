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
    public class SST001
    {
        public const string username = "admin";
        public const string password = "2VLu=j^ykC";

        [Test]
        public static void LogInPage()
        {

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());
                var logInPage = new LogInPage(driver);                           
                logInPage.FillOutUsername(username);
                logInPage.FillOutPassword(password);
                logInPage.ClickLogin();                
                logInPage.ClickLogOut();               

            }
        }
    }
}
