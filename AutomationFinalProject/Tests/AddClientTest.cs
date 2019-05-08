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
    public class AddClientTest
    {
        [Test]
        public void ClientPage()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                var addClientPage = new AddClientPage(driver);

                addClientPage.ClickAddClient();

            }
        }
    }
}