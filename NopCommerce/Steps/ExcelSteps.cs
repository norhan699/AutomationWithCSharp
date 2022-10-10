using ExcelDataReader;
using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EAEmployeeTest.Helpers;

namespace NopCommerce.Steps
{
    [Binding]
    public class ExcelSteps
    {
        ExcelPage excelPage;
        DataReading data;
        ShoppingCartPage cart;
        DataTable table;

        public ExcelSteps()
        {
            excelPage = new ExcelPage();
            data = new DataReading();
            cart = new ShoppingCartPage();
            table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
        }
        [When(@"I added (.*) products in the cart")]
        public void WhenIAddedProductsInTheCart(int p0)
        {
            //FileStream stream = new FileStream(@"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx", FileMode.Open, FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataTable table = reader.AsDataSet().Tables["Sheet1"];
         //  DataTable table= data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
            for (int i = 1; i < table.Rows.Count; i++)//or till p0
            {
                var col = table.Rows[i];
                string productName = col.ItemArray[0].ToString();
                int quantity =Convert.ToInt32(col.ItemArray[1]);
                excelPage.addToCart(productName, quantity);

            }
        }
        [Then(@"I assert the image of the product in both pages using Excel sheet")]
        public void ThenIAssertTheImageOfTheProductInBothPagesUsingExcelSheet()
        {
          //  DataTable table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
            for(int i = 1; i < table.Rows.Count; i++)
            {
                var col = table.Rows[i];
                string val1 = col.ItemArray[2].ToString();
                string val2 = col.ItemArray[3].ToString();
                excelPage.assertProductImage(val1,val2);
              //  cart.assertProductImage(val1, val2);//or this ,it is the same                     
            }
        }

        [Then(@"I assert the name of the product using Excel sheet")]
        public void ThenIAssertTheNameOfTheProductUsingExcelSheet()
        {
           // DataTable table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
           for(int i=1; i < table.Rows.Count; i++)
            {
                var col = table.Rows[i];
                string name = col.ItemArray[0].ToString();
                cart.assertProductName(name);
            }
        }

        [Then(@"I assert the price of the product according to quantity using Excel sheet")]
        public void ThenIAssertThePriceOfTheProductAccordingToQuantityUsingExcelSheet()
        {
           // DataTable table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
            for (int i = 1; i < table.Rows.Count; i++)
            {
                var col = table.Rows[i];
                string price =col.ItemArray[4].ToString();
                string quantity = col.ItemArray[1].ToString();
                string productName = col.ItemArray[0].ToString();
                cart.assertProductPrice(productName,price,quantity);
            }
        }

        [Then(@"I assert the total price using Excel sheet")]
        public void ThenIAssertTheTotalPriceUsingExcelSheet()
        {
           // DataTable table = data.readData("Sheet1", @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx");
            string totalPrice= table.Rows[1][5].ToString();
            cart.assertTotalPrice(totalPrice);
        }


    }
}
