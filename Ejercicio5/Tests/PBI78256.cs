using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Xunit.Abstractions;

public class PBI78256 : BaseTest
{


    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();


    [Test]
    public void CreateUser() //Create user only with testing
    {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();
        ucp.refresh(); //if the page is not refreshed, stale element expection will be displayed
        
        //Complete user and password
        ucp.userField.Write("testingAcademy_054");
        ucp.pwdField.Write("abc123");
       
        //Select checkboxes
        ucp.testingCheckBox.Click();
       
        //Click crear usuario
        ucp.crearUsuarioBtn.Click();


        //Verify if user is created
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

