using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NopCommerce.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    public sealed class AddItemToShoppingCard
    {
        HomePage home;
        GiftCardPage card;
        NavbarPage navbar;
        IJavaScriptExecutor js;
        public AddItemToShoppingCard()//El constructor hena bitnda m3 enna msh wa5den mno object 3lshan el feature file wl binding homa ele bindho el steps class
        {
            home = new HomePage();
            card = new GiftCardPage();
            js = (IJavaScriptExecutor)DriverContent.Driver;
        }

        [Then(@"Go through Gift cards")]
        public void ThenGoThroughGiftCards()
        {
           // home = new HomePage();
            home.clickOnGiftCardImg();
            
        }

        [When(@"You fill form data")]
        public void WhenYouFillFormData()
        {
            
            card.enterGiftdata();
           
        }

        [When(@"click add button")]
        public void WhenClickAddButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", GiftCardPage.WishListBtn);           
            card.clickOnAddToCartGiftBtn();
            //wait until element is found exist
            WebDriverWait wait = new WebDriverWait(DriverContent.Driver, TimeSpan.FromMinutes(1));
            //wait until spinner disappers not visible
            //wait until green bar appears visible 
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.close")));
        }

        [Then(@"You should assert that the green panel appears")]
        public void ThenYouShouldAssertThatTheGreenPanel()
        {
         Assert.IsTrue(GiftCardPage.GreenNotificationBar.Displayed);

        }

        [When(@"You scroll up")]
        public void WhenYouScrollUp()
        {
            //scroll till the top of the page
           // IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
            js.ExecuteScript("window.scrollTo(0, 0)");//x & y coordinates
        }

        [When(@"hover over the shopping card")]
        public void WhenHoverOverTheShoppingCard()
        {
            navbar = new NavbarPage();
            navbar.closeGreenBar();
            navbar.hoverOverShoppingCart();
        }
     

        [When(@"press Go to card")]
        public void WhenPressGoToCard()
        {
            navbar.viewShoppingCart();
        }

        [Then(@"You should assert that the item to be added successfully")]
        public void ThenYouShouldAssertThatTheItemToBeAddedSuccessfully()
        {                
            Thread.Sleep(300);            
            // DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'VG_CR_025')]")));
            Assert.IsTrue(GiftCardPage.GiftCardCode.Displayed);
        }

    }
}
// DriverContent.Driver.Manage().Timeouts().ImplicitWait(15, TimeUnit.SECONDS); 
//  DriverContent.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(500));
//   WebDriverWait wait = new WebDriverWait(DriverContent.Driver, TimeSpan.FromMinutes(1));
/*GiftCardPage.GreenBar.Displayed;*/
// DriverContent.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);


//Scroll to the end of the page
/*  IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
  js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");*/
/* private string url = "";
    [Given(@"I had navigated to home page")]
    public void GivenIHadNavigatedToHomePage()
    {
        DriverContent.Driver.Navigate().GoToUrl(url);
    }*/

/* [Then(@"I scroll down to Featured products")]
 public void ThenIScrollDownToFeaturedProducts()
 {
     //scroll till specific element
     IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
     js.ExecuteScript("arguments[0].scrollIntoView();", HomePage.FeaturedProductSection);
    //                  x                                y coordinates
 }*/
