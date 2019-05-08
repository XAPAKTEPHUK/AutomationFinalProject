using System;
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
        private IWebElement Login => _driver.FindElement(By.XPath("//*[@id='root']/div/div/form/div[3]/div/div/button"));

        public void ClickUsername()
        {
            Username.Click();
        }
        public void FillOutUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void ClickPassword()
        {
            Password.Click();           
        }

        public void FillOutPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void ClickLogin()
        {
            Login.Click();
        }
    }
}