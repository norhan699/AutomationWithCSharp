using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    class FeaturedProducts
    {
        HomePage home;
        [Then(@"I choose Product name I Assert its price")]
        public void ThenIChooseProductNameIAssertItsPrice(Table table)
        {
            home = new HomePage();
           
            foreach (TableRow row in  table.Rows)
            {
                var ProductName = row[0];
                var Price = row[1];
                home.assertPrices(ProductName, Price);
                
            }
        }

    }
}
