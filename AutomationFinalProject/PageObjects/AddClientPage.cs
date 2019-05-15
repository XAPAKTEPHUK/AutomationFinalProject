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
    public class AddClientPage
    {
        private IWebDriver driver;
        public AddClientPage(IWebDriver _driver)
        {
            driver = _driver;
        }        

		//TODO: please create select element like:
        //private IWebElement TeacherSelect => driver.FindElement(By.XPath("//*[@name='teacherId']"));
		private SelectElement TeacherSelect => new SelectElement(driver.FindElement(By.Name("teacherId")));
        private IWebElement CompanyName => driver.FindElement(By.Name("company"));
        private IWebElement FirstName => driver.FindElement(By.Name("firstName"));
        private IWebElement LastName => driver.FindElement(By.Name("lastName"));		
        private IWebElement AdreesOne => driver.FindElement(By.Name("address1"));
        private IWebElement City => driver.FindElement(By.Name("city"));
        private IWebElement Country => driver.FindElement(By.Name("country"));
        private SelectElement StateSelect => new SelectElement (driver.FindElement(By.Name("state")));
        private IWebElement ZipCode => driver.FindElement(By.Name("zipCode"));
        private IWebElement PhoneNumber => driver.FindElement(By.Name("phoneNumber"));
        private IWebElement Email => driver.FindElement(By.Name("email"));
        private IWebElement SaveButton => driver.FindElement(By.XPath("//*[@class='btn btn-primary']"));
        private IWebElement Table => driver.FindElement(By.CssSelector("tbody"));
          
        public void SelectTeacherID(string teacherID)
        {
            TeacherSelect.SelectByText(teacherID);
        }     
               
        public void FilloutContactInformation(AddClient user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            PhoneNumber.SendKeys(user.PhoneNumber);
            Email.SendKeys(user.Email);
            CompanyName.SendKeys(user.Company);
        }

        public void SelectState(string State)
        {
            StateSelect.SelectByText(State);
        }

        public void FillZipCode(string zipCode)
        {
            ZipCode.SendKeys(zipCode);
        }

        public void ClickSave()
        {
            SaveButton.Click();
        }

        public string GetTableText()
        {
            return Table.Text;
        }       

    }
}
    