using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace AutomationPractice.Methods
{
    [TestClass]
    public class AutoSuggest
    {
        [TestInitialize]
        public void setup()
        {
            DriverContent.Driver = new ChromeDriver();
            Browser browser = new Browser(DriverContent.Driver);
            DriverContent.Browser = new Browser(DriverContent.Driver);
            // DriverContent.Driver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            browser.GoToUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            DriverContent.Driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void HandleAutoSuggestList()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", DriverContent.Driver.FindElement(By.ClassName("kd-spacer")));
            Thread.Sleep(600);
            IWebElement searchBox= DriverContent.Driver.FindElement(By.Id("countries"));
            searchBox.SendKeys("a");
            Thread.Sleep(400);
            //DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("k-popup k-group k-reset")));
            IList<IWebElement> list = DriverContent.Driver.FindElements(By.XPath("//ul[@id='countries_listbox']/li/span"));
            foreach(var country in list)
            {
                if (country.Text.Equals("Albania"))
                {
                    country.Click();
                }
            }
            






        }
    }
}
