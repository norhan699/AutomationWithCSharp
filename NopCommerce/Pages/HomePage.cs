using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NopCommerce.Pages
{
    public class HomePage
    {
        // public static IWebElement FeaturedProductSection => DriverContent.Driver.FindElement(By.CssSelector("div[class='product - grid home - page - product - grid']"));

        //public static IWebElement FeaturedProductSection => DriverContent.Driver.FindElement(By.CssSelector("div.product-grid"));
        //public IWebElement GiftCardImg => DriverContent.Driver.FindElement(By.XPath("//div[@data-productid='43']//img"));
        //IWebElement YourOwnCompBtn => DriverContent.Driver.FindElement(By.XPath("//span[contains(text(),'$1,200.00')]/ancestor::div[@class='add-info']/div[@class='buttons']/button[@class='button-2 product-box-add-to-cart-button']"));
        public static IWebElement FeaturedProductSection;
        public IWebElement GiftCardImg;
        IWebElement YourOwnCompBtn;

        public HomePage()
        {
         FeaturedProductSection = DriverContent.Driver.FindElement(By.CssSelector("div.product-grid"));
         GiftCardImg = DriverContent.Driver.FindElement(By.XPath("//div[@data-productid='43']//img"));
         YourOwnCompBtn = DriverContent.Driver.FindElement(By.XPath("//span[contains(text(),'$1,200.00')]/ancestor::div[@class='add-info']/div[@class='buttons']/button[@class='button-2 product-box-add-to-cart-button']"));

    }
    public void clickOnGiftCardImg()
        {
            GiftCardImg.Click();
        }
        public void clickOnYourOwnCompBtn()
        {
            YourOwnCompBtn.Click();
        }
        public void assertPrices(string name, string price)
        {
            Assert.AreEqual(price, getPrice(name).Text);
            /* switch (name)
             {
                 case "Build_Your_Computer":
                     Assert.AreEqual(price, getPrice(name).Text);//anhy tre2a el s7 ?////zbteha//getPrice(1).Text
                     break;
                 case "Apple_MacBook_Pro":
                     Assert.AreEqual(price, getPrice(name).Text);//getPrice(2).Text//price
                     break;
                 case "HTC_LolliPop":
                     Assert.AreEqual(price, getPrice(name).Text);//getPrice(3).Text
                     break;
                 case "Gift_V_Card":
                     Assert.AreEqual(price, getPrice(name).Text);//getPrice(4).Text
                     break;
             }*/

        }
        public IWebElement getPrice(string productName)//8ire el locator b esm el product
        {//int valu
            IWebElement prices = DriverContent.Driver.FindElement(By.XPath($"//a[contains(text(),'{productName}')]//parent::h2//following-sibling::div/div[@class='prices']/span"));//hena fe syntax error 
            //a[@href='/build-your-own-computer']//parent::h2//following-sibling::div/div[@class='prices']/span          
          //  (//span[@class='price actual-price'])[ " + valu + "]
            return prices;
        }

    }
}
