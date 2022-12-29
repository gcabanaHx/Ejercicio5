using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5;

public class PBI78320 : BaseTest
{

    LoginPage lp = new LoginPage();

    [Test]
    public void VerifyUser() //Verify if user is unable to login with non created user
    {
        navigateToUserLogin();
        lp.userInput.SendKeys("user_not_created");
        lp.passwordInput.SendKeys("abc123");
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

