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
    public void UserCreationPage_UserCreation_VerifyIfAdminIsNotAbleToCreateUserWith2OrMoreTechnicalExams() 
    {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();
        ucp.userField.WaitUntilVisible(2);//Complete user and password
        ucp.userField.Write("testingAcademy_095");
        ucp.pwdField.Write("abc123");
        ucp.tecnicoCheckBox.Click();     //Select 2 technical exams
        ucp.testingTecnicoCheckBox.Click();
        var tecnicoCheckboxClasses = ucp.tecnicoCheckBox.GetAttributeValue("class");//Assert if the first one is still selected
        Assert.True(tecnicoCheckboxClasses.Contains("ng-empty")); 
  
    }
}


