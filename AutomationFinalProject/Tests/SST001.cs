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
    public class SST001
    {
        
        [Test]
        public static void LogInPage()
        {

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // helps to deal with the timeout without using > Thread.Sleep <
                driver.Navigate().GoToUrl(Config.GetUrl());

                Thread.Sleep(1000);
                driver.Title.ShouldBe(Constants.LogInPage());

                var logInPage = new LogInPage(driver);                           
                logInPage.FillOutUsername(Constants.Username());
                logInPage.FillOutPassword(Constants.Password());
                logInPage.ClickLogin();

                Thread.Sleep(1000);

                driver.Title.ShouldBe(Constants.ClientPage());

                logInPage.GetAdminURL().ShouldBe(Constants.AdminURL());

                logInPage.ClickLogOut();

                Thread.Sleep(1000);

                driver.Title.ShouldBe(Constants.LogInPage());

            }
        }
    }
}
