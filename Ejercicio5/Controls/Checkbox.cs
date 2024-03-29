﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Controls
{
    public class CheckBox : BaseControl
    {
        public CheckBox(By by) : base(by)
        {
        }
        public CheckBox(IWebElement webElement)
          : base(webElement)
        { }
        //public void Check() => this.WebElement.Click();

        public void Check()
        {
            if (IsChecked().Equals(false))
            {
                this.WebElement.Click();
            }
        }

        public void UnCheck()
        {
            if (IsChecked().Equals(true))
            {
                this.WebElement.Click();
            }
        }
        public bool IsChecked()
        {
            var webElement = this.WebElement;
            bool flag = false; 
            if (webElement.GetAttribute("class").Contains("ng-not-empty"))
            {
                flag = true;
            }
            return flag;
        }

       /* public bool UnChecked()
        {
            var webElement = this.WebElement;
            bool flag = false;
            if (webElement.GetAttribute("class").Contains("ng-empty"))
            {
                flag = true;
            }
            return flag;
        }*/

    }
}
