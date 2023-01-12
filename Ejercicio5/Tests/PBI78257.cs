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
        public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingTecnicoExams() //Create user only with testing tecnico
        {
        navigateToBackOffice();
        hp.CrearUsuarioBtn.Click();
        ucp.UserField.WaitUntilVisible(3);
        ucp.UserField.Write("testingAcademy_101");
        ucp.PwdField.Write("abc123");
        ucp.TestingTecnicoCheckBox.Click();//Select checkboxes
        ucp.CrearUsuarioBtn.Click();//Click crear usuario

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

