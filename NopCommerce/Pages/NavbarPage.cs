using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAEmployeeTest.Base;
using OpenQA.Selenium.Interactions;
using System.Threading;
using SeleniumExtras.WaitHelpers;

namespace NopCommerce.Pages
{
    public class NavbarPage
    {
        //IWebElement ShoppingCart = DriverContent.Driver.FindElement(By.Id("topcartlink"));
        IWebElement ShoppingCartt = DriverContent.Driver.FindElement(By.XPath("//span[@class='cart-label']"));
       // IWebElement closingGreenBar = DriverContent.Driver.FindElement(By.CssSelector("span.close"));
      //  public IWebElement closingGreenBar = DriverContent.Driver.FindElement(By.XPath("//span[@class='close']"));
      

         public void viewShoppingCart()
         {
            IWebElement GotoCartBtn = DriverContent.Driver.FindElement(By.XPath("//button[contains(text(),'Go to cart')]"));
            GotoCartBtn.Click();
            Thread.Sleep(400);
         }
        public void closeGreenBar()
        {
            IWebElement closingGreenBar = DriverContent.Driver.FindElement(By.XPath("//span[@class='close']"));
            Thread.Sleep(3400);
            closingGreenBar.Click();//m7tagen wait 2bl el step de
        }
        public void hoverOverShoppingCart()
        {
            Thread.Sleep(300);
            Actions action = new Actions(DriverContent.Driver);
            action.MoveToElement(ShoppingCartt).Perform();
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='count']")));
        }




    }
}
