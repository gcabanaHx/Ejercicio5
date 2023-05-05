using Ejercicio4.PageObject;
using Ejercicio4.Tests;
using Ejercicio5.Controls;

public class PBI78321 : BaseTest
{

    LoginPage LoginPage => new LoginPage();


    [Test]
    public void LoginPage_UserLogin_VerifyIfUserIsNotAbleToLogInWithoutCompletingCredentials()
    {
        navigateToUserLogin();
        LoginPage.IngresarBtn.Click();
        LoginPage.LoginFail.WaitUntilVisible(2);
        Assert.True(LoginPage.LoginFail.Displayed);
    }
}

