using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAEmployeeTest.Base;

namespace NopCommerce.BrowserActions
{
    public class CommonActions
    {
        
        public void goBackward()
        {
            DriverContent.Driver.Navigate().Back();
        }
        public void goForward()
        {
            DriverContent.Driver.Navigate().Forward();
        }
        public void refreshPage()
        {
            DriverContent.Driver.Navigate().Refresh();
        }
    }
}
