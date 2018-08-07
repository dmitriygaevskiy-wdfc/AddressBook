using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_v4
{
    public static class ElementsManager
    {
        public static void ClickElement(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine($"{elementName} is clicked");
        }

        public static void EnterText(this IWebElement element, string value, string elementName)
        {
            element.SendKeys(value);
            Console.WriteLine($"{elementName} is set to {value}");
        }

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
