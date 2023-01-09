using Ejercicio4.Tests;
using Ejercicio5.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections;
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
        //public IWebElement userField => Container.FindElement(By.CssSelector("#usr"));
        public TextBox userField
        {
            get
            {
                try
                {
                    return new TextBox(By.CssSelector("#usr"));
                }
                catch { return null; }
            }
        }
        //public IWebElement pwdField => Container.FindElement(By.CssSelector("#pwd"));
        public TextBox pwdField
        {
            get
            {
                try
                {
                    return new TextBox(By.CssSelector("#pwd"));
                }
                catch { return null; }
            }
        }
        //Checkboxes
        //public IWebElement inglesCheckBox => Container.FindElement(By.CssSelector("input[name=ingles]"));
        public CheckBox inglesCheckBox
        {
            get
            {
                try
                {
                    return new CheckBox(By.CssSelector("input[name=ingles]"));
                }
                catch { return null; }
            }
        }
        //public IWebElement logicaCheckBox => Container.FindElement(By.CssSelector("input[name=logica]"));
        public CheckBox logicaCheckBox
        {
            get
            {
                try
                {
                    return new CheckBox(By.CssSelector("input[name=logica]"));
                }
                catch { return null; }
            }
        }
        //public IWebElement testingCheckBox => Container.FindElement(By.CssSelector("input[name=testing]"));
        public CheckBox testingCheckBox
        {
            get
            {
                try
                {
                    return new CheckBox(By.CssSelector("input[name=testing]"));
                }
                catch { return null; }
            }
        }

        //public IWebElement tecnicoCheckBox => Container.FindElement(By.CssSelector("input[name=tecnico]"));
        public CheckBox tecnicoCheckBox
        {
            get
            {
                try
                {
                    return new CheckBox(By.CssSelector("input[name=tecnico]"));
                }
                catch { return null; }
            }
        }
        //public IWebElement testingTecnicoCheckBox => Container.FindElement(By.CssSelector("input[name=testingTecnico]"));
        public CheckBox testingTecnicoCheckBox
        {
            get
            {
                try
                {
                    return new CheckBox(By.CssSelector("input[name=testingTecnico]"));
                }
                catch { return null; }
            }
        }

        //Btn
        // public IWebElement userCreation => Container.FindElement(By.CssSelector("button.btn-CTA"));
        public Button crearUsuarioBtn
        {
            get
            {
                try
                {
                    return new Button(By.CssSelector("button.btn-CTA"));
                }
                catch { return null; }
            }
        }

        //public IWebElement userCreationFail => Container.FindElement(By.CssSelector(".error-ocurrido"));
        public Label userCreationFail
        {
            get
            {
                try
                {
                    return new Label(By.CssSelector(".error-ocurrido"));
                }
                catch { return null; }
            }
        }

        public Label notEmpty
        {
            get
            {
                try
                {
                    return new Label(By.CssSelector("ng-not-empty"));
                }
                catch { return null; }
            }
        }


        //Flag
        public bool flag = true ;

        public Label tecnicoSelected
        {
            get
            {
                try
                {
                    return new Label(By.XPath(("//input[@name='tecnico' and @class='ng-valid ng-dirty ng-touched ng-not-empty ng-valid-parse']")));
                }
                catch { return null; }
            }
        }
        public Label testingTecnicoSelected
        {
            get
            {
                try
                {
                    return new Label(By.XPath(("//input[@name='testingTecnico' and @class='ng-valid ng-dirty ng-touched ng-not-empty ng-valid-parse']")));
                }
                catch { return null; }
            }
        }


    }

  
}
