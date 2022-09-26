using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Base
{
    public class DriverContent
    {
        private static IWebDriver _driver;
        public static WebDriverWait driverWait;
        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value; /////////////////////////////?
                driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            }
        }
        public static Browser Browser//////////////////
        {get;set;}
    }
}
