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
        public void LoginPage_UserLogin_UserIsNotAbleToLoginAfterCompletingExams() {  
        navigateToUserLogin();
        lp.UserInput.Write("testingacademy_042");
        lp.PasswordInput.Write("abc123");
        lp.IngresarBtn.Click();
        lp.LoginFail.WaitUntilVisible(5);
        Assert.True(lp.LoginFail.Displayed);      
        }
    }

