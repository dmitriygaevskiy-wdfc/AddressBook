using OpenQA.Selenium;
using System;

namespace AddressBook_v4
{
    public class HomePage
    {
        private const string loginButtonXPath = "//*[@id='LoginForm']/input[@value='Login']";
        private const string logoutLinkXPath = "//div[@id='top']/form/a[text()='Logout']";
        private const string homePageMenuLinkXPath = "//div[@id='nav']//li/a[text()='home']";
        private const string addNewContactMenuLinkXPath = "//div[@id='nav']//li/a[text()='add new']";
        private const string groupsPageMenuLinkXPath = "//div[@id='nav']//li/a[text()='groups']";

        private const string logoutLinkName = "Logout link";
        private const string homePageMenuLink = "Home Page link";
        private const string addNewContactMeduLinkName = "Add New Contact link";
        private const string groupsPageMenuLinkName = "Groups Page link";


        private IWebElement BtnLogin => WebDriverManager.Driver.FindElementAfterWait(By.XPath(loginButtonXPath));
        private IWebElement LnkLogout => WebDriverManager.Driver.FindElementAfterWait(By.XPath(logoutLinkXPath));
        private IWebElement MenuLinkHomePage => WebDriverManager.Driver.FindElementAfterWait(By.XPath(homePageMenuLinkXPath));
        private IWebElement MenuLinkAddContact => WebDriverManager.Driver.FindElementAfterWait(By.XPath(addNewContactMenuLinkXPath));
        private IWebElement MenuLinkGroupsPage => WebDriverManager.Driver.FindElementAfterWait(By.XPath(groupsPageMenuLinkXPath));

        public void ClickLogoutLink()
        {
            LnkLogout.ClickElement(logoutLinkName);            
        }

        public void ClickHomePageMenuLink()
        {
            MenuLinkHomePage.ClickElement(homePageMenuLink);
        }

        public void ClickAddContactMenuLink()
        {
            MenuLinkAddContact.ClickElement(addNewContactMeduLinkName);
        }

        public void ClickGroupsPageMenuLink()
        {
            MenuLinkGroupsPage.ClickElement(groupsPageMenuLinkName);
        }

        public bool CheckLoginButtonNotPresented()
        {
            return WebDriverManager.Driver.FindElements(By.XPath(loginButtonXPath)).Count == 0;
        }
    }
}