using Ejercicio5.DriverManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;

namespace Ejercicio5.DriverManager
{
    public static class WebDriverExtensions
    {
        //Find element or null
        public static IWebElement FindElementOrNull(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch
            {
                return null;
            }
        }

        //WaitUntil
        public static bool WaitUntil(this IWebDriver driver, Func<bool> func, int secondsTimeout = 80)
        {
            try
            {
                return new WebDriverWait(driver, TimeSpan.FromSeconds(secondsTimeout)).Until(x => func());
            }

            catch (WebDriverException)
            {
                return false;
            }
        }

        public static bool WaitUntilVisible(this IWebDriver driver, By by, int secondsTimeout = 80)
        {
            return driver.WaitUntil
                (
                    () => driver.FindElement(by).Displayed, secondsTimeout
                );
        }

        //Element exists
        public static bool ElementExists(this IWebDriver webDriver, IWebElement we)
        {
            try
            {
                return !string.IsNullOrEmpty(we.TagName);
            }
            catch
            {
                return false;
            }
        }

        //Find Element wait
        public static IWebElement FindElementWait(this IWebDriver driver, By by, int secondsTimeout)
        {
            try
            {
                driver.WaitUntilVisible(by, secondsTimeout);
                return driver.FindElement(by);
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<IWebElement> FindElementsWait(this IWebDriver driver, By by)
        {
            try
            {
                driver.WaitUntil(() => driver.FindElements(by).Count > 0);
                return driver.FindElements(by);
            }
            catch
            {
                return null;
            }
        }


    }
}
