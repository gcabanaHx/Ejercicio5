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
    public void LoginPage_UserLogin_UserIsNotAbleToLoginWithNotCreatedUser() //Verify if user is unable to login with non created user
    {
        navigateToUserLogin();
        lp.userInput.Write("user_not_created");
        lp.passwordInput.Write("abc123");
        lp.ingresarBtn.Click();
        
        lp.loginFail.WaitUntilVisible(5); //Wait error display
        Assert.True(lp.loginFail.Displayed);
    }
}

