using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Controls
{
    public class Label : BaseControl
    {
        public Label(By by) : base(by)
        {
        }
        public Label(IWebElement webElement)
          : base(webElement)
        { }

        public string Text
        {
            get
            {
                try
                {
                    return this.WebElement.Text;
                }
                catch
                {
                    return null;
                }
            }
        }

    }
}
