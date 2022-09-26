using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Helpers
{
   public class DataReading
    {
        public DataTable readData(string SheetName, string xlPath)
        {
            FileStream stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataTable table = reader.AsDataSet().Tables[SheetName];
            return table;
        }
    }
}
