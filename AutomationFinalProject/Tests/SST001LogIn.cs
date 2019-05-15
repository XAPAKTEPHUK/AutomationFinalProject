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

    public class SST001LogIn
    {
        
        [Test]
        public static void LogInPage()
        {

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
                driver.Navigate().GoToUrl(Config.GetUrl());

                Thread.Sleep(1000);
                driver.Title.ShouldBe(LogInLogOut.LogInPage());
                Console.WriteLine($"{LogInLogOut.LogInPage()} opens.");

                var logInPage = new LogInPage(driver);

                logInPage.LogIn(LogInLogOut.Username(), LogInLogOut.Password());

                Thread.Sleep(1000);

                driver.Title.ShouldBe(LogInLogOut.ClientPage());
                Console.WriteLine($"{LogInLogOut.ClientPage()} opens.");

                logInPage.GetAdminURL().ShouldBe(LogInLogOut.AdminURL());
                Console.WriteLine($"'admin' link is {LogInLogOut.AdminURL()}");

                logInPage.ClickLogOut();

                Thread.Sleep(1000);

                driver.Title.ShouldBe(LogInLogOut.LogInPage());
                Console.WriteLine($"{LogInLogOut.LogInPage()} opens again.");

            }
        }
    }
}
