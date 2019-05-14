﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationFinalProject.TestData;

namespace AutomationFinalProject.PageObjects
{
    public class ClientSearchPage
    {
        private IWebDriver driver;
        public ClientSearchPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        private IWebElement SearchClients => driver.FindElement(By.XPath("//*[@id='navbar']/ul/li[2]/a")); //have to change it to a more proper selector
        private IWebElement SearchField => driver.FindElement(By.Id("q"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("//*[@class='btn btn-primary']"));
        private IWebElement CheckFirstName => driver.FindElement(By.XPath("//*[contains(text(),'Iryna')]"));
        private IWebElement CheckLastName => driver.FindElement(By.XPath("//*[contains(text(),'Shch')]"));


        public void ClickSearchClient()
        {
            SearchClients.Click();           
        }

        public void Search(string mail)
        {

            SearchField.SendKeys(mail);
        }
        public void ClickSearch()
        {
            SearchButton.Click();
        }
        public string FirstName()
        {
           return CheckFirstName.Text;
        }

        public string LastName()
        {
            return CheckLastName.Text;
        }

    }
}

