using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace AddressBook_v4
{
    public class GroupsPage
    {
        private const string topNewGroupButtonXPath = "//*[@id='content']/form/input[1]";
        private const string bottomNewGroupButtonXPath = "//*[@id='content']/form/input[4]";
        private const string topDeleteGroupButtonXPath = "//*[@id='content']/form/input[2]";
        private const string bottomDeleteGroupButtonXPath = "//*[@id='content']/form/input[5]";
        private const string topEditGroupButtonXPath = "//*[@id='content']/form/input[3]";
        private const string bottomEditGroupButtonXPath = "//*[@id='content']/form/input[6]";
        private const string selectGroupCheckBoxCssSelector = "span.group";
        private const string firstGroupCBName = "selected[]";

        private IWebElement BtnNewGroupTop => WebDriverManager.Driver.FindElementAfterWait(By.XPath(topNewGroupButtonXPath));
        private IWebElement BtnNewGroupBottom => WebDriverManager.Driver.FindElementAfterWait(By.XPath(bottomNewGroupButtonXPath));
        private IWebElement BtnDeleteGroupTop => WebDriverManager.Driver.FindElementAfterWait(By.XPath(topDeleteGroupButtonXPath));
        private IWebElement BtnDeleteGroupBottom => WebDriverManager.Driver.FindElementAfterWait(By.XPath(bottomDeleteGroupButtonXPath));
        private IWebElement BtnEditGroupTop => WebDriverManager.Driver.FindElementAfterWait(By.XPath(topEditGroupButtonXPath));
        private IWebElement BtnEditGroupBottom => WebDriverManager.Driver.FindElementAfterWait(By.XPath(bottomEditGroupButtonXPath));
        private IWebElement CBFirstGroup => WebDriverManager.Driver.FindElementAfterWait(By.Name(firstGroupCBName));
        private ReadOnlyCollection<IWebElement> GroupsList => WebDriverManager.Driver.FindElements(By.CssSelector(selectGroupCheckBoxCssSelector));


        public void ClickTopNewGroupButton()
        {
            BtnNewGroupTop.ClickElement("New Group button");            
        }

        public void ClickTopDeleteGroupButton()
        {
            BtnDeleteGroupTop.ClickElement("Delete Group button");            
        }

        public void ClickTopEditGroupButton()
        {
            BtnEditGroupTop.Click();            
        }

        public int CountGroups()
        {
            int groupsAmount = WebDriverManager.Driver.FindElements(By.CssSelector(selectGroupCheckBoxCssSelector)).Count;
            Console.WriteLine($"Groups amount is: {groupsAmount}");
            return groupsAmount;            
        }

        public int CountGroups2()
        {
            int groupsAmount = GroupsList.Count;
            Console.WriteLine($"Groups amount is: {groupsAmount}");
            return groupsAmount;
        }

        public GroupsPage SelectFirstGroup()
        {
            CBFirstGroup.Click();            
            return this;
        }
    }
}