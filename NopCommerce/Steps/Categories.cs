using NopCommerce.BrowserActions;
using NopCommerce.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NopCommerce.Steps
{
    [Binding]
    class Categories
    {
        CategoriesPage category = new CategoriesPage();
        CommonActions commonActions = new CommonActions();

        [When(@"I hover over the (.*) Category")]
        public void WhenIHoverOverTheComputersCategory(string CategoryName)
        {
            category.selectCategory(CategoryName);
        }

        [When(@"I click on (.*) from the selected list")]
        public void WhenIClickOnNotebook(string ChoiceName)//, string CategoryName
        {
            category.selectListChoice(ChoiceName);//CategoryName,
        }

        [When(@"I click on (.*) Category")]
        public void WhenIClickedOnDigitalDownloadsCategory(string categoryName)
        {
          category.selectCategory(categoryName);
        }
        [When(@"I select (.*) from the top menu")]
        public void WhenISelectElectronicsCellPhonesFromTheTopMenu(string CatProd)
        {
            category.selectCategoryProduct(CatProd);//trim()
        }
        [When(@"I go back")]
        public void WhenIGoBack()
        {
            commonActions.goBackward();
            Thread.Sleep(300);
        }

        [When(@"Forward again")]
        public void WhenForwardAgain()
        {
            commonActions.goForward();
            Thread.Sleep(300);
            commonActions.refreshPage();
            Thread.Sleep(300);
        }


        [Then(@"I should be navigated to (.*) page")]
        public void ThenIShouldBeNavigatedToNotebookPage(string pageName)
        {
            switch (pageName)
            {
//Computer products
                case "Desktops":
                    category.AssertNavigation("Desktops");
                   // category.AssertNavigation("desktops");//another mehod of assertion
                    break;
                case "Notebooks":
                    category.AssertNavigation("Notebooks");
                    //category.AssertNavigation("notebooks");
                    break;
                case "Software":
                    category.AssertNavigation("Software");
                    //category.AssertNavigation("software");
                    break;
//Electronics products
                case "Camera":
                    category.AssertNavigation("Camera & photo");
                    // category.AssertNavigation("camera-photo");//another mehod of assertion
                    break;
                case "Cell-phones"://Cell phones
                    category.AssertNavigation("cell-phones");
                    // category.AssertNavigation("Cell phones");
                    break;
                case "Others":
                    category.AssertNavigation("Others");
                    // category.AssertNavigation("others");
                    break;
            }
        }

    }
}
