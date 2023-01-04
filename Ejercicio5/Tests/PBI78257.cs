using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78257:BaseTest 
    {
   
    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();

    [Test]
        public void CreateUser() //Create user only with testing tecnico
        {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();
        ucp.refresh(); //if the page is not refreshed, stale element expection will be displayed
        //Complete user and password
        ucp.userField.Write("testingAcademy_074");
        ucp.pwdField.Write("abc123");
        //Select checkboxes
        ucp.testingTecnicoCheckBox.Click();
        //Click crear usuario
        ucp.crearUsuarioBtn.Click();

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

