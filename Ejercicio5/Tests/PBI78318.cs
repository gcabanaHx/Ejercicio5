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
        public void LoginPage_UserLogin_UserIsNotAbleToLoginAfterCompletingExams() //Verify login after completing all exams
        {
        navigateToUserLogin();
        lp.userInput.Write("testingacademy_042");
        lp.passwordInput.Write("abc123");
        lp.ingresarBtn.ClickWait();
        lp.loginFail.WaitUntilVisible(5);
        Assert.True(lp.loginFail.Displayed);      
        }
    }

