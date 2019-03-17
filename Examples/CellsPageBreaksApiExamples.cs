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
    public class CellsPageBreaksExamples1w1212
    {
        private CellsPageBreaksApi instance=new CellsPageBreaksApi(new Config().GetConfiguration());



        
        public void CellsPageBreaksDeleteHorizontalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksDeleteHorizontalPageBreak(name, sheetName, index, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageBreaksDeleteHorizontalPageBreaksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? row = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksDeleteHorizontalPageBreaks(name, sheetName, row, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageBreaksDeleteVerticalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksDeleteVerticalPageBreak(name, sheetName, index, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageBreaksDeleteVerticalPageBreaksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? column = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksDeleteVerticalPageBreaks(name, sheetName, column, folder);
            Console.WriteLine(response);
        }

        public void CellsPageBreaksGetHorizontalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksGetHorizontalPageBreak(name, sheetName, index, folder);
            Console.WriteLine(response);
        }

        public void CellsPageBreaksGetHorizontalPageBreaksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksGetHorizontalPageBreaks(name, sheetName, folder);
            Console.WriteLine(response);
        }
        
  
        public void CellsPageBreaksGetVerticalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksGetVerticalPageBreak(name, sheetName, index, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPageBreaksGetVerticalPageBreaksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksGetVerticalPageBreaks(name, sheetName, folder);
            Console.WriteLine(response);
        }

        public void CellsPageBreaksPutHorizontalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellname = "a1";
            int? row = 1;
            int? column = 1;
            int? startColumn = 1;
            int? endColumn = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksPutHorizontalPageBreak(name, sheetName, cellname, row, column, startColumn, endColumn, folder);
            Console.WriteLine(response);
        }
        
    
        public void CellsPageBreaksPutVerticalPageBreakTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellname = "a1";
            int? column = 1;
            int? row = 1;
            int? startRow = 1;
            int? endRow = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPageBreaksPutVerticalPageBreak(name, sheetName, cellname, column, row, startRow, endRow, folder);
            Console.WriteLine(response);
        }
        
    }
}