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

        private IWebElement AddClient => driver.FindElement(By.PartialLinkText("Add Client")); 
        private IWebElement TeacherSelect => driver.FindElement(By.XPath("//*[@name='techerId']")); //does not work
        private SelectElement TeacherOne => new SelectElement(driver.FindElement(By.XPath("//*[@name='techerId']"))); //does not work
        private IWebElement CompanyName => driver.FindElement(By.Name("company"));
        private IWebElement FirstName => driver.FindElement(By.Name("firstName"));
        private IWebElement LastName => driver.FindElement(By.Name("lastName"));
        private IWebElement AdreesOne => driver.FindElement(By.Name("adress1"));
        private IWebElement City => driver.FindElement(By.Name("city"));
        private IWebElement Country => driver.FindElement(By.Name("country"));
        private IWebElement State => driver.FindElement(By.Name("state"));
        private IWebElement ZipCode => driver.FindElement(By.Name("zipCode"));
        private IWebElement PhoneNumber => driver.FindElement(By.Name("phoneNumber"));
        private IWebElement Email => driver.FindElement(By.Name("email"));




        public void ClickAddClient()
        {
            AddClient.Click();  
        }
       
        /*
        public void SelectTeacherID(string teacherID)
        {
            TeacherSelect.Click();
            TeacherOne.SelectByText(teacherID);
        }
        */

        public void Company(string companyName)
        {
            CompanyName.SendKeys(companyName);
        }
        
        public void FilloutContactInformation(Client user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            PhoneNumber.SendKeys(user.PhoneNumber);
            Email.SendKeys(user.Email);
        }

    }
}
    