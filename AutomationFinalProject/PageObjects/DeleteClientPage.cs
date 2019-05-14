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
    public class DeleteClientPage
    {
        private IWebDriver _driver;
        public DeleteClientPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement ID => _driver.FindElement(By.XPath("//*[@class='table']/tbody/tr/td[1]/a")); //have to change it to a more proper selector
        private IWebElement XButton => _driver.FindElement(By.XPath("//*[@class='glyphicon glyphicon-remove']")); 
        private IWebElement Confirm => _driver.FindElement(By.XPath("//*[contains(text(),'Confirm')]"));
        private IWebElement NoRecord => _driver.FindElement(By.XPath("//*[contains(text(),'No records found')]"));

        public void Xbutton()
        {
            XButton.Click();
        }

        public string Id()
        {
           return ID.Text;
        }
        public void IdSelect()
        {
            ID.Click();
        }

        public void ConfirmClick()
        {
            Confirm.Click();
        }

        public string NoRecordFound()
        {
            return NoRecord.Text;
        }


    }
}
