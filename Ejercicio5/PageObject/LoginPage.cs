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

    public class LoginPage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        public LoginPage() :base(By.CssSelector("body"))
        {
            
        }

        public IWebElement userInput => Container.FindElement(By.CssSelector("input#log-usuario"));
        public  IWebElement passwordInput => Container.FindElement(By.CssSelector("input#log-pwd"));
        public IWebElement ingresarBtn => Container.FindElement(By.CssSelector("div.caja-formulario button"));
        public IWebElement loginFail => Container.FindElement(By.CssSelector("div.alert"));

        public bool flag = false;
    }
}
