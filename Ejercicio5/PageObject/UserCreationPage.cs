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
        public UserCreationPage() :base(By.CssSelector("body[ng-app=examen-ingles]"))
        {
            
        }
        public void refresh()
        {
            Driver.Navigate().Refresh();
        }

        public TextBox UserField => new TextBox(Container.FindElement(By.CssSelector("#usr")));
        public TextBox PwdField => new TextBox(Container.FindElement(By.CssSelector("#pwd")));
        public CheckBox InglesCheckBox => new CheckBox(Container.FindElement(By.CssSelector("input[name=ingles]")));
        public CheckBox LogicaCheckBox => new CheckBox(Container.FindElement(By.CssSelector("input[name=logica]")));
        public CheckBox TestingCheckBox => new CheckBox(Container.FindElement(By.CssSelector("input[name=testing]")));
        public CheckBox TecnicoCheckBox => new CheckBox(Container.FindElement(By.CssSelector("input[name=tecnico]")));
        public CheckBox TestingTecnicoCheckBox => new CheckBox(Container.FindElement(By.CssSelector("input[name=testingTecnico]")));
        public Button CrearUsuarioBtn => new Button(Container.FindElement(By.CssSelector("button.btn-CTA")));
        public Label UserCreationFail => new Label(Container.FindElement(By.CssSelector(".error-ocurrido")));
        public Label NotEmpty => new Label(Container.FindElement(By.CssSelector("ng-not-empty")));

        //Flag
        public bool flag = true ;
    
    } 
}
