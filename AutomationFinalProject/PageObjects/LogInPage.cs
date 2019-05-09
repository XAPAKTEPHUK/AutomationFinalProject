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
    public class LogInPage
    {
        private IWebDriver _driver;
        public LogInPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Username => _driver.FindElement(By.Id("username"));
        private IWebElement Password => _driver.FindElement(By.Id("password"));
        private IWebElement Login => _driver.FindElement(By.XPath("//*[@id='root']/div/div/form/div[3]/div/div/button"));//have to change it to a more proper selector
        private IWebElement Admin => _driver.FindElement(By.ClassName("dropdown-toggle"));
        private IWebElement LogOut => _driver.FindElement(By.XPath("//*[@id='navbar']/ul/li[5]/ul/li/a"));//have to change it to a more proper selector

        public void FillOutUsername(string username)
        {
            Username.Click();
            Username.SendKeys(username);
        }
               
        public void FillOutPassword(string password)
        {
            Password.Click();
            Password.SendKeys(password);
        }

        public void ClickLogin()
        {
            Login.Click();
        }

        public void ClickLogOut()
        {
            Admin.Click();
            LogOut.Click();
        }
        
    }
}