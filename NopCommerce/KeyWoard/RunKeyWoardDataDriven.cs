using Microsoft.VisualStudio.TestTools.UnitTesting;
using NopCommerce.Pages;
//using NopCommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.KeyWoard
{
    [TestClass]
    public class RunKeyWoardDataDriven
    {
        [TestMethod]
        public void RunScript()
        {
            KeywoardDataDrivenPage Kpage = new KeywoardDataDrivenPage();
            Kpage.ExecuteScript();
        }

    }
}
