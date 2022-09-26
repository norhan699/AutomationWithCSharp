using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    public sealed class ShoppingCart
    {
        ShoppingCartPage cart = new ShoppingCartPage();
        NavbarPage navbar = new NavbarPage();
        [When(@"I added to the cart")]
        public void WhenIAddedToTheCart(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                string productName = row[0];
                int quantity = Convert.ToInt32(row[1]);
                cart.addToCart(productName, quantity);
            }
        }

        [When(@"I go to shopping cart page")]
        public void WhenIGoToShoppingCartPage()
        {
            cart.stopForAWhile();
            navbar.hoverOverShoppingCart();
            navbar.viewShoppingCart();
        }

        [Then(@"I assert the image of the product in both pages")]
        public void ThenIAssertTheImageOfTheProductInBothPages(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                cart.assertProductImage(row[1],row[2]);
                //ThenIAssertTheNameOfTheProduct(row[0]);
            }            
        }


        [Then(@"I assert the name of the product")]
        public void ThenIAssertTheNameOfTheProduct(Table table)//string productName
        {
            foreach (TableRow row in table.Rows)
            {
                cart.assertProductName(row[0]);
            }
            
        }

        [Then(@"I assert the price of the product according to quantity")]
        public void ThenIAssertThePriceOfTheProductAccordingToQuantity(Table table)
        {
            foreach(TableRow row in table.Rows )
            cart.assertProductPrice(row[0],row[1], row[2]);
        }
        [Then(@"I assert (.*) to be the total price")]
       // [Then(@"I assert the total price (.*)")]
        public void ThenIAssertTheTotalPrice(string orderPrice)
        {
            cart.assertTotalPrice(orderPrice);
        }

    }
}
