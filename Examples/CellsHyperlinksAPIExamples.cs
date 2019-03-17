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
    public class CellsHypelinksApiTests
    {
        private CellsHypelinksApi instance = new CellsHypelinksApi(new Config().GetConfiguration());




        public void CellsHypelinksDeleteWorkSheetHyperlinkTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? hyperlinkIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksDeleteWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsHypelinksDeleteWorkSheetHyperlinksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksDeleteWorksheetHyperlinks(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsHypelinksGetWorkSheetHyperlinkTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? hyperlinkIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksGetWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder);
            Console.WriteLine(response);

        }


        public void CellsHypelinksGetWorkSheetHyperlinksTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksGetWorksheetHyperlinks(name, sheetName, folder);
            Console.WriteLine(response);

        }


        public void CellsHypelinksPostWorkSheetHyperlinkTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? hyperlinkIndex = 0;
            Hyperlink hyperlink = new Hyperlink();
            //new Link("http://wwww.aspose.com"),"http://www.aspose.com",new CellArea(2,2,1,1
            hyperlink.Address = "http://www.aspose.com";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksPostWorksheetHyperlink(name, sheetName, hyperlinkIndex, hyperlink, folder);
            Console.WriteLine(response);

        }


        public void CellsHypelinksPutWorkSheetHyperlinkTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstRow = 1;
            int? firstColumn = 1;
            int? totalRows = 2;
            int? totalColumns = 3;
            string address = "http://wwww.aspose.com";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsHypelinksPutWorksheetHyperlink(name, sheetName, firstRow, firstColumn, totalRows, totalColumns, address, folder);
            Console.WriteLine(response);

        }

    }
}