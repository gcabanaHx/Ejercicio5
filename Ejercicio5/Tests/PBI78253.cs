using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78253:BaseTest 
    {
   
    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();

    [Test]
        public void UserCreationPage_UserCreation_AdminCreatesUserWithInglesLogicaAndTecnicoExams() //Create user with ingles logica, y tecnico
        {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();

        ucp.userField.WaitUntilVisible(10);
        ucp.userField.Write("testingAcademy_058");
        ucp.pwdField.Write("abc123");
        //Select checkboxes
        ucp.inglesCheckBox.Click();
        ucp.logicaCheckBox.Click();
        ucp.tecnicoCheckBox.Click();
        //Click crear usuario
        ucp.crearUsuarioBtn.Click();

        //Chek if user is created
        if (ucp.userCreationFail.Text.Equals("Ha ocurrido un error: El usuario que intenta crear ya existe, intente de nuevo con otro nombre."))
        {
            ulp.flag = false;
        }
        else if (ulp.userCreationSucces.WaitUntilVisible(2))
        {
            ulp.flag = true;
            Console.WriteLine("User created");
        }
        Assert.True(ulp.flag, "User Not Created");
    }

 
    }

