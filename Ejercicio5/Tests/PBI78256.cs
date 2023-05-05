using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Xunit.Abstractions;
using Ejercicio5.DriverManager;
using Ejercicio5.Utils;

public class PBI78256 : BaseTest
{
    private HomePage HomePage => new HomePage();
    private UserCreationPage UserCreationpage => new UserCreationPage();
    private UserListPage UserListPage => new UserListPage();

    [Test]
    public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingExams()
    {
        var userFieldName = Utilities.GetRandomString();

        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationpage.UserField.Write(userFieldName);
        UserCreationpage.PwdField.Write("abc123");
        UserCreationpage.TestingCheckBox.Check();
        UserCreationpage.CrearUsuarioBtn.Click();

        Assert.True(UserListPage.UserCreationSucces.Displayed);
    }
}