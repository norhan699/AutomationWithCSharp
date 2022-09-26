using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAEmployeeTest.Base;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NopCommerce.Pages
{

    public class ShoppingCartPage
    {
        char[] separator = { '$' };
        public void addToCart(string productName, int quantity)
        {
            IWebElement addToCartBtn = DriverContent.Driver.FindElement
                (By.XPath($"//a[contains(text(),'{productName}')]//parent::h2//following-sibling::div/div/button[contains(text(),'cart')]"));
            for( int i = 0; i < quantity; i++)
            {
                addToCartBtn.Click();
            //mmkn n wait for spinner to disappear between each click
                //   DriverContent.driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[contains(text(),'{productName}')]//parent::h2//following-sibling::div/div/button[contains(text(),'cart')]")));
                Thread.Sleep(700);
            }
        }
        public void stopForAWhile()
        {
            //wait for spinner to disappear
            DriverContent.driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div.ajax-loading-block-window")));
            //wait for green bar notification to disappear
            DriverContent.driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("bar-notification")));
        }
        public void assertProductImage(string val1 , string val2)
        {
            //positionat
            int index1 = val1.IndexOf('_',8);
            //int index2 = val2.IndexOf('_');
            string val1Img = val1.Remove(index1);
            string val2Img = val2.Remove(index1);
            Assert.AreEqual(val1Img, val2Img);
        }
        public void assertProductName(string productName)
        {
            IWebElement nameLocator = DriverContent.Driver.FindElement(By.XPath($"//td/a[contains(text(),'{productName}')]"));
            Assert.AreEqual(productName, nameLocator.Text);
        }
        public void assertProductPrice(string name,string quantity, string price)
        {
          IWebElement priceLocator = DriverContent.Driver.FindElement
          (By.XPath($"//a[contains(text(),'{name}')]//parent::td//following-sibling::td[@class='subtotal']/span"));
          
            Double priceNumber = Convert.ToDouble((priceLocator.Text).Split(separator).ToArray()[1]);
            Double subTotalPrice = Convert.ToInt32(quantity) * Convert.ToDouble(price);
            Assert.AreEqual(subTotalPrice, priceNumber);
        }
        public void assertTotalPrice(string orderPrice)
        {
            IWebElement priceLocator = DriverContent.Driver.FindElement
           (By.XPath(" //span[@class='value-summary']/strong"));
            string priceValue = priceLocator.Text.Split(separator).ToArray()[1];
             Assert.AreEqual(Convert.ToDouble(orderPrice), Convert.ToDouble(priceValue));
        }
    }
}
