using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class Test1B : BaseTest
{

    HomePage hp = new HomePage();
    SeleniumCPage sp = new SeleniumCPage();

    [Test]
    public void ValidateLinkFail()
    {
        hp.clickSeleniumCLink();
        Assert.True(sp.CheckUrl("selenium"));
        Assert.True(sp.CheckSignIn());
        Assert.True(sp.CheckHeader());
        Assert.False(sp.CheckVideo());
    }


}

