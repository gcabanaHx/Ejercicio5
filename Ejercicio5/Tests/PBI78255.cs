using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78255:BaseTest 
    {
   
    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();

    [Test]
        public void CreateUser() //Create user only with testing tecnico
        {
        navigateToBackOffice();
        hp.clickCrearUsuario();
        ucp.refresh(); //if the page is not refreshed, stale element expection will be displayed
        //Complete user and password
        ucp.userField.SendKeys("testingAcademy_044");
        ucp.pwdField.SendKeys("abc123");
        //Select checkboxes
        ucp.tecnicoCheckBox.Click();
        //Click crear usuario
        ucp.btnCrearUsuario.Click();

        if (ucp.userCreationFail.Text.Equals("Ha ocurrido un error: El usuario que intenta crear ya existe, intente de nuevo con otro nombre."))
        {
            ulp.flag = false;
        }
        else if (ulp.userCreationSucces.Text.Equals("El usuario se registró correctamente"))
        {
            ulp.flag = true;
            Console.WriteLine("User created");
        }
        Assert.True(ulp.flag, "User Not Created");
    }

 
    }

