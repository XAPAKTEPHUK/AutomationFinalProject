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
    public class ClientSearchPage
    {
        private IWebDriver driver;
        public ClientSearchPage(IWebDriver _driver)
        {
            driver = _driver;
        }
        
        private IWebElement SearchClients => driver.FindElement(By.LinkText("Clients"));            
        private IWebElement SearchField => driver.FindElement(By.Id("q"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("//*[@class='btn btn-primary']"));
        private IWebElement Table => driver.FindElement(By.CssSelector("tbody"));
        private IWebElement FirstName => driver.FindElement(By.XPath("//*[@class='table']/tbody/tr/td[3]"));
        private IWebElement LastName => driver.FindElement(By.XPath("//*[@class='table']/tbody/tr/td[4]"));
        


        public void ClickSearchClient()
        {
            SearchClients.Click();           
        }
		
        public void SearchBy(string condition)
        {

            SearchField.SendKeys(condition);
        }
        public void ClickSearch()
        {
            SearchButton.Click();
        }
	    
		public string GetFirstName()
        {
           return FirstName.Text;
        }
	    
		public string GetLastName()
        {
            return LastName.Text;
        }

        public string GetTableText()
        {
            return Table.Text;
        }

    }
}

