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
        hp.CrearUsuarioBtn.Click();
        ucp.UserField.WaitUntilVisible(2);//Complete user and password
        ucp.UserField.Write("testingAcademy_095");
        ucp.PwdField.Write("abc123");
        ucp.TecnicoCheckBox.Check();     //Select 2 technical exams
        ucp.TestingTecnicoCheckBox.Check();
        Assert.True(ucp.TestingTecnicoCheckBox.IsChecked());
  
    }
}


