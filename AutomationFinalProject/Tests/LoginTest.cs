﻿using System;
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
        public const string username = "admin";
        public const string password = "2VLu=j^ykC";

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
                logInPage.FillOutUsername(username);
                logInPage.ClickPassword();
                logInPage.FillOutPassword(password);
                logInPage.ClickLogin();
                Thread.Sleep(1000);

                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();
                

                addClientPage.Company("Bredemann");
                
                var client = new Client();
                addClientPage.FilloutContactInformation(client);
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
