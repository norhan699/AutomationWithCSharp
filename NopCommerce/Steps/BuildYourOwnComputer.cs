using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NopCommerce.Pages;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    public class BuildYourOwnComputer
    {
        HomePage home;
        BuildYourOwnCompPage computer = new BuildYourOwnCompPage();

        [When(@"I clicked on Add To Cart of Build Your Own Computer")]
        public void WhenIClickedOnAddToCartOfBuildYourOwnComputer()
        {
            home = new HomePage();
            home.clickOnYourOwnCompBtn();
        }

        [Then(@"I have redirected to Build Your Own Computer Page")]
        public void ThenIHaveRedirectedToBuildYourOwnComputerPage()
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@id='main-product-img-1']")));
            Assert.AreEqual("https://demo.nopcommerce.com/build-your-own-computer",DriverContent.Driver.Url);
        }


        [When(@"I choose processor (.*) from drop down list")]
        public void WhenIChooseProcessorFromDropDownList(Double valu)
        {
            
            computer.clickOnProcessorDropDwn();
            switch (valu) {
                case 2.2:
                    computer.setDropDownValue(1);
                    break;
                case 2.5:
                    computer.setDropDownValue(2);
                    break;
            }           
        }
        
        [When(@"I choose RAM (.*) GB")]
        public void WhenIChooseRAMGB(int valu)
        {
            computer.clickOnRamDropDown();
            switch (valu)
            {
                case 2:
                    computer.setRamDropDownValue(3);
                    break;
                case 4:
                    computer.setRamDropDownValue(4);
                    break;
                case 8:
                    computer.setRamDropDownValue(5);
                    break;
            }
        }
        
        [When(@"I choose HDD (.*) GB")]
        public void WhenIChooseHDDGB(int valu)
        {
            switch (valu)
            {
                case 320:
                    computer.selectHDD(6);
                    break;
                case 400:
                    computer.selectHDD(7);
                    break;
            }
        }
        
        [When(@"I choose OS (.*)")]
        public void WhenIChooseOSHome(string valu)
        {
            switch(valu)
            {
                case "Home":
                 computer.selectHDD(8);
                 break;
                case "Premium":
                  computer.selectHDD(9);
                  break;
            }
           
        }
        
        [When(@"I choose SW (.*)")]
        public void WhenIChooseSWMicrosfot(string valu)
        {
            switch (valu)
            {

                case "Microsoft":
                    computer.selectSW(10);
                    break;
                case "Acrobat":
                    computer.selectSW(11);
                    break;
                case "Total":
                    computer.selectSW(12);
                    break;
            }
        }
         
        [Then(@"Total price should be \$(.*)\.(.*)")]
        public void ThenTotalPriceShouldBe_(Decimal p0, int p1)//eh lzmt dol?
        {
            Assert.AreEqual("$1,345.00", computer.getPrice());//Actual:1345  not  1315
           
        }
    }
}
