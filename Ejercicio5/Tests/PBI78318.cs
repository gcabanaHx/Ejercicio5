using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78318:BaseTest 
    {

    LoginPage lp = new LoginPage();

    [Test]
        public void VerifyUser() //Verify login after completing all exams
        {
        navigateToUserLogin();
        lp.userInput.SendKeys("testingacademy_042");
        lp.passwordInput.SendKeys("abc123");
        lp.ingresarBtn.Click();
        
        Thread.Sleep(500); //Explicit wait

        if (lp.loginFail.Displayed)
            {
            lp.flag = false;
            Console.WriteLine(lp.loginFail.Text);
            }

        Assert.False(lp.flag);
      
        }


 
    }

