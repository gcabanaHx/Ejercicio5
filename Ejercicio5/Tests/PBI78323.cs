using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78323 : BaseTest
{

    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    [Test]
    public void VerifyUser() //Verify if admin  is able to create user with 2 technical exams
    {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();

        //Complete user and password
        ucp.userField.WaitUntilVisible(2);
        ucp.userField.Write("testingAcademy_095");
        ucp.pwdField.Write("abc123");
        //Select 2 technical exams
        ucp.tecnicoCheckBox.Click();
        ucp.testingTecnicoCheckBox.Click();

        var tecnicoCheckboxClasses = ucp.tecnicoCheckBox.GetAttributeValue("class");
        Assert.True(tecnicoCheckboxClasses.Contains("ng-empty")); 
    }
}


