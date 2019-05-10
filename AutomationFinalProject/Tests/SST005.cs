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
    class SST005
    {
        public const string username = "admin";
        public const string password = "2VLu=j^ykC";

        [Test]
        public void DeleteClientPage()
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
                addClientPage.Company("Bredemann");

                var client = new Client();

                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                
                var deleteClientPage = new DeleteClientPage(driver);

                var IdNumber = deleteClientPage.Id();
                deleteClientPage.IdSelect();
                Thread.Sleep(1000);

                var editClientPage = new EditClientPage(driver);

                editClientPage.ChangeFirst("Ivan");
                editClientPage.ChangeLast("Boychuk");
                editClientPage.ChangeEMail("ivanboychuk@bredemann.com");
                editClientPage.ClickSave();

                deleteClientPage.IdSelect();
                Thread.Sleep(10000);

            }
        }
    }
}   
