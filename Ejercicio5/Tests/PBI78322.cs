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
        public void VerifyUser() //Verify if admin  is able to create user without exams
        {
        navigateToBackOffice();
        hp.clickCrearUsuario();
        ucp.refresh();
        //Complete user and password
        ucp.userField.SendKeys("testingAcademy_095");
        ucp.pwdField.SendKeys("abc123");
        //Does not select any exam and clicks create user
        ucp.btnCrearUsuario.Click();
       
        if (ucp.userCreationFail.Text.Equals("Ha ocurrido un error: tiene que seleccionar al menos un test"))
        {
            ucp.flag = false;
            Console.WriteLine(ucp.userCreationFail.Text);
        }
     
        Assert.False(ucp.flag, "User Not Created");
    }


 
    }

