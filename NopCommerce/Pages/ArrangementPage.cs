using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NopCommerce.Pages
{
    class ArrangementPage
    {
       
        IWebElement arrangeOption;
        public void selectArrangementOption(string arrangementWay)
        {
            arrangeOption = DriverContent.Driver.FindElement(By.XPath($"//option[contains(text(),'{arrangementWay}')]"));
            arrangeOption.Click();
            /*SelectElement oSelect = new SelectElement(DriverContent.Driver.FindElement(By.Id("products-orderby")));
            oSelect.SelectByValue("10");
           */
          
        }

        /*public void assertP()//mtbosesh w fkry mnl awl 5als//e3mly search
        {
            char[] spearator = { '$' };
            string PriceText = price[0].Text;
            // using the method
            string[] pricelist = PriceText.Split(spearator).Select(x => x.Trim()).ToArray();
            string CurrPrice= pricelist[0];
            int currentPrice = Int32.Parse(CurrPrice);
            for(int i = 1; i < price.Count; i++)
            {
                int comparedPrice = Int32.Parse(price[i].Text.Split(spearator).Select(x => x.Trim()).ToArray()[0]);
                Assert.IsTrue(currentPrice < comparedPrice ,
                    "price arrangement from low to high is corrupted");
                currentPrice = Int32.Parse(price[i].Text);
            }
        }*/
        public void assertName()
        {          
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='details']")));//By.ClassName("page-body")
            Thread.Sleep(200);
            List<string> productsNames = DriverContent.Driver.FindElements(By.XPath("//h2[@class='product-title']/a")).Select(x => x.Text).ToList(); 
            string previousName = productsNames.First();//=productsNames[0]

            for (int i = 1; i < productsNames.Count; i++)
            {
                string currentName = productsNames[i];
                // Based on the sort from A->Z or from Z->A
                Assert.IsTrue(currentName.CompareTo(previousName) >= 0);
                //Assert.IsTrue(currentName.CompareTo(previousName) <= 0);
                previousName = currentName;
            }
        }
        public void assertPrice()
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='details']")));//By.ClassName("page-body")
            Thread.Sleep(200);
            IList<string> price = DriverContent.Driver.FindElements(By.XPath("//span[@class='price actual-price']")).Select(x=> x.Text).ToList();
            char[] spearator = { '$' };
            string previousPrice = price[0].Split(spearator).Select(x => x.Trim()).ToArray()[1];
            for (int i = 1; i < price.Count; i++)
            {
                string currentPrice = price[i].Split(spearator).Select(x => x.Trim()).ToArray()[1];
                Assert.IsTrue(Convert.ToDouble(currentPrice).CompareTo(Convert.ToDouble(previousPrice)) >= 0);
                previousPrice = currentPrice;
            }
        }
    }
}
