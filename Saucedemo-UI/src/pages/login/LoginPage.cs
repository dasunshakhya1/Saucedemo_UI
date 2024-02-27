
using OpenQA.Selenium;

namespace Saucedemo_UI.src.pages.login
{
    internal class LoginPage
    {
        public static readonly By username = By.Id("user-name");
        public static readonly By password = By.Id("password");
        public static readonly By loginButton = By.Id("login-button");
    }
}
