using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Excel;

namespace NopCommerce.ExcelReader
{
    [TestClass]
    public class ExelData
    {
        [TestMethod]
        public void ReadExcelData()
        {
          
            //FileStream stream = new FileStream(@"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx",FileMode.Open,FileAccess.Read);
            //IExcelDataReader reader= ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataTable table = reader.AsDataSet().Tables["Sheet1"];
            //for (int i=0;i<table.Rows.Count;i++)
            //{
            //    var col = table.Rows[i];
            //    for(int j = 0; j < col.ItemArray.Length; j++)
            //    {
            //        Console.WriteLine(" Data: {0} ", col.ItemArray[j]);
            //    }
            //    Console.WriteLine();
            //   // Console.WriteLine(" Data: {0} ",table.Rows[0][0]);
            //}    
          string xlpath = @"C:\Users\Norhan.Medhat\source\repos\Framework\NopCommerce\Data\Book1.xlsx";
           Console.WriteLine( ExcelReader.GetCellData(xlpath, "Sheet1", 1, 0));
            Console.WriteLine(ExcelReader.GetCellData(xlpath, "Sheet1", 2, 0));
        }
    }
}
