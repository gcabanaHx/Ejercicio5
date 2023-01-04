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
        hp.crearUsuarioBtn.Click();
        //Complete user and password
        ucp.userField.WaitUntilVisible(2);
        ucp.userField.Write("testingAcademy_095");
        ucp.pwdField.Write("abc123");
        //Does not select any exam and clicks create user
        ucp.crearUsuarioBtn.Click();
       
        if (ucp.userCreationFail.Text.Equals("Ha ocurrido un error: tiene que seleccionar al menos un test"))
        {
            ucp.flag = true;
            Console.WriteLine(ucp.userCreationFail.Text);
        }
        Assert.True(ucp.flag, "User Not Created");
    }


 
    }

