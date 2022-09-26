using EAEmployeeTest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    class MultipleWindowSteps
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
        string test_url_2 = "https://demo.nopcommerce.com/";
        [When(@"The other window opens")]
        public void WhenTheOtherWindowOpens()
        {
            //List<string> window= DriverContent.Driver.WindowHandles.ToList();//ReadOnlyCollection
            //DriverContent.Driver.SwitchTo().Window(window[1]);//error indexOutOfRangeException??????????????????
            //index[0] is the parent,index [1] is the child window
            // DriverContent.Driver.Navigate().GoToUrl("");

            js.ExecuteScript("window.open('" + test_url_2 + "', '_blank', 'toolbar=yes,scrollbars=yes,resizable=yes,width=1600,height=800')");
           // var newWindowHandle = DriverContent.Driver.WindowHandles[1];
            DriverContent.Driver.SwitchTo().Window(DriverContent.Driver.WindowHandles[1]);
        }

    }
}
