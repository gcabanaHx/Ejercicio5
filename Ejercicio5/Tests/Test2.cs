using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class Test2 : BaseTest  //Herencia    para usar la instancia del
                               //driver inicializada en la clase base test

{
    HomePage hp = new HomePage();
    CoursesPage cp = new CoursesPage();
    [Test]
    public void ValidateCourses()
    {
        hp.clickCoursesLink();
        cp.searchCoursesBar("C#");
        Assert.True(cp.CourseIsPresent("C#"));
    }
}

