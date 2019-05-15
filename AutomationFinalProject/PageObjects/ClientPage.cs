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
    public class ClientPage
    {
        private IWebDriver _driver;
        public ClientPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        private IWebElement ID => _driver.FindElement(By.XPath("//*[@class='table']/tbody/tr/td[1]")); 
        private IWebElement XButton => _driver.FindElement(By.XPath("//*[@class='glyphicon glyphicon-remove']")); 
        private IWebElement Confirm => _driver.FindElement(By.XPath("//*[contains(text(),'Confirm')]"));
        private IWebElement NoRecord => _driver.FindElement(By.XPath("//*[contains(text(),'No records found')]"));
        		
        public void DeleteButton()
        {
            XButton.Click();
        }
	   
		public string GetClientID()
        {
           return ID.Text;
        }
	    
		public void ClickClientID()
        {
            ID.Click();
        }
	    
		public void ConfirmButtonClick()
        {
            Confirm.Click();
        }
	    
		public string DeleteConfirm()
        {
            return NoRecord.Text;
        }
    }
}
