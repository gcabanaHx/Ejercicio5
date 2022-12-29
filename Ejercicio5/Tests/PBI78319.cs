using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5;

public class PBI78319:BaseTest 
    {

    LoginPage lp = new LoginPage();

    [Test]
        public void VerifyUser() //Verify if user is able to log in with pending exams
        {
        navigateToUserLogin();
        lp.userInput.SendKeys("testingacademy_043");
        lp.passwordInput.SendKeys("abc123");
        lp.ingresarBtn.Click();

        Thread.Sleep(500);//Explicit wait
        if (DriverInstanceManager.Driver.Url.Contains("hexacta.com/#!/testSelection"))
        {
            Console.WriteLine("Loged");
            lp.flag = true;
        }
        Assert.IsTrue(lp.flag);
        }


 
    }

