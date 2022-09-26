using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrosweType Type { get; set; }
        public void GoToUrl(string url)
        {
            DriverContent.Driver.Url = url;
        }
    }
        public enum BrosweType
        {
            Explorer,
            FireFox,
            Chrome
        }
    
}
