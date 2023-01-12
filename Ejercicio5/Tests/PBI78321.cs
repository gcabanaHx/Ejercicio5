using Ejercicio4.PageObject;
using Ejercicio4.Tests;
using Ejercicio5.Controls;

public class PBI78321 : BaseTest
{

    LoginPage lp = new LoginPage();


    [Test]
    public void LoginPage_UserLogin_VerifyIfUserIsNotAbleToLogInWithoutCompletingCredentials()
    {
        navigateToUserLogin();
        lp.IngresarBtn.Click();
        lp.LoginFail.WaitUntilVisible(2);
        Assert.True(lp.LoginFail.Displayed);
    }
}

