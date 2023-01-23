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
        hp.CrearUsuarioBtn.Click();
        ucp.UserField.WaitUntilVisible(2);
        ucp.UserField.Write("T_A35");
        ucp.PwdField.Write("abc123");        
        ucp.InglesCheckBox.Check();//Select checkboxes
        ucp.LogicaCheckBox.Check();
        ucp.TestingCheckBox.Check();
        ucp.CrearUsuarioBtn.Click();//Click crear usuario

        //Check if user is created
        ucp.UserCreationFail.WaitUntilVisible(2);
        if (ucp.UserCreationFail.Text.Contains("Ha ocurrido un error"))
        {
            ucp.flag = false;
        }
        Assert.True(ucp.flag, "User Not Created, error displayed");
    }

 
    }

