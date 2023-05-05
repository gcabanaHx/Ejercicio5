using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78322 : BaseTest
{
    private HomePage HomePage => new HomePage();
    private UserCreationPage UserCreationPage => new UserCreationPage();

    [Test]
    public void UserCreationPage_UserCreation_VerifyIfAdminIsNotAbleToCreateUserWithoutExams()
    {
        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationPage.UserField.WaitUntilVisible(2);
        UserCreationPage.UserField.Write("testingAcademy_095");
        UserCreationPage.PwdField.Write("abc123");

        UserCreationPage.CrearUsuarioBtn.Click();

        Assert.AreEqual(UserCreationPage.UserCreationFail.Text, "Ha ocurrido un error: tiene que seleccionar al menos un test");
    }
}