using EAEmployeeTest.Base;
using EAEmployeeTest.Helpers;
using NopCommerce.HelperActions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NopCommerce.Pages
{
    public class KeywoardDataDrivenPage
    {
        private int KeywoardCol;
        private int LocaterTypeCol;
        private int LocaterValueCol;
        private int ParameterCol;
        DataReading data;
        DataTable table;
        
         

        public KeywoardDataDrivenPage(int KeywoardCol=3, int LocaterTypeCol=4, int LocaterValueCol=5, int ParameterCol=6)
        {
            data = new DataReading();
            table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\KeyWoards.xlsx");
            this.KeywoardCol = KeywoardCol;
            this.LocaterTypeCol = LocaterTypeCol;
            this.LocaterValueCol = LocaterValueCol;
            this.ParameterCol = ParameterCol;
        }
        private By GetElementLocator(string locatorType, string locaterValue)
        {
            switch (locatorType)
            {
                case "id":
                    return By.Id(locaterValue);
                case "xpath":
                    return By.XPath(locaterValue);
                default:
                    return By.XPath(locaterValue);
            }
        }
        private void performAction(string keyword ,string locatorType, string locaterValue,params string[] args)//?????????????
        {
            switch (keyword)
            {
                case "Click":
                  By locator=  GetElementLocator(locatorType, locaterValue);
                    DriverContent.Driver.FindElement(locator).Click();
                   //MouseActions.click(GetElementLocator(locatorType, locaterValue));
                   
                    break;
                case "Select":
                    char[] spearator = { '>' };
                    // using the method
                    String[] strlist = args[0].Split(spearator).Select(x => x.Trim()).ToArray();
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
                    else if (strlist.Length == 1)
                    {
                        categoryLocator.Click();
                    }

                    break;
                case "Navigate":
                    DriverContent.Driver = new ChromeDriver();
                    DriverContent.Driver.Manage().Window.Maximize();
                    DriverContent.Driver.Navigate().GoToUrl(args[0]);//msh 0
                    break;
                default:
                    throw new NoSuchElementException("KeyWoard is not found"+ keyword);                    
            }
        }
        public void ExecuteScript()//string xlpath, string sheetName
        {
            int totalRows = table.Rows.Count;
            for(int i = 1; i < totalRows; i++)
            {
                var col = table.Rows[i];
                string testSteps = col.ItemArray[1].ToString();
                string keyWoard = col.ItemArray[2].ToString();
                string locaterType = col.ItemArray[3].ToString();
                string locaterValue = col.ItemArray[4].ToString();
                string parameter = col.ItemArray[5].ToString();

                performAction(keyWoard, locaterType, locaterValue, parameter);
                //This is also right
               // performAction(keyWoard, locaterType, locaterValue, parameter, "xyz","aa");//any no. of parameres will be accepted

            }
        }
    }
}
