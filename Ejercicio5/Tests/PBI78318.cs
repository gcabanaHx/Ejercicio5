using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78318 : BaseTest
{
    private LoginPage LoginPage => new LoginPage();

    [Test]
    public void LoginPage_UserLogin_UserIsNotAbleToLoginAfterCompletingExams()
    {
        navigateToUserLogin();
        LoginPage.UserInput.Write("testingacademy_042");
        LoginPage.PasswordInput.Write("abc123");
        LoginPage.IngresarBtn.Click();
        LoginPage.LoginFail.WaitUntilVisible(5);
        Assert.True(LoginPage.LoginFail.Displayed);
    }
}