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

    public class CellsAutoFilterApExamples
    {
        private CellsAutoFilterApi instance=new CellsAutoFilterApi(new Config().GetConfiguration());


        public void CellsAutoFilterDeleteWorksheetDateFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? fieldIndex = 1;
            string dateTimeGroupingType = "Day";
            int? year = 2010;
            int? month = 10;
            int? day = 1;
            int? hour = 1;
            int? minute = 1;
            int? second = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterDeleteWorksheetDateFilter(name, sheetName, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterDeleteWorksheetFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? fieldIndex = 1;
            string criteria = "test";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterDeleteWorksheetFilter(name, sheetName, fieldIndex, criteria, folder);
            Console.WriteLine(response);
        }
        
        public void CellsAutoFilterGetWorksheetAutoFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterGetWorksheetAutoFilter(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPostWorksheetAutoFilterRefreshExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPostWorksheetAutoFilterRefresh(name, sheetName, folder);
            Console.WriteLine(response);
        }

        public void CellsAutoFilterPostWorksheetMatchBlanksExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? fieldIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPostWorksheetMatchBlanks(name, sheetName, fieldIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPostWorksheetMatchNonBlanksExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? fieldIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPostWorksheetMatchNonBlanks(name, sheetName, fieldIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetColorFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            ColorFilterRequest colorFilter = new ColorFilterRequest();
            Color color = new Color();//0, 255, 245, 2
            color.R = 255;
            color.G = 245;

            colorFilter.ForegroundColor = new CellsColor();
            colorFilter.ForegroundColor.Color = color;
            colorFilter.Pattern = "Solid";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetColorFilter(name, sheetName, range, fieldIndex, colorFilter, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetCustomFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            string operatorType1 = "LessOrEqual";
            string criteria1 = "test";
            bool? isAnd = false;
            string operatorType2 = "LessOrEqual";
            string criteria2 = "test";
            bool? matchBlanks = true;
            bool? refresh = false;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetCustomFilter(name, sheetName, range, fieldIndex, operatorType1, criteria1, isAnd, operatorType2, criteria2, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetDateFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            string dateTimeGroupingType = "Day";
            int? year = 2019;
            int? month = 1;
            int? day = 1;
            int? hour = 1;
            int? minute = 1;
            int? second = 1;
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = null;
            new Config().UpdateDataFile(null , "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetDateFilter(name, sheetName, range, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetDynamicFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            string dynamicFilterType = "May";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetDynamicFilter(name, sheetName, range, fieldIndex, dynamicFilterType, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }

        public void CellsAutoFilterPutWorksheetFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            string criteria = "test";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetFilter(name, sheetName, range, fieldIndex, criteria, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetFilterTop10Example()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            bool? isTop = true;
            bool? isPercent = true;
            int? itemCount = 1;
            bool? matchBlanks = null;
            bool? refresh = null;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetFilterTop10(name, sheetName, range, fieldIndex, isTop, isPercent, itemCount, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        

        public void CellsAutoFilterPutWorksheetIconFilterExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            int? fieldIndex = 0;
            string iconSetType = "None";
            int? iconId = 0;
            bool? matchBlanks = null;
            bool? refresh = null;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsAutoFilterPutWorksheetIconFilter(name, sheetName, range, fieldIndex, iconSetType, iconId, matchBlanks, refresh, folder);
            Console.WriteLine(response);
        }
        
    }
}