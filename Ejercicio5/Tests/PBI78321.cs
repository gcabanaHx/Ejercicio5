using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78321:BaseTest 
    {

    LoginPage lp = new LoginPage();

    [Test]
        public void VerifyUser() //Verify if user is able to log in without completing credentials
        {
        navigateToUserLogin();
        lp.ingresarBtn.Click();

        Thread.Sleep(500);//Explicit wait

            if (lp.loginFail.Displayed)
            {
            lp.flag = false;
            Console.WriteLine(lp.loginFail.Text);
            }

        Assert.False(lp.flag);
      
        }


 
    }

