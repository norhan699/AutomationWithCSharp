using EAEmployeeTest.Base;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NopCommerce.Pages
{
    class BuildYourOwnCompPage
    {
        IWebElement ProcessorDropDwn => DriverContent.Driver.FindElement(By.XPath("//select[@id='product_attribute_1']"));
        IWebElement ProcessorValu ;
        IWebElement RamDropDown => DriverContent.Driver.FindElement(By.XPath("//select[@id='product_attribute_2']"));
        IWebElement RamValu;
        IWebElement price => DriverContent.Driver.FindElement(By.XPath("//span[@id='price-value-1']"));

        public void clickOnProcessorDropDwn()
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//select[@id='product_attribute_1']")));
            Thread.Sleep(200);
            ProcessorDropDwn.Click();
            Thread.Sleep(1000);
        }
        public void setDropDownValue(Double valu)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//select[@id='product_attribute_1']/option[@value=" + valu + "]")));
            Thread.Sleep(200);
            ProcessorValu = DriverContent.Driver.FindElement(By.XPath("//select[@id='product_attribute_1']/option[@value=" + valu + "]"));
            //ProcessorValu = DriverContent.Driver.FindElement(By.XPath("//select[@id='product_attribute_1']String.Format('/option[contains(text(), {0})]', valu)"));

            ProcessorValu.Click();
        }
        public void clickOnRamDropDown()
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//select[@id='product_attribute_2']")));
           // Thread.Sleep(200);
            RamDropDown.Click();

        }
        public void setRamDropDownValue(Double valu)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//select[@id='product_attribute_2']/option[@value=" + valu + "]")));
            Thread.Sleep(200);
            RamValu = DriverContent.Driver.FindElement(By.XPath("//select[@id='product_attribute_2']/option[@value=" + valu + "]"));
            RamValu.Click();
            Thread.Sleep(1000);
        }
        public void selectHDD(int valu)
        {
            Thread.Sleep(200);
            IWebElement HDD = DriverContent.Driver.FindElement(By.XPath("//input[@value=" + valu + "]"));
            HDD.Click();
        }
        public void selectOS(int valu)
        {
            Thread.Sleep(200);
            IWebElement OS = DriverContent.Driver.FindElement(By.XPath("//input[@value=" + valu + "]"));
            OS.Click();
            Thread.Sleep(1000);
        }
        public void selectSW(int valu)
        {
          //  String price = DriverContent.Driver.FindElement(By.XPath("//input[@value='11']")).Text;
            IWebElement SW = DriverContent.Driver.FindElement(By.XPath("//input[@value=" + valu + "]"));
            SW.Click();
            // DriverContent.driverWait.Until(ExpectedConditions.ElementToBeSelected(By.XPath("//input[@value='11']")));
            // DriverContent.driverWait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.XPath("//span[@id='price-value-1']"), "$1,345.00"));
            //DriverContent.driverWait.Until(ExpectedConditions.Equals(price, "$1,345.00"));
            Thread.Sleep(5000);
        }
        public String getPrice()
        {
            return price.Text;
        }

    }
}
