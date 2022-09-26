
using EAEmployeeTest.Base;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
   public class Hooks
    {
       // private readonly BoDi.IObjectContainer _objectContainer;
        private RemoteWebDriver _driver;

        /*public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }*/
        [BeforeScenario]
        public void setUpDriver()
        {
            DriverContent.Driver = new ChromeDriver();

        }
        [AfterScenario]
        public void tearDownDriver()
        {
            DriverContent.Driver.Quit();
            /*var s = new List<string>()
            {
                "3333",
                "333",
                "12"
            };


            var s3 =
            s.Where(ss => ss.Contains("3"));

            */

        }     
    }
}
