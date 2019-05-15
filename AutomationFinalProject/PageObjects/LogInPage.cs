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
        private IWebElement Login => _driver.FindElement(By.XPath("//*[@class='input-group']/button"));
        private IWebElement Admin => _driver.FindElement(By.ClassName("dropdown-toggle"));
        private IWebElement LogOut => _driver.FindElement(By.XPath("//*[@class='dropdown-menu']/li/a"));//have to change it to a more proper selector
        private IWebElement AddClient => _driver.FindElement(By.PartialLinkText("Add Client"));

        public void LogIn(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();

        }
      
        public void ClickAddClient()
        {
            AddClient.Click();
        }

        public string GetAdminURL()
        {
            string URL = Admin.GetAttribute("href");
            return URL;
            
        }

        public void ClickLogOut()
        {
            Admin.Click();
            LogOut.Click();
        }
        
    }
}