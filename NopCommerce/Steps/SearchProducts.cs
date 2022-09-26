using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    class SearchProducts
    {
        SearchPage search= new SearchPage();
        //string choiceSearchKey = "iCam" ;
        // string SearchKey = "Apple";
        string firstChoice = "MacBook";
        string secondChoice = "iCam";
        string url1 = "apple-macbook-pro-13-inch";
        string url2 = "apple-icam";

        [When(@"I Go to search field")]
        public void WhenIGoToSearchField()
        {
            search.clickOnSearchTextBox();
        }

        [When(@"I Clear the text box")]
        public void WhenIClearTheTextBox()
        {
            search.clearSearchTextBox();
        }

        [When(@"I Enter (.*) as a search key")]
        public void WhenIEnterLenovoAsASearchKey(string searchKey)
        {
            search.enetrSearchKey(searchKey);
        }

        [When(@"Wait for the loader spinner to disappear")]
        public void WhenWaitForTheLoaderSpinnerToDisappear()
        {
            search.spinnerDisappear();
        }


        [Then(@"I assert the suggestion list")]
        public void ThenIAssertTheSuggestionList(Table table)
        {
          
            foreach(TableRow row in table.Rows)
            {
                var productName = row[0];
                search.assertSuggestionList(productName);
            }
            
        }

        [When(@"I Select the (.*) choice in the drop down list")]
        public void WhenISelectTheSecondChoiceInTheDropDownList(string choice)
        {
            switch (choice)
            {
                case "first":
                    search.clickOnSearchResult(firstChoice,0);
                    break;
                case "second":
                    search.clickOnSearchResult(secondChoice,1);
                    break;
            }                        
        }

        [When(@"I choose product (.*)")]
        public void WhenIChooseProduct(string product)
        {
            search.goToProductPage(product);
        }

        [Then(@"I should in (.*) page")]
        public void ThenIShouldInProductPage(string title)
        {
            search.assertGoingToProductPage(title);
        }


        /*[When(@"I Click search button")]
        public void WhenIClickSearchButton()
        {
            
        }*/

        [Then(@"I should be redirected to the (.*) choice page")]
        public void ThenIShouldBeRedirectedToTheRightPage(string choice)
        {
            switch (choice)
            {
                case "first":
                     search.assertNavigarionToTheRightPage(url1);
                      break;
                case "second":
                     search.assertNavigarionToTheRightPage(url2);
                     break;
            }         
        }
    }
}
