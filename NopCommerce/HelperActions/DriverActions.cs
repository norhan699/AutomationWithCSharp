using EAEmployeeTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.HelperActions
{
    public class DriverActions
    {       
        public IWebElement FindElementBy(By locator)
        {            
            return DriverContent.Driver.FindElement(locator);
        } 

    }
}
