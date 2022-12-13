using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public static class DriverInstanceManager
    {
        //Singleton del webdriver

        private static IWebDriver? driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--disable-notifications");
                    driver = new ChromeDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    driver.Manage().Window.Maximize();
                }
                return driver;
            }
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}
