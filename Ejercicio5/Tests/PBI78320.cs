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

    LoginPage LoginPage => new LoginPage();

    [Test]
    public void LoginPage_UserLogin_UserIsNotAbleToLoginWithNotCreatedUser() 
    {
        navigateToUserLogin();
        LoginPage.UserInput.Write("user_not_created");
        LoginPage.PasswordInput.Write("abc123");
        LoginPage.IngresarBtn.Click();
        LoginPage.LoginFail.WaitUntilVisible(5); //Wait error display
        Assert.True(LoginPage.LoginFail.Displayed);
    }
}

