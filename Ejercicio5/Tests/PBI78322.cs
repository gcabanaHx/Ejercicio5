using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78322:BaseTest 
    {

    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    [Test]
        public void UserCreationPage_UserCreation_VerifyIfAdminIsNotAbleToCreateUserWithoutExams() 
        {
        navigateToBackOffice();
        hp.CrearUsuarioBtn.Click();
        //Complete user and password
        ucp.UserField.WaitUntilVisible(2);
        ucp.UserField.Write("testingAcademy_095");
        ucp.PwdField.Write("abc123");
        //Does not select any exam and clicks create user
        ucp.CrearUsuarioBtn.Click();
       
        if (ucp.UserCreationFail.Text.Equals("Ha ocurrido un error: tiene que seleccionar al menos un test"))
        {
            ucp.flag = true;
            Console.WriteLine(ucp.UserCreationFail.Text);
        }
        Assert.True(ucp.flag, "User Not Created");
    }


 
    }

