    using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace cells_cloud_charp
{    
    public class CellsPageSetupApiTests
    {
        private CellsPageSetupApi instance= new CellsPageSetupApi(new Config().GetConfiguration());

        public void CellsPageSetupDeleteHeaderFooterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupDeleteHeaderFooter(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageSetupGetFooterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupGetFooter(name, sheetName, folder);
            Console.WriteLine(response);
        }

        public void CellsPageSetupGetHeaderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupGetHeader(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageSetupGetPageSetupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupGetPageSetup(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageSetupPostFooterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? section = 0;
            string script = "test";
            bool? isFirstPage = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupPostFooter(name, sheetName, section, script, isFirstPage, folder);
            Console.WriteLine(response);
        }

        public void CellsPageSetupPostHeaderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? section = 1;
            string script = "trst";
            bool? isFirstPage = false;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupPostHeader(name, sheetName, section, script, isFirstPage, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageSetupPostPageSetupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            PageSetup pageSetup = new PageSetup();
            pageSetup.BlackAndWhite = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageSetupPostPageSetup(name, sheetName, pageSetup, folder);
            Console.WriteLine(response);
        }
        
    }
}