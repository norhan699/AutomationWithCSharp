using EAEmployeeTest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.HelperActions
{
    public class MouseActions
    {
        public void contextClick()
        {

        }
        public static void click(By locator)
        {
            DriverContent.Driver.FindElement(locator).Click();
        }
    }
}
