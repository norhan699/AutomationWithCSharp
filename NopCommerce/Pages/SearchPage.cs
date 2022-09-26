using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace NopCommerce.Pages
{
    class SearchPage
    {
        int counter = 0;
        IWebElement SearchTextBox => DriverContent.Driver.FindElement(By.XPath("//input[@id='small-searchterms']"));
        
        public void clickOnSearchTextBox()
        {
            SearchTextBox.Click();
        }

        public void clearSearchTextBox()
        {
            SearchTextBox.Clear();
        }

        public void enetrSearchKey(string searchKey)//clear before send keys+wait for loader
        {
            SearchTextBox.SendKeys(searchKey);
        }

        public void assertSuggestionList(string productName)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='ui-id-1']")));
            Thread.Sleep(300);
            IList<IWebElement> productLocator = DriverContent.Driver.FindElements(By.XPath("//li[@class='ui-menu-item']/a/span"));//ul[@id='ui-id-1']/li/a/span   //IList<IWebElement>
            Assert.AreEqual(productName, productLocator[counter].Text);//msh mot2kda mnl assertion da
            counter++;

            /*  foreach (IWebElement element in productLocator)
            {
                Console.WriteLine(element.Text);
            }*/
            //  Console.Write(productLocator.Text);



            /*   IWebElement parent = DriverContent.Driver.FindElement(By.Id("ui-id-1"));
               foreach (IWebElement child in parent.FindElements(By.XPath("//ul[@id='ui-id-1']/li")))
               {
                   Assert.AreEqual(productName, child.Text);//el mfrod awl wa7da bs t pass
                   // child.Click();
               }*/


            /*      SelectElement oSelect = new SelectElement(DriverContent.Driver.FindElement(By.Id("ui-id-1")));
                  IList<IWebElement> elementCount = oSelect.Options;
                  int iSize = elementCount.Count;

                  for (int i = 0; i > iSize; i++)
                  {
                      String sValue = elementCount.ElementAt(i).Text;
                      Console.WriteLine(sValue);
                  }*/

        }
        public void clickOnSearchResult(string valu, int valuOrder)//hna grby tshely el mtkrr
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[@class='ui-menu-item']/a/span[contains(text()," + valu + ")]")));

            DriverContent.Driver.FindElements(By.XPath("//li[@class='ui-menu-item']")).ToList()[valuOrder].Click();
           /* IWebElement SearchResult = DriverContent.Driver.FindElement(By.XPath("//li[@class='ui-menu-item']/a/span[contains(text(),"+ valu +")]"));
            SearchResult.Click();*/
        }

        public void goToProductPage(string product)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='ui-id-1']")));
            IWebElement productLocator = DriverContent.Driver.FindElement(By.XPath($"//li[@class='ui-menu-item']/a/span[contains(text(),'{product}')]"));
            productLocator.Click();
        }


        public void assertGoingToProductPage(string title)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1")));
            IWebElement productTitle = DriverContent.Driver.FindElement(By.XPath("//h1"));
            Assert.AreEqual(title, productTitle.Text);
           
        }


        public void assertNavigarionToTheRightPage(string title)
        {
            string ActualUrl = DriverContent.Driver.Url;
            string Url = "https://demo.nopcommerce.com/x";
            string ExpectedUrl= Url.Replace("x", title); ;
            Assert.AreEqual(ExpectedUrl, ActualUrl);
            /* switch (title)
             {
                 case "apple-macbook-pro-13-inch":
              ExpectedUrl = Url.Replace("x", title);
                     break;
                 case "apple-icam":
                     ExpectedUrl = Url.Replace("x", title);
                     break;
             }*/


          //  IWebElement SearchResultTitle = DriverContent.Driver.FindElement(By.XPath(" //title[contains(text(),"+ title +")]"));
           // Assert.IsTrue(SearchPage.));
           
        }
        public void spinnerDisappear()
        {
            DriverContent.driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//input[@class='search-box-text ui-autocomplete-input ui-autocomplete-loading']")));
        }
    }
}
