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
    class SST005
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
                
                var deleteClientPage = new DeleteClientPage(driver);

                var IdNumber = deleteClientPage.Id();
                deleteClientPage.IdSelect();
                
                Thread.Sleep(1000);
                driver.Title.ShouldBe(Constants.EditClientPage() + " " + IdNumber);

                var editClientPage = new EditClientPage(driver);

                editClientPage.ChangeFirst(Constants.FirstName());
                editClientPage.ChangeLast(Constants.LastName());
                editClientPage.ChangeEMail(Constants.Email2());
                editClientPage.ClickSave();

                //deleteClientPage.IdSelect();
                Thread.Sleep(10000);

            }
        }
    }
}   
