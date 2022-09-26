using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NopCommerce.Pages
{
    class CategoriesPage
    {
        IWebElement ListChoice;
        IWebElement categoryLocator;
      
        public void selectCategory(string category)
        {
            Thread.Sleep(300);
            Actions action = new Actions(DriverContent.Driver);
           
            if (category == "Computers")
            {
                categoryLocator = DriverContent.Driver.FindElements(By.XPath("//ul[@class='top-menu notmobile']/li")).ToList()[0];               
                action.MoveToElement(categoryLocator).Perform();
                DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='header-menu']/ul[@class='top-menu notmobile']/li/ul)[1]")));
               
            }
            else if (category == "Electronics")
            {
                categoryLocator = DriverContent.Driver.FindElements(By.XPath("//ul[@class='top-menu notmobile']/li")).ToList()[1];
                // DriverContent.Driver.FindElement(By.XPath("//ul[@class='top-menu notmobile']/li/a[contains(text()," + category + ")]"));
                //(//ul[@class='top-menu notmobile']/li/a)[1]//this is another way
                action.MoveToElement(categoryLocator).Perform();
                DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='header-menu']/ul[@class='top-menu notmobile']/li/ul)[2]")));
            }
            else if (category == "Digital downloads")
            {
                categoryLocator = DriverContent.Driver.FindElements(By.XPath("//ul[@class='top-menu notmobile']/li")).ToList()[3];
                categoryLocator.Click();
            }
        }
        public void selectListChoice(string choice)//string category,
        {
            switch (choice)
            {
                case "Desktops":
                  //ListChoice = DriverContent.Driver.FindElement(By.XPath("(//ul[@class='top-menu notmobile']/li/a[contains(text()," + category + ")]/following-sibling::ul/li)[1]"));//8iry el xpath
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[1]/li")).ToList()[0];
                    break;
                case "Notebooks":
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[1]/li")).ToList()[1];
                    break;
                case "Software":
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[1]/li")).ToList()[2];
                    break;
                case "Camera":
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[2]/li")).ToList()[0];
                    break;
                case "Cell phones":
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[2]/li")).ToList()[1];
                    break;
                case "others":
                    ListChoice = categoryLocator.FindElements(By.XPath("(//ul[@class='sublist first-level'])[2]/li")).ToList()[2];
                    break;
            }
           // DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.));
            ListChoice.Click();
        }

        public void AssertNavigation(string product)
        {
            DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//strong[@class='current-item']")));
            IWebElement pathToProduct= DriverContent.Driver.FindElement(By.XPath("//strong[@class='current-item']"));
            Assert.AreEqual(product,pathToProduct.Text);
        }
        //This is another way for assertion
        /* public void AssertNavigation(string title)
         {
             string ActualUrl = DriverContent.Driver.Url;
             string Url = "https://demo.nopcommerce.com/x";
             string ExpectedUrl = Url.Replace("x", title); ;
             Assert.AreEqual(ExpectedUrl, ActualUrl);
         }*/

        public void selectCategoryProduct(string CatProd)
        {         
            char[] spearator = { '>' };
            // using the method
            String[] strlist = CatProd.Split(spearator).Select(x=>x.Trim()).ToArray();
            string categoryName = strlist[0];
            string productName = strlist[1];
            IWebElement categoryLocator = DriverContent.Driver.FindElement(By.XPath($"//ul[@class='top-menu notmobile']/li/a[contains(text(),'{categoryName}')]"));
            if (strlist.Length == 2)
            {
                Thread.Sleep(300);
                Actions action = new Actions(DriverContent.Driver);
                action.MoveToElement(categoryLocator).Perform();
                DriverContent.driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//ul[@class='top-menu notmobile']/li/a[contains(text(),'{categoryName}')]//following-sibling::ul")));
                IWebElement productLocate = DriverContent.Driver.FindElement(By.XPath($"//ul[@class='top-menu notmobile']/li/a[contains(text(),'{categoryName}')]//following-sibling::ul/li/a[contains(text(),'{productName}')]"));/////////3aiza a5leha dynamic bs msh 3arfa ageblha xpath//5las 3rft ^_^
                productLocate.Click();
                //ul[@class='top-menu notmobile']/li/a[contains(text(),'{categoryName}')]//following-sibling::ul/li
            }
            else if ( strlist.Length == 1 )
            {
                categoryLocator.Click();
            }
        }
    }
}
