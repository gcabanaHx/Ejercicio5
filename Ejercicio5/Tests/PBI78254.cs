using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Ejercicio5.Utils;

public class PBI78254 : BaseTest
{
    private HomePage HomePage => new HomePage();
    private UserCreationPage UserCreationpage => new UserCreationPage();
    private UserListPage UserListPage => new UserListPage();

    [Test]
    public void UserCreationPage_UserCreation_AdminCreatesUserWithInglesLogicaAndTestingTecnicoExams()
    {
        var userFieldName = Utilities.GetRandomString();

        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationpage.UserField.WaitUntilVisible(2);
        UserCreationpage.UserField.Write(userFieldName);
        UserCreationpage.PwdField.Write("abc123");
        UserCreationpage.InglesCheckBox.Check();
        UserCreationpage.LogicaCheckBox.Check();
        UserCreationpage.TestingTecnicoCheckBox.Check();
        UserCreationpage.CrearUsuarioBtn.Click();

        Assert.True(UserListPage.UserCreationSucces.Displayed);
    }
}