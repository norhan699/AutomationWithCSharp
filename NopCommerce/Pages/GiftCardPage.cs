using EAEmployeeTest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.Pages
{
    public class GiftCardPage
    {
         IWebElement ReceipientNameField => DriverContent.Driver.FindElement(By.CssSelector("input.recipient-name"));
         IWebElement ReceipientEmailField => DriverContent.Driver.FindElement(By.Id("giftcard_43_RecipientEmail"));
         IWebElement NameField => DriverContent.Driver.FindElement(By.Name("giftcard_43.SenderName"));
         IWebElement EmailField => DriverContent.Driver.FindElement(By.Id("giftcard_43_SenderEmail"));
         IWebElement MessageField => DriverContent.Driver.FindElement(By.Id("giftcard_43_Message"));
         IWebElement AddToCartGiftBtn => DriverContent.Driver.FindElement(By.Id("add-to-cart-button-43"));
        public static IWebElement WishListBtn => DriverContent.Driver.FindElement(By.Id("add-to-wishlist-button-43"));       
        //public static IWebElement GreenBar => DriverContent.Driver.FindElement(By.CssSelector("div.bar-notification"));
        public static IWebElement GreenNotificationBar => DriverContent.Driver.FindElement(By.Id("bar-notification"));
       // public IWebElement GiftCardImg =>DriverContent.Driver.FindElement(By.XPath(" //img[@src='']"));
        public static IWebElement GiftCardImg => DriverContent.Driver.FindElement(By.XPath("//div[@class='items']//img"));

        string name = "norhan";
        string email = "nonozxp@gmail.com"; public static IWebElement GiftCardCode => DriverContent.Driver.FindElement(By.XPath("//span[contains(text(),'VG_CR_025')]"));

        public void enterGiftdata()
        {
            ReceipientNameField.SendKeys(name);
            ReceipientEmailField.SendKeys(email);
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
        }
        public void clickOnAddToCartGiftBtn()
        {
            AddToCartGiftBtn.Click();
        }
        public void clickOnGiftCardInShoppingCart()
        {
            GiftCardImg.Click();
        }
    }
}
