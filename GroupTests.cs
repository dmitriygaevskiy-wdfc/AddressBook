using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_v4
{    
    public class GroupTests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            WebDriverManager.SetUpDriverInstance(BrowserType.Chrome);
        }

        //[TestCaseSource(typeof(LoginTestData), "TestCases"), Order(1)]
        [TestCaseSource(typeof(GroupTestData), "TestCases"), Order(1)]
        public void AddNewGroup(string groupName, string groupHeader, string groupFooter, int groupsAmount)
        {            
            LoginHelper login = new LoginHelper()
                .DoLogin();

            HomePage loginResult = new HomePage();
            loginResult.ClickGroupsPageMenuLink();

            GroupsPage groupsPage = new GroupsPage();
            int oldGroups = groupsPage
                .CountGroups();

            for (int i = 0; i < groupsAmount; i++)
            {
                groupsPage
                    .ClickTopNewGroupButton();
                CreateNewGroupPage createGroup = new CreateNewGroupPage()
                    .SetGroupName(groupName)
                    .SetGroupHeader(groupHeader)
                    .SetGroupFooter(groupFooter);
                createGroup
                    .ClickSubmitGroupCreationButton();

                ConfirmGroupActionPage confirmGroupCreation = new ConfirmGroupActionPage();
                confirmGroupCreation
                    .ClickReturnToGroupsPageLink();

                groupsPage = new GroupsPage();
            }

            int newGroups = groupsPage
                .CountGroups();

            Assert.True(newGroups == oldGroups + groupsAmount, "Group amounts are not matched");
            Console.WriteLine($"{groupsAmount} groups were added");

            LoginHelper signOut = new LoginHelper()
                .DoLogout();
        }

        [Test, Order(2)]
        public void DeleteGroup()
        {
            LoginHelper login = new LoginHelper()
                .DoLogin();

            HomePage loginResult = new HomePage();
            loginResult.ClickGroupsPageMenuLink();

            GroupsPage groupsPage = new GroupsPage();            
            int oldGroups = groupsPage
                .CountGroups();
            groupsPage
                .SelectFirstGroup();
            groupsPage
                .ClickTopDeleteGroupButton();

            ConfirmGroupActionPage confirmGroupRemove = new ConfirmGroupActionPage();
            confirmGroupRemove
                .ClickReturnToGroupsPageLink();

            groupsPage = new GroupsPage();

            int newGroups = groupsPage
                .CountGroups();

            Assert.True(newGroups == oldGroups - 1, "Group amounts are not matched");
            Console.WriteLine("One group was removed");

            LoginHelper signOut = new LoginHelper()
                .DoLogout();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriverInstance();
        }
    }    
}
