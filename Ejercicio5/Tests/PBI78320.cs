using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5;
using Ejercicio5.Controls;

public class PBI78320 : BaseTest
{

    LoginPage lp = new LoginPage();

    [Test]
    public void LoginPage_UserLogin_UserIsNotAbleToLoginWithNotCreatedUser() 
    {
        navigateToUserLogin();
        lp.UserInput.Write("user_not_created");
        lp.PasswordInput.Write("abc123");
        lp.IngresarBtn.Click();
        lp.LoginFail.WaitUntilVisible(5); //Wait error display
        Assert.True(lp.LoginFail.Displayed);
    }
}

