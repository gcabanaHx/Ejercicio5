using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78323 : BaseTest
{
    private HomePage HomePage = new HomePage();
    private UserCreationPage UserCreationPage = new UserCreationPage();

    [Test]
    public void UserCreationPage_UserCreation_VerifyIfAdminIsNotAbleToCreateUserWith2OrMoreTechnicalExams()
    {
        navigateToBackOffice();
        HomePage.CrearUsuarioBtn.Click();
        UserCreationPage.UserField.WaitUntilVisible(2);//Complete user and password
        UserCreationPage.UserField.Write("testingAcademy_095");
        UserCreationPage.PwdField.Write("abc123");
        UserCreationPage.TecnicoCheckBox.Check();     //Select 2 technical exams
        UserCreationPage.TestingTecnicoCheckBox.Check();
        Assert.True(UserCreationPage.TecnicoCheckBox.IsChecked());
    }
}