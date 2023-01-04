using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class PBI78323:BaseTest 
    {

    HomePage hp = new HomePage();
    UserCreationPage ucp = new UserCreationPage();
    [Test]
        public void VerifyUser() //Verify if admin  is able to create user with 2 technical exams
        {
        navigateToBackOffice();
        hp.crearUsuarioBtn.Click();

        //Complete user and password
        ucp.userField.WaitUntilVisible(2);
        ucp.userField.Write("testingAcademy_095");
        ucp.pwdField.Write("abc123");
        //Select 2 technical exams
        ucp.tecnicoCheckBox.Click();
        ucp.testingTecnicoCheckBox.Click();


        if (ucp.tecnicoCheckBox.Selected && ucp.testingTecnicoCheckBox.Selected)
        {
            ucp.flag = true;
            Console.WriteLine("2 TECHNICAL EXAMS SELECTED");
        }
        else
        {
            ucp.flag = false;
            Console.WriteLine("1 TECHNICAL EXAM SELECTED");
        }

        Assert.True(ucp.flag,"Could not select 2 techincal exams");
        }


 
    }

