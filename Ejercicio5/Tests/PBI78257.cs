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
        public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingTecnicoExams() 
        {
        navigateToBackOffice();
        hp.CrearUsuarioBtn.Click();
        ucp.refresh();
        ucp.UserField.Write("T_A38");
        ucp.PwdField.Write("abc123");
        ucp.TestingTecnicoCheckBox.Check();//Select checkboxes
        ucp.CrearUsuarioBtn.Click();//Click crear usuario

        ucp.UserCreationFail.WaitUntilVisible(2);
        if (ucp.UserCreationFail.Text.Contains("Ha ocurrido un error"))
        {
            ucp.flag = false;
        }
        Assert.True(ucp.flag, "User Not Created");
    }


 
    }

