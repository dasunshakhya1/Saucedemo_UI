using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.pages.navbar
{
    internal class NavBar
    {
        public static readonly By cartItems = By.ClassName("shopping_cart_badge");
        public static readonly By shoupingCartContainer = By.ClassName("shopping_cart_container");
    }
}
