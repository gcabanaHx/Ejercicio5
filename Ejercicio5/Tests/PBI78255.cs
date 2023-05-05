using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5.Utils;

public class PBI78255 : BaseTest
{
    private HomePage HomePage => new HomePage();
    private UserCreationPage UserCreationPage => new UserCreationPage();
    private UserListPage UserListPage => new UserListPage();

    [Test]
    public void UserCreationPage_UserCreation_AdminCreatesUserWithTecnicoExams()
    {
        var userFieldName = Utilities.GetRandomString();

        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationPage.UserField.WaitUntilVisible(2);
        UserCreationPage.UserField.Write(userFieldName);
        UserCreationPage.PwdField.Write("abc123");
        UserCreationPage.TecnicoCheckBox.Check();
        UserCreationPage.CrearUsuarioBtn.Click();

        Assert.True(UserListPage.UserCreationSucces.Displayed);
    }
}