using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NopCommerce.Pages
{
    class ExcelPage
    {
        public void addToCart(string productName, int quantity)
        {
            IWebElement addToCartBtn = DriverContent.Driver.FindElement
                (By.XPath($"//a[contains(text(),'{productName}')]//parent::h2//following-sibling::div/div/button[contains(text(),'cart')]"));
            for (int i = 0; i < quantity; i++)
            {
                addToCartBtn.Click();
                //mmkn n wait for spinner to disappear between each click
                //   DriverContent.driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[contains(text(),'{productName}')]//parent::h2//following-sibling::div/div/button[contains(text(),'cart')]")));
                Thread.Sleep(700);
            }
        }
        public void assertProductImage(string val1, string val2)
        {
            int index1 = val1.IndexOf('_', 8);
            int index2 = val2.IndexOf('_',8);
            string val1Img = val1.Remove(index1);
            string val2Img = val2.Remove(index2);
            Assert.AreEqual(val1Img, val2Img);
        }
        public void assertProductPrice(int price, int quantity)
        {

        }
    }
}
