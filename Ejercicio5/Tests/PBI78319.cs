using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5.DriverManager;
using OpenQA.Selenium.DevTools;

public class PBI78319 : BaseTest
{
    private LoginPage LoginPage => new LoginPage();

    [Test]
    public void LoginPage_UserLogin_VerifyIfUserIsAbleToLoginWithPendingExams()
    {
        navigateToUserLogin();
        LoginPage.UserInput.Write("testingacademy_043");
        LoginPage.PasswordInput.Write("abc123");
        LoginPage.IngresarBtn.Click();
        Assert.True(LoginPage.UserDataLabel.Displayed);
    }
}