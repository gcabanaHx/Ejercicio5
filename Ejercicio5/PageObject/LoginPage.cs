using Ejercicio4.Tests;
using Ejercicio5.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.PageObject
{

    public class LoginPage : BasePage//Herencia para usar la misma instancia
                                     // del driver inicializada en base test
    {
        public LoginPage() : base(By.CssSelector("body"))
        {

        }

        //public IWebElement userInput => Container.FindElement(By.CssSelector("input#log-usuario"));
        //public  IWebElement passwordInput => Container.FindElement(By.CssSelector("input#log-pwd"));
        //public IWebElement ingresarBtn => Container.FindElement(By.CssSelector("div.caja-formulario button"));
        //public IWebElement loginFail => Container.FindElement(By.CssSelector("div.alert"));

        public TextBox userInput
        {
            get
            {
                try
                {
                    return new TextBox(By.CssSelector("input#log-usuario"));
                }
                catch
                {
                    return null;
                }

            }
        }
        public TextBox passwordInput
        {
            get
            {
                try
                {
                    return new TextBox(By.CssSelector("input#log-pwd"));
                }
                catch
                {
                    return null;
                }

            }
        }
        public Button ingresarBtn
        {
            get
            {
                try
                {
                    return new Button(By.CssSelector("div.caja-formulario button"));
                }
                catch
                {
                    return null;
                }
            }
        }
        public Label loginFail
        {
            get
            {
                try
                {
                    return new Label(By.CssSelector("div.alert"));
                }
                catch
                {
                    return null;
                }
            }
        }

        public Label userDataLabel
        {
            get
            {
                try { return new Label(By.CssSelector(".data-user")); }
                catch { return null; }
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
                catch
                {
                    return null;
                }

            }
        }

        public bool flag = false;

    }
}
