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
    public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingExams() //Create user only with testing
    {
        navigateToBackOffice();
        hp.CrearUsuarioBtn.Click();
        ucp.UserField.WaitUntilVisible(2);
        ucp.UserField.Write("T_A021");//Complete user and password
        ucp.PwdField.Write("abc123");
        ucp.TestingCheckBox.Click();//Select checkboxes
        ucp.CrearUsuarioBtn.Click();//Click crear usuario

        //Verify if user is created
        ucp.UserCreationFail.WaitUntilVisible(2);
        if (ucp.UserCreationFail.Text.Equals("Ha ocurrido un error: El usuario que intenta crear ya existe, intente de nuevo con otro nombre."))
        {
            ulp.flag = false;
        }
        else if (ulp.UserCreationSucces.Text.Equals("El usuario se registró correctamente"))
        {
            ulp.flag = true;
            Console.WriteLine("User created");
        }
        Assert.True(ulp.flag, "User Not Created");
    }
}

