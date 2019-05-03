using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFinalProject.Configuration;

namespace AutomationFinalProject.WebDriver
{
    class DriverUtils
    {
        public static IWebDriver CreateWebDriver()
        {
            string browser = Config.GetBrowser();
            if (browser == "Chrome")
            {
                return new ChromeDriver();
            }
            else if (browser == "FireFox")
            {
                return new FirefoxDriver();
            }
            else
            {
                throw new InvalidOperationException("Browser is not supported");
            }
        }
    }
}
