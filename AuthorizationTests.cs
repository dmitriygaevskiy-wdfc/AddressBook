using System;
using NUnit.Framework;

namespace AddressBook_v4
{
    public class AuthorizationTests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            WebDriverManager.SetUpDriverInstance(BrowserType.Chrome);
        }

        [TestCaseSource(typeof(LoginTestData), "TestCases"), Order(1)]
        public void Login(string userName, string password)
        {
            LoginPage signIn = new LoginPage()
                .OpenLoginPage();

            if (signIn.CheckLogoutLinkNotPresented())
            {
                signIn
                    .SetUserNameTextBox(userName)
                    .SetPasswordTextBox(password)
                    .ClickLoginButton();
            }
            else
            {
                signIn
                    .ClickLogoutLink()
                    .SetUserNameTextBox(userName)
                    .SetPasswordTextBox(password)
                    .ClickLoginButton();
            }

            HomePage loginResult = new HomePage();

            Assert.True(loginResult.CheckLoginButtonNotPresented(), "User is not logged in");
            Console.WriteLine("User is logged in");

            LoginHelper signOut = new LoginHelper()
                .DoLogout();
        }

        [Test, Order(2)]
        public void Logout()
        {
            LoginHelper login = new LoginHelper()
                .DoLogin();

            HomePage signedIn = new HomePage();
            signedIn
                .ClickLogoutLink();

            LoginPage signedOut = new LoginPage();

            Assert.True(signedOut.CheckLogoutLinkNotPresented(), "User is still logged in");
            Console.WriteLine("User is logged out");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriverInstance();
        }
    }
}
