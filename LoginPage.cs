using OpenQA.Selenium;
using System;

namespace AddressBook_v4
{
    public class LoginPage
    {       
        private const string userNameFieldXPath = "//*[@id='LoginForm']/input[@name='user']";
        private const string passwordFieldXPath = "//*[@id='LoginForm']/input[@name='pass']";
        private const string loginButtonXPath = "//*[@id='LoginForm']/input[@value='Login']";
        private const string logoutLinkXPath = "//div[@id='top']/form/a[text()='Logout']";

        private const string userNameFieldName = "Username field";
        private const string passwordFieldName = "Password field";
        private const string loginButtonName = "Login button";
        private const string logoutLinkName = "Logout link";

        private IWebElement TxtUserName => WebDriverManager.Driver.FindElementAfterWait(By.XPath(userNameFieldXPath));
        private IWebElement TxtPassword => WebDriverManager.Driver.FindElementAfterWait(By.XPath(passwordFieldXPath));
        private IWebElement BtnLogin => WebDriverManager.Driver.FindElementAfterWait(By.XPath(loginButtonXPath));
        private IWebElement LnkLogout => WebDriverManager.Driver.FindElementAfterWait(By.XPath(logoutLinkXPath));

        public LoginPage OpenLoginPage()
        {
            WebDriverManager.GetToBaseUrl();
            return this;
        }

        public LoginPage SetUserNameTextBox(string userName)
        {
            TxtUserName.EnterText(userName, userNameFieldName);            
            return this;
        }
        
        public LoginPage SetPasswordTextBox(string password)
        {
            TxtPassword.EnterText(password, passwordFieldName);            
            return this;
        }
        
        public void ClickLoginButton()
        {            
            BtnLogin.ClickElement(loginButtonName);            
        }

        public LoginPage ClickLogoutLink()
        {
            LnkLogout.ClickElement(logoutLinkName);            
            return this;
        }

        public bool CheckLogoutLinkNotPresented()
        {
            return WebDriverManager.Driver.FindElements(By.XPath(logoutLinkXPath)).Count == 0;
        }
    }
}