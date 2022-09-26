using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EAEmployeeTest.Base;
using OpenQA.Selenium;
using NopCommerce.Pages;

namespace NopCommerce.Steps
{
    [Binding]
    class SharedSteps
    {
        HomePage home;
        private string url = "https://demo.nopcommerce.com/";
        [Given(@"I had navigated to home page")]
        public void GivenIHadNavigatedToHomePage()
        {
            DriverContent.Driver.Navigate().GoToUrl(url);
        }
        [When(@"I scroll down to Featured products")]
        public void WhenIScrollDownToFeaturedProducts()
        {
            home = new HomePage();
            //scroll till specific element
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", HomePage.FeaturedProductSection);

        }
    }
}
