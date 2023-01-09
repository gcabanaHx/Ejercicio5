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

    public class UserListPage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        public UserListPage() :base(By.CssSelector("body"))
        {
            
        }

        public bool flag = false;
        //public IWebElement userCreationSucces => Container.FindElement(By.CssSelector("strong[ng-show='user.message']"));

        public Label userCreationSucces
        {
            get
            {
                try
                {
                    return new Label(By.CssSelector("strong[ng-show='user.message']"));
                }
                catch { return null; }
            }
        }
    }
}
