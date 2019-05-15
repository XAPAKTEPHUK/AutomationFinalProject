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
	//TODO: as far as I undestand, this page's name should be ClientsPage
    public class DeleteClientPage
    {
        private IWebDriver _driver;
        public DeleteClientPage(IWebDriver driver)
        {
            _driver = driver;
        }

		//TODO: the xpath needs to be improved
        private IWebElement ID => _driver.FindElement(By.XPath("//*[@class='table']/tbody/tr/td[1]/a")); //have to change it to a more proper selector
        private IWebElement XButton => _driver.FindElement(By.XPath("//*[@class='glyphicon glyphicon-remove']")); 
        private IWebElement Confirm => _driver.FindElement(By.XPath("//*[contains(text(),'Confirm')]"));
        private IWebElement NoRecord => _driver.FindElement(By.XPath("//*[contains(text(),'No records found')]"));

		//TODO: The name of the mehod has to be improved
        public void Xbutton()
        {
            XButton.Click();
        }

	    //TODO: The name of the mehod has to be improved
		public string Id()
        {
           return ID.Text;
        }

	    //TODO: The name of the mehod has to be improved
		public void IdSelect()
        {
            ID.Click();
        }

	    //TODO: The name of the mehod has to be improved
		public void ConfirmClick()
        {
            Confirm.Click();
        }

	    //TODO: The name of the mehod has to be improved
		public string NoRecordFound()
        {
            return NoRecord.Text;
        }
    }
}
