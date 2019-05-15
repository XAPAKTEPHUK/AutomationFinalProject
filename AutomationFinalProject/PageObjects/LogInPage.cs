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

        public void FillOutUsername(string username)
        {
			//TODO: why do you need Click here?
            Username.Click();
            Username.SendKeys(username);
        }
               
        public void FillOutPassword(string password)
        {
	        //TODO: why do you need Click here?
			Password.Click();
            Password.SendKeys(password);
        }

        public void ClickLogin()
        {
            Login.Click();
        }

		//TODO: you can also have LogIn method, which would enter the uername, the password and click the Login button. 2 in one...

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