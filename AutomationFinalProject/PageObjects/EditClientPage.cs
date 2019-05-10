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
    public class EditClientPage
    {
        private IWebDriver _driver;
        public EditClientPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FirstName => _driver.FindElement(By.Name("firstName"));
        private IWebElement LastName => _driver.FindElement(By.Name("lastName"));
        private IWebElement Email => _driver.FindElement(By.Name("email"));
        private IWebElement SaveButton => _driver.FindElement(By.XPath("//*[@id='root']/div/div/form/div[22]/div/div/button"));

        public void ChangeFirst(string newFirst)
        {
            FirstName.Clear();
            FirstName.SendKeys(newFirst);
        }

        public void ChangeLast(string newLast)
        {
            LastName.Clear();
            LastName.SendKeys(newLast);
        }
        
        public void ChangeEMail (string newEMail)
        {
            Email.Clear();
            Email.SendKeys(newEMail);
        }

        public void ClickSave()
        {
            SaveButton.Click();
        }

        
    }
}
