using OpenQA.Selenium;
using Saucedemo_UI.src.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.pages.navbar
{
    internal class NavBarSteps
    {

        public static int GetShoppingCartItemsCount()
        {
            UIHandler.wait(50).Until(d => d.FindElement(NavBar.cartItems));
            IWebElement element = UIHandler.FindElement(NavBar.shoupingCartContainer).FindElement(NavBar.cartItems);


            string count = UIHandler.GetElementText(NavBar.cartItems);
            return int.Parse(count);
        }
    }
}
