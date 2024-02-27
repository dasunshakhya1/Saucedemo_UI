using Saucedemo_UI.src.core;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.pages.login
{
    internal class LoginSteps
    {

        public static void Login(string username, string password)
        {
            UIHandler.OpenApplication();
            UIHandler.wait(50).Until(d => d.FindElement(LoginPage.loginButton).Displayed);
            UIHandler.Type(LoginPage.username, username);
            UIHandler.Type(LoginPage.password, password);
            UIHandler.Click(LoginPage.loginButton);
        }
    }
}
