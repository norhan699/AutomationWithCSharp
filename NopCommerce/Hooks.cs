using EAEmployeeTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
//using org.openqa.selenium.remote.DesiredCapabilities;
namespace NopCommerce
{
    [Binding]
    class Hooks
    {
        [BeforeScenario]
        public void SetUpDriver()
        {

            /* var options = new ChromeOptions();
             options.AddArgument(@"--incognito");          
             DriverContent.Driver = new ChromeDriver(options);*/
            DriverContent.Driver = new ChromeDriver();
            DriverContent.Driver.Manage().Window.Maximize();
            /*IJavaScriptExecutor javascript = (IJavaScriptExecutor)DriverContent.Driver;
            javascript.ExecuteScript("alert('Test Case Execution Is started Now..');");*/
        }
        [AfterScenario]
        public void TearDownDriver()
        {
        //    DriverContent.Driver.Quit();
        }
    }
}
//var caps = DesiredCapabilities.Chrome();
// caps.SetCapability(ChromeOptions.Capability, options);