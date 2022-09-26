using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    public sealed class ProductsArrangement
    {
        ArrangementPage arrange = new ArrangementPage();
       /* [When(@"I arrange products according to Price: Low to High")]
        public void WhenIArrangeProductsAccordingToPriceLowToHigh()
        {
            arrange.selectArrangementOption();
        }*/

        [Then(@"I assert the prices")]
        public void ThenIAssertThePrices()
        {
            arrange.assertPrice();
        }

        [When(@"I arrange products according to (.*)")]
        public void WhenIArrangeProductsAccordingToNameAToZ(string arrangementWay)
        {
            arrange.selectArrangementOption(arrangementWay);
        }

        [Then(@"I assert the names alphabatecal order")]
        public void ThenIAssertTheNamesAlphabatecalOrder()
        {
            arrange.assertName();
        }

    }
}
