using Ejercicio4.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ejercicio4.PageObject
{

 
    public  class SeleniumCPage: BasePage //Herencia para usar la misma instancia
                                         // del driver inicializada en base test
    {
        public SeleniumCPage() : base(By.CssSelector(".course-landing-page "))
        {
        }

        IWebElement signIn => Container.FindElement(By.CssSelector("a[href*='/users/sign_in']"));
        IWebElement headerWrapper => Container.FindElement(By.CssSelector("div.header__wrapper"));
        IWebElement video => Container.FindElement(By.CssSelector("div.section__video__wrapper"));

      
        public bool CheckUrl(string url)
        {
            bool flag = false;
            if (Driver.Url.Contains(url))
            {
                flag = true;
            }
            return flag;
            //Assert.Contains(url, driver.Url);
        }
        public bool CheckSignIn()
        {
            bool flag = false;
            if (signIn.Displayed)
            {
                flag = true;
            }
            return flag;
            //Assert.True(signIn.Displayed, "SignIn Not Displayed");
        }

        public bool CheckHeader()
        {
            bool flag = false;
            if (headerWrapper.Displayed)
            {
                flag = true;
            }
            return flag;
            //Assert.True(headerWrapper.Displayed, "Header Not Displayed");
        }

        public bool CheckVideo()
        {
            bool flag = false;
            if (video.Displayed)
            {
                flag = true;
            }
            return flag;
            //Assert.True(video.Displayed, "Video Not Displayed");
        }

    }
}
