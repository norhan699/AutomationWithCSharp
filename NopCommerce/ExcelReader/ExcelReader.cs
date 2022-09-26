using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.ExcelReader
{
    public class ExcelReader
    {
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static IExcelDataReader reader;

        static ExcelReader()
            {
                _cache = new Dictionary<string, IExcelDataReader>();
            }
        public static object GetCellData(string xlPath, string sheetName,int row, int column)//hna n return object a7sn mn string l2n sa3at hn7tag n return numbers msln
        {
            if (_cache.ContainsKey(sheetName))
            {
                reader = _cache[sheetName];
            }
            else
            {
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cache.Add(sheetName, reader);
            }
            DataTable table = reader.AsDataSet().Tables[sheetName];
            return table.Rows[row][column].ToString();
        }
    }
}
