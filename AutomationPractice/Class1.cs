using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EAEmployeeTest.Base;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;
//using NopCommerce.HelperActons;
namespace KendoUI //AutomationPractice
{
   [TestClass]
    public class Class1
    {  
        //[BeforeTestRun]
        [TestInitialize]
        public void setup()
        {
           DriverContent.Driver = new ChromeDriver();
            Browser browser = new Browser(DriverContent.Driver);
            DriverContent.Browser = new Browser(DriverContent.Driver);
           // DriverContent.Driver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            browser.GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            DriverContent.Driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void RightClick()
        {
            Actions actions = new Actions(DriverContent.Driver);
            IWebElement smallCircle = DriverContent.Driver.FindElement(By.Id("draggable"));
            /* actions = actions.ContextClick(smallCircle);
            IAction iaction = actions.Build();
            iaction.Perform();  this is equal to the following*/
            actions.ContextClick(smallCircle).Build().Perform();
            //contextClick is right click of the mouse

        }
        [TestMethod]
        public void DragDrop()
        {
            IWebElement smallCircle = DriverContent.Driver.FindElement(By.Id("draggable"));
            IWebElement bigCircle = DriverContent.Driver.FindElement(By.Id("droptarget"));
            Thread.Sleep(600);
            DriverContent.Driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            Thread.Sleep(600);
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();",DriverContent.Driver.FindElement(By.ClassName("kd-example-console")));
            Thread.Sleep(600);
            Actions actions = new Actions(DriverContent.Driver);
            actions.DragAndDrop(smallCircle,bigCircle).Build().Perform();
        }

    }
}
