using EAEmployeeTest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.Pages
{
    public class EmployeeListPage
    {
        
        IWebElement searchKeyField => DriverContent.Driver.FindElement(By.Name("searchTerm"));
        IWebElement btnSerach => DriverContent.Driver.FindElement(By.CssSelector("input.btn"));
       public void search(string key)
        {
            searchKeyField.SendKeys(key);
            btnSerach.Click();
        }

    }
}
