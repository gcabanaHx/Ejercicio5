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

    LoginPage lp = new LoginPage();

    [Test]
    public void LoginPage_UserLogin_VerifyIfUserIsAbleToLoginWithPendingExams()
    {
        navigateToUserLogin();
        lp.UserInput.Write("testingacademy_043");
        lp.PasswordInput.Write("abc123");
        lp.IngresarBtn.Click();
        Assert.True(lp.UserDataLabel.Displayed);
    }
}

