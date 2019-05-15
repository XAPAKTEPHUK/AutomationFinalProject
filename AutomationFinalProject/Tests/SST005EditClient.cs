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
	
	class SST005EditClient
    {
        [Test]
		
        public void EditClientPage()
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
                				
                var deleteClient = new ClientPage(driver);

                var IdNumber = deleteClient.GetClientID();
                deleteClient.ClickClientID();
                
                Thread.Sleep(1000);
                driver.Title.ShouldBe(EditClient.EditClientPage() + " " + IdNumber);

                var editClientPage = new EditClientPage(driver);

                editClientPage.ChangeFirstName(EditClient.FirstName());
                editClientPage.ChangeLastName(EditClient.LastName());
                editClientPage.ChangeEMail(EditClient.Email());
                editClientPage.ClickSave();

                var tableText = editClientPage.GetTableText();

                Console.WriteLine(tableText);
                tableText.ShouldContain(EditClient.FirstName());
                tableText.ShouldContain(EditClient.LastName());
                tableText.ShouldContain(EditClient.Email());
                                
            }
        }
    }
}   
