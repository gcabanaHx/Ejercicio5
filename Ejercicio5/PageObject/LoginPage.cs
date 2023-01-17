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
        public LoginPage() : base(By.CssSelector("body[ng-app=examenInglesApp]"))
        {

        }

        public TextBox UserInput => new TextBox(Container.FindElement(By.CssSelector("input#log-usuario")));
        public TextBox PasswordInput => new TextBox(Container.FindElement(By.CssSelector("input#log-pwd")));
        public Button IngresarBtn => new Button(Container.FindElement(By.CssSelector("div.caja-formulario button")));
        public Label LoginFail => new Label(Container.FindElement(By.CssSelector("div.alert")));
        public Label UserDataLabel => new Label(Container.FindElement(By.CssSelector(".data-user")));


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
