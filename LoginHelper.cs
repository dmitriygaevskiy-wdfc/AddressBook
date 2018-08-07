using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_v4
{
    public class LoginHelper
    {
        private const string userName = "admin";
        private const string password = "secret";

        public LoginHelper DoLogin()
        {            
            LoginPage loginPage = new LoginPage()
                .OpenLoginPage()
                .SetUserNameTextBox(userName)
                .SetPasswordTextBox(password);
            loginPage
                .ClickLoginButton();
            Console.WriteLine("Logged in");

            return this;
        }

        public LoginHelper DoLogout()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogoutLink();
            Console.WriteLine("Logged out");

            return this;
        }
    }
}
