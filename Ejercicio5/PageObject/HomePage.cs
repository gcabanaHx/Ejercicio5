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

    public class HomePage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        public HomePage() :base(By.CssSelector(".tabla-resultados"))
        {
            
        }
        public Button CrearUsuarioBtn => new Button(Container.FindElement(By.CssSelector(".btn-CTA")));
    }
}
