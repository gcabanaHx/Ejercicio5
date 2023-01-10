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
        ucp.userField.Write("T_A02");
        ucp.pwdField.Write("abc123");
        ucp.inglesCheckBox.Click();        //Select checkboxes
        ucp.logicaCheckBox.Click();        //Select checkboxes
        ucp.tecnicoCheckBox.Click();
        ucp.crearUsuarioBtn.Click();        //Click crear usuario

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

