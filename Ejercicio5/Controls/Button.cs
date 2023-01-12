using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Controls
{
    public class Button : BaseControl
    {
        public Button(By findBy)
            : base(findBy)
        { }
        public Button(IWebElement webElement)
            : base(webElement)
        { }

        public void Click() => this.WebElement.Click();

        public void ClickWait()
        {
            this.WebElementWaiter.Click();
        }

    }
}
