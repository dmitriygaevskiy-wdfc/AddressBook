using OpenQA.Selenium;
using System;

namespace AddressBook_v4
{
    public class CreateNewGroupPage
    {
        private const string groupNameFieldXPath = "//*[@id='content']/form/input[1]";
        private const string groupHeaderFieldXPath = "//*[@id='content']/form/textarea[1]";
        private const string groupFooterFieldXPath = "//*[@id='content']/form/textarea[2]";
        private const string submitGroupCreationButtonXPath = "//*[@id='content']/form/input[2]";

        private const string groupNameFieldName = "Group name";
        private const string groupHeaderFieldName = "Group header";
        private const string groupFooterFieldName = "Group footer";
        private const string submitGroupButtonName = "Submit group details";

        private IWebElement TxtGroupName => WebDriverManager.Driver.FindElementAfterWait(By.XPath(groupNameFieldXPath));
        private IWebElement TxtGroupHeader => WebDriverManager.Driver.FindElementAfterWait(By.XPath(groupHeaderFieldXPath));
        private IWebElement TxtGroupFooter => WebDriverManager.Driver.FindElementAfterWait(By.XPath(groupFooterFieldXPath));
        private IWebElement BtnSubmitGroupCreation => WebDriverManager.Driver.FindElementAfterWait(By.XPath(submitGroupCreationButtonXPath));

        public CreateNewGroupPage SetGroupName(string groupName)
        {
            TxtGroupName.EnterText(groupName, groupNameFieldName);            
            return this;
        }

        public CreateNewGroupPage SetGroupHeader(string groupHeader)
        {
            TxtGroupHeader.EnterText(groupHeader, groupHeaderFieldName);            
            return this;
        }

        public CreateNewGroupPage SetGroupFooter(string groupFooter)
        {
            TxtGroupFooter.EnterText(groupFooter, groupFooterFieldName);
            return this;
        }

        public void ClickSubmitGroupCreationButton()
        {
            BtnSubmitGroupCreation.ClickElement(submitGroupButtonName);            
        }
    }
}