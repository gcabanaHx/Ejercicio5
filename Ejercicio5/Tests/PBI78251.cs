using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78251:BaseTest 
    {
   
    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();

    [Test]
        public void UserCreationPage_UserCreation_AdminCreatesUserWithInglesLogicaAndTestingExams() 
        {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();

        ucp.userField.WaitUntilVisible(2);
        ucp.userField.Write("T_A01");
        ucp.pwdField.Write("abc123");        
        ucp.inglesCheckBox.Click();//Select checkboxes
        ucp.logicaCheckBox.Click();
        ucp.testingCheckBox.Click();
        ucp.crearUsuarioBtn.Click();//Click crear usuario

        //Check if user is created
        if (ucp.userCreationFail.Text.Equals("Ha ocurrido un error: El usuario que intenta crear ya existe, intente de nuevo con otro nombre."))
        {
            ulp.flag = false;
        }
        else if (ulp.userCreationSucces.Text.Equals("El usuario se registr� correctamente"))
        {
            ulp.flag = true;
            Console.WriteLine("User created");
        }
        Assert.True(ulp.flag, "User Not Created");
    }

 
    }

