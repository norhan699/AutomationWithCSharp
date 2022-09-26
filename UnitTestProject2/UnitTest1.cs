using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAEmployeeTest.Base;
using OpenQA.Selenium.Chrome;
using UnitTestProject2.Pages;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

/*using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit;*/

using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System.IO;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        
        string url = "http://eaapp.somee.com/";
        //private IWebDriver _driver;
        string username = "Norhan";
        string password = "N@rhan01*";
        string key = "john";
        public static ExtentTest test;
        public static ExtentReports extent;
        public static string reportPath;
        // reportPath = System.IO.Directory.GetParent(@"C:\Users\Norhan.Medhat\source\repos\Framework\UnitTestProject2\Reports\"+ DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");

        static AventStack.ExtentReports.ExtentReports extent2;
        //[TestInitialize]
        [BeforeTestRun]
        public void NavigateToWebsite(BrosweType browser)
        {
             // extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\Norhan.Medhat\source\repos\Framework\UnitTestProject2\Reports" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
           // extent.AttachReporter(htmlreporter);
            extent2 = new AventStack.ExtentReports.ExtentReports();
            extent2.AttachReporter(htmlreporter);
            switch (browser)//tab+tab to autocomplete//on browser hit the down arrow 
            {
                case BrosweType.Explorer:
                    DriverContent.Driver = new InternetExplorerDriver();
                    DriverContent.Browser = new Browser(DriverContent.Driver);
                    break;
                case BrosweType.FireFox:
                    DriverContent.Driver = new FirefoxDriver();
                    DriverContent.Browser = new Browser(DriverContent.Driver);
                    break;
                case BrosweType.Chrome:
                    DriverContent.Driver = new ChromeDriver();
                    DriverContent.Browser = new Browser(DriverContent.Driver);
                    break;
                default:
                    DriverContent.Driver = new ChromeDriver();
                    DriverContent.Browser = new Browser(DriverContent.Driver);
                    break;
            }
            //DriverContent.Driver = new ChromeDriver();
            //DriverContent.Driver.Navigate().GoToUrl(url);
          
        }

        [TestMethod]
        public void checkLogin()
        {
            NavigateToWebsite(BrosweType.Chrome);
            DriverContent.Browser.GoToUrl(url);

            Homepage home = new Homepage();
            LoginPage login = new LoginPage();//_driver
            login.ClickLoginlnk();
            login.login(username,password);
            EmployeeListPage empListPage = home.navigatetoEmpListPage();
            empListPage.search(key);
        }
    }
}
