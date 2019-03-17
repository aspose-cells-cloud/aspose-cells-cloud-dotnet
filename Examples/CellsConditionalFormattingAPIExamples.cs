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
    public class CellsConditionalFormattingsApiExamples
    {
        CellsConditionalFormattingsApi instance = new CellsConditionalFormattingsApi(new Config().GetConfiguration());


        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormatting(name, sheetName, index, folder);
            Console.WriteLine(response);
        }

        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingAreaTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 6;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingsTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattings(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsGetWorksheetConditionalFormattingTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsGetWorksheetConditionalFormatting(name, sheetName, index, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsGetWorksheetConditionalFormattingsTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsGetWorksheetConditionalFormattings(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsPutWorksheetConditionalFormattingTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellArea = "a1:a10";
            FormatCondition formatcondition = new FormatCondition();//null,null, "CellValue",null,null,null,null,"v1","v2",null, "Between"
            formatcondition.Type = "CellValue";
            formatcondition._Operator = "Between";
            formatcondition.Formula1 = "v1";
            formatcondition.Formula2 = "v2";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetConditionalFormatting(name, sheetName, cellArea, formatcondition, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsPutWorksheetFormatConditionTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string cellArea = "a1:a10";
            string type = "CellValue";
            string operatorType = "Between";
            string formula1 = "v1";
            string formula2 = "v2";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatCondition(name, sheetName, index, cellArea, type, operatorType, formula1, formula2, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsPutWorksheetFormatConditionAreaTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string cellArea = "a1:a10";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatConditionArea(name, sheetName, index, cellArea, folder);
            Console.WriteLine(response);
        }


        public void CellsConditionalFormattingsPutWorksheetFormatConditionConditionTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET1";
            int? index = 0;
            string type = "CellValue";
            string operatorType = "Between";
            string formula1 = "v1";
            string formula2 = "v2";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatConditionCondition(name, sheetName, index, type, operatorType, formula1, formula2, folder);
            Console.WriteLine(response);
        }

    }
}