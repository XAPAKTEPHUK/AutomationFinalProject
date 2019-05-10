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
    public class DeleteClientPage
    {
        private IWebDriver _driver;
        public DeleteClientPage(IWebDriver driver)
        {
            _driver = driver;
        }
        //private IWebElement XButton => _driver.FindElement(By.LinkText("delete"));
        //private IWebElement ID => _driver.FindElement(By.TagName("Click To Edit"));
        private IWebElement ID => _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[3]/table/tbody/tr/td[1]/a"));
        private IWebElement XButton => _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[3]/table/tbody/tr/td[6]/a/span"));
        private IWebElement Confirm => _driver.FindElement(By.XPath("//*[@id='removeQuestion']/div[1]/div[2]/button[1]"));

        public void Xbutton()
        {
            XButton.Click();
        }

        public string Id()
        {
           return ID.Text;
        }

        public void ConfirmClick()
        {
            Confirm.Click();
        }


    }
}