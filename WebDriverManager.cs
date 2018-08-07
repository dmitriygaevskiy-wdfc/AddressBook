using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace AddressBook_v4
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    public class WebDriverManager
    {
        private const string baseUrl = "http://localhost/addressbook/";

        public static void GetToBaseUrl()
        {
            Driver.Navigate().GoToUrl(baseUrl);
            Console.WriteLine("Login page is opened");
        }

        public static IWebDriver Driver { get; set; }        

        public static void SetUpDriverInstance(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case BrowserType.IE:
                    Driver = new InternetExplorerDriver();
                    break;
            }            
        }

        public static void QuitDriverInstance()
        {
            Driver.Quit();
        }
    }
}
