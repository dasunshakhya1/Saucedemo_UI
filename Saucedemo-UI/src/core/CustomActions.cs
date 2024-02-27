using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.core
{
    internal class CustomActions
    {

        public static void ClickAction(IWebDriver driver, IWebElement element)
        {
            new Actions(driver).Click(element).Perform();
        }
    }
}
