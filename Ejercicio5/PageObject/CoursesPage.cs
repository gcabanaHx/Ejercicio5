using Ejercicio4.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ejercicio4.PageObject
{

    public class CoursesPage : BasePage //Herencia para usar la misma instancia
                                        // del driver inicializada en base test
    {
        private Boolean flag;

        public CoursesPage() : base(By.CssSelector(".collections-landing-page "))
        {
        }

        IWebElement searchBar => Container.FindElement(By.CssSelector("input[name=q]"));

        public void searchCoursesBar(string search)
        {
            searchBar.SendKeys(search + Keys.Enter);
        }

        public bool CourseIsPresent(string search)
        {
            IList<IWebElement> lista = Container.FindElements(By.CssSelector("div.course-card__body"));


            foreach (IWebElement links in lista) //recorrer cada tarjeta y verificar titulo
            {
                String text = links.GetAttribute("innerText");

                if (text.Contains(search))
                {
                    flag = true;
                    break;
                }

            }
            //assert fuera de page object
            return flag;
        }
    }


}
