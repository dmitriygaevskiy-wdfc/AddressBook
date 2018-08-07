using OpenQA.Selenium;
using System;

namespace AddressBook_v4
{
    public class ConfirmGroupActionPage
    {
        private const string returnToGroupsPageLinkXPath = "//*[@id='content']/div/i/a";

        private IWebElement LnkReturnToGroupsPage => WebDriverManager.Driver.FindElementAfterWait(By.XPath(returnToGroupsPageLinkXPath));

        public void ClickReturnToGroupsPageLink()
        {
            LnkReturnToGroupsPage.Click();
            Console.WriteLine("Return to Groups Page link is clicked");
        }
    }
}