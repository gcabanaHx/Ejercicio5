using Ejercicio4.Tests;
using Ejercicio5.DriverManager;
using OpenQA.Selenium;

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

        public void WaitUntilVisible(int secondsTimeout = 10)
        {
            this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
        }

    
    } 

}
