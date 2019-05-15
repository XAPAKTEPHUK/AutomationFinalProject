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
    class SST004DeleteClient
    {          

        [Test]
        public void ClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
                driver.Navigate().GoToUrl(Config.GetUrl());

                
                var logInPage = new LogInPage(driver);

                logInPage.LogIn(LogInLogOut.Username(), LogInLogOut.Password());

                logInPage.ClickAddClient();
                                
                var addClientPage = new AddClientPage(driver);
                                
                addClientPage.SelectTeacherID(AddClient.TeacherID());
                
                var client = new AddClient();

                addClientPage.FilloutContactInformation(client);
                addClientPage.ClickSave();
                Thread.Sleep(1000);

                var deleteClient = new ClientPage(driver);

                var IdNumber = deleteClient.GetClientID();

                deleteClient.DeleteButton();
                Thread.Sleep(1000);
                deleteClient.ConfirmButtonClick();
                Thread.Sleep(1000);
               

                var clientSearchPage = new ClientSearchPage(driver);

                clientSearchPage.SearchBy(IdNumber);
                clientSearchPage.ClickSearch();
                Thread.Sleep(1000);

                deleteClient.DeleteConfirm().ShouldBe(DeleteClient.NoRecord());

            }
        }
    }
}