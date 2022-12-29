using Ejercicio5;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Tests
{
    public class BaseTest
    {
        //setup y teardown, para ser heredado

        public BaseTest()
        {
            //DriverInstanceManager.Driver.Navigate().GoToUrl("http://hxv-evaluaciondev.backoffice.hexacta.com/#!/");
        }

        public void navigateToBackOffice()
        {
            DriverInstanceManager.Driver.Navigate().GoToUrl("http://hxv-evaluaciondev.backoffice.hexacta.com/#!/");

        }

        public void navigateToUserLogin()
        {
            DriverInstanceManager.Driver.Navigate().GoToUrl("http://hxv-evaluaciondev.interview.hexacta.com/#!/");

        }

        public WebDriverWait wait()
        {
            return wait();
        }
        [TearDown]
        public void close()
        {
            DriverInstanceManager.CloseDriver();
        }
    }
}
