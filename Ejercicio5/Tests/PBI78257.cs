using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5.Utils;

public class PBI78257 : BaseTest
{
    private HomePage HomePage => new HomePage();
    private UserCreationPage UserCreationPage => new UserCreationPage();
    private UserListPage UserListPage = new UserListPage();

    [Test]
    public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingTecnicoExams()
    {
        var userFieldName = Utilities.GetRandomString();
        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationPage.refresh();
        UserCreationPage.UserField.Write(userFieldName);
        UserCreationPage.PwdField.Write("abc123");
        UserCreationPage.TestingTecnicoCheckBox.Check();
        UserCreationPage.CrearUsuarioBtn.Click();

        Assert.True(UserListPage.UserCreationSucces.Displayed);
    }
}