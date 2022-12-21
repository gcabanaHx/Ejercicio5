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

    public class UserCreationPage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        public UserCreationPage() :base(By.CssSelector("body"))
        {
            
        }
        public void refresh()
        {
            Driver.Navigate().Refresh();
        }
        public IWebElement userField => Container.FindElement(By.CssSelector("#usr"));
        public IWebElement pwdField => Container.FindElement(By.CssSelector("#pwd"));

        //Checkboxes
        public IWebElement inglesCheckBox => Container.FindElement(By.CssSelector("input[name=ingles]"));
        public IWebElement logicaCheckBox => Container.FindElement(By.CssSelector("input[name=logica]"));
        public IWebElement testingCheckBox => Container.FindElement(By.CssSelector("input[name=testing]"));
        public IWebElement tecnicoCheckBox => Container.FindElement(By.CssSelector("input[name=tecnico]"));
        public IWebElement testingTecnicoCheckBox => Container.FindElement(By.CssSelector("input[name=testingTecnico]"));

   
        //Btn
        public IWebElement btnCrearUsuario => Container.FindElement(By.CssSelector("button.btn-CTA"));
        public IWebElement userCreationFail => Container.FindElement(By.CssSelector(".error-ocurrido"));


    }
}
