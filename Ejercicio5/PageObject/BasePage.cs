using Ejercicio4.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.PageObject
{
    public class BasePage 
    {
        protected By locator;

        public BasePage(By by)
        {
            this.locator = by;
        }
        protected IWebDriver Driver
        {
            get { return DriverInstanceManager.Driver; }
        }
        
        protected IWebElement Container
        {
            get { return this.Driver.FindElement(locator); }
        }
    } 
}
