using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;
using Xunit.Abstractions;
using Ejercicio5.DriverManager;

public class PBI78256 : BaseTest
{


    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    UserListPage ulp = new UserListPage();


    [Test]
    public void UserCreationPage_UserCreation_AdminCreatesUserWithTestingExams()
    {
        navigateToBackOffice();
        hp.CrearUsuarioBtn.Click();
        ucp.refresh(); // if not, stale element will be displayed
        ucp.UserField.Write("T_A37");//Complete user and password
        ucp.PwdField.Write("abc123");
        ucp.TestingCheckBox.Click();//Select checkboxes
        ucp.CrearUsuarioBtn.Click();//Click crear usuario

        //Verify if user is created
        ucp.UserCreationFail.WaitUntilVisible(4);
        if (ucp.UserCreationFail.Text.Contains("Ha ocurrido un error"))
        {
            ucp.flag = false;
        }
        Assert.True(ucp.flag, "User Not Created");
    }
}

