using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Controls
{
    public  class TextBox:BaseControl
    {
        public TextBox(By findBy)
           : base(findBy)
        { }
        public TextBox(IWebElement webElement)
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

        public void Write(string s)
        {
            this.WebElement.SendKeys(s);
        }
    }
}
