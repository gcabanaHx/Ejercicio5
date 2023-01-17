using Ejercicio4.Tests;
using Ejercicio5.Controls;
using Ejercicio5.DriverManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.PageObject
{

    public class UserListPage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        public UserListPage() :base(By.CssSelector("body"))
        {
            
        }

        public Label UserCreationSucces => new Label(Container.FindElement(By.CssSelector("strong[ng-show='user.message']")));
        public bool flag = false;

        public string GetUrl()
        {
            return DriverInstanceManager.Driver.Url;
        }


    }
}
