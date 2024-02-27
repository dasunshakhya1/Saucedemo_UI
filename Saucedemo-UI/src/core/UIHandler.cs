using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.core
{
    internal class UIHandler
    {
        private static IWebDriver? _driver;


        public static void OpenApplication()
        {
            _driver = DriverManager.GetWebDriver();
            _driver.Navigate().GoToUrl(Configs.BASE_URL);
        }

        public static IWebElement FindElement(By by)
        {
            return _driver.FindElement(by);
        }

        public static IList<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public static WebDriverWait wait(double time)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
        }

        public static void Type(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }

        public static void Click(By by)
        {
            FindElement(by).Click();
        }
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        public static void CustomClick(By by)
        {
            CustomActions.ClickAction(_driver, FindElement(by));
        }



        public static string GetElementText(By by)
        {
            return FindElement(by).Text;
        }
    }
}
