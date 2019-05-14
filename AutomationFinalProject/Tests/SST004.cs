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
    class SST004
    {          

        [Test]
        public void DeleteClientPage()
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

                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();

                addClientPage.SelectTeacherID(Constants.TeacherID());
                
                var client = new Client();

                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                Thread.Sleep(1000);

                var deleteClientPage = new DeleteClientPage(driver);

                var IdNumber = deleteClientPage.Id();

                deleteClientPage.Xbutton();
                Thread.Sleep(1000);
                deleteClientPage.ConfirmClick();
                Thread.Sleep(1000);
               

                var clientSearchPage = new ClientSearchPage(driver);

                clientSearchPage.Search(IdNumber);
                clientSearchPage.ClickSearch();
                Thread.Sleep(1000);

                deleteClientPage.NoRecordFound().ShouldBe(Constants.NoR());

            }
        }
    }
}