using NUnit.Framework;
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
            DriverInstanceManager.Driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");
        }

        [TearDown]
        public void close()
        {
            DriverInstanceManager.CloseDriver();
        }
    }
}
