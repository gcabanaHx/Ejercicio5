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
        hp.CrearUsuarioBtn.Click();

        ucp.UserField.WaitUntilVisible(10);
        ucp.UserField.Write("T_A34");
        ucp.PwdField.Write("abc123");
        ucp.InglesCheckBox.Click();        //Select checkboxes
        ucp.LogicaCheckBox.Click();        //Select checkboxes
        ucp.TecnicoCheckBox.Click();
        ucp.CrearUsuarioBtn.Click();        //Click crear usuario

        //Chek if user is created
        ucp.UserCreationFail.WaitUntilVisible(2);
        if (ucp.UserCreationFail.Text.Contains("Ha ocurrido un error"))
        {
            ucp.flag = false;
        }
        Assert.True(ucp.flag, "User Not Created, error displayed");
    }

 
    }

