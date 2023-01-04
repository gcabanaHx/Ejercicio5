﻿using Ejercicio5.DriverManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Ejercicio5.Controls
{
    public class BaseControl
    {
        protected By locator;
        private IWebElement webElement;
 
        public BaseControl(By by)
        {
            this.locator = by;
        }

        public BaseControl(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        protected IWebDriver Driver
        {
            get
            {
                return DriverInstanceManager.Driver;
            }
        }

        protected IWebElement WebElement
        {
            get
            {
                try
                {
                    if (this.locator is not null)
                    {
                        this.webElement = this.Driver.FindElement(this.locator);
                    }
                    return this.webElement;
                }
                catch
                {
                    return null;
                }
            }
        }

        protected IWebElement WebElementWaiter
        {
            get
            {
                try
                {
                    return this.Driver.FindElementWait(this.locator, 30);
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool Displayed
        {
            get
            {
                try
                {
                    return this.WebElement.Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }
        public string Title
        {
            get
            {
                try
                {
                    return this.Driver.Title;
                }
                catch { return null; }
            }
        }

   

        public void ScrollToElement()
        {
            var actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(this.WebElement).Build().Perform();
            actionProvider.Reset();
        }

        public string GetAttributeValue(string attribute)
        {
            return this.WebElement.GetAttribute(attribute);
        }

        public bool WaitUntilVisible(int secondsTimeout = 80)
        {
            return this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
        }

    }
}