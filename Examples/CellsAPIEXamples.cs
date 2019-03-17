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

    public class CellsApiExamples
    {

        CellsApi instance = new CellsApi(new Config().GetConfiguration());


        public void CellsDeleteWorksheetColumnExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsDeleteWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Console.WriteLine(response);
            
        }

        public void CellsDeleteWorksheetColumnsForNewConstructorExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsDeleteWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Console.WriteLine(response);
        }

        public void CellsDeleteWorksheetRowExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsDeleteWorksheetRow(name, sheetName, rowIndex, folder);
            Console.WriteLine(response);
        }

        public void CellsDeleteWorksheetRowForNewConstructorExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsDeleteWorksheetRow(name, sheetName, rowIndex, folder);
            Console.WriteLine(response);
        }

        public void CellsDeleteWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startrow = 1;
            int? totalRows = 2;
            bool? updateReference = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsDeleteWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
            Console.WriteLine(response);
        }





        public void CellsGetWorksheetCellStyleExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetCellStyle(name, sheetName, cellName, folder);
            Console.WriteLine(response);

        }


        public void CellsGetWorksheetCellsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? offest = 1;
            int? count = 10;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetCells(name, sheetName, offest, count, folder);
            Console.WriteLine(response);

        }


        public void CellsGetWorksheetColumnExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetColumn(name, sheetName, columnIndex, folder);
            Console.WriteLine(response);

        }


        public void CellsGetWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetColumns(name, sheetName, folder);
            Console.WriteLine(response);

        }


        public void CellsGetWorksheetRowExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetRow(name, sheetName, rowIndex, folder);
            Console.WriteLine(response);

        }


        public void CellsGetWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetWorksheetRows(name, sheetName, folder);
            Console.WriteLine(response);

        }


        public void CellsPostCellCalculateExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            CalculationOptions options = new CalculationOptions();
            options.Recursive = true;
            options.IgnoreError = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostCellCalculate(name, sheetName, cellName, options, folder);
            Console.WriteLine(response);

        }


        public void CellsPostCellCharactersExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET2";
            string cellName = "G8";
            List<FontSetting> options = new List<FontSetting>();
            Font font = new Font();
            font.Size = 10;
            FontSetting fs1 = new FontSetting();
            fs1.Font = font;
            fs1.Length = 2;
            fs1.StartIndex = 0;
            options.Add(fs1);
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostCellCharacters(name, sheetName, cellName, options, folder);
            Console.WriteLine(response);
        }


        public void CellsPostClearContentsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "A1:C10";
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 3;
            int? endColumn = 3;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostClearContents(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
            Console.WriteLine(response);

        }


        public void CellsPostClearFormatsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "A1:C10";
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 3;
            int? endColumn = 10;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostClearFormats(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
            Console.WriteLine(response);


        }


        public void CellsPostColumnStyleExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.IsBold = true;
            style.Font.Size = 16;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostColumnStyle(name, sheetName, columnIndex, style, folder);
            Console.WriteLine(response);


        }


        public void CellsPostCopyCellIntoCellExample()
        {

            string name = "Book1.xlsx";
            string destcell = "C1";
            string sheetName = "SHEET1";
            string worksheet = "SHEET2";
            string cellName = "A1";
            int? row = 1;
            int? column = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostCopyCellIntoCell(name, destcell, sheetName, worksheet, cellName, row, column, folder);
            Console.WriteLine(response);

        }

        public void CellsPostCopyWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? sourceColumnIndex = 1;
            int? destinationColumnIndex = 21;
            int? columnNumber = 1;
            string worksheet = "SHEET2";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostCopyWorksheetColumns(name, sheetName, sourceColumnIndex, destinationColumnIndex, columnNumber, worksheet, folder);
            Console.WriteLine(response);

        }

        public void CellsPostCopyWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? sourceRowIndex = 1;
            int? destinationRowIndex = 1;
            int? rowNumber = 1;
            string worksheet = "SHEET2";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostCopyWorksheetRows(name, sheetName, sourceRowIndex, destinationRowIndex, rowNumber, worksheet, folder);
            Console.WriteLine(response);

        }


        public void CellsPostGroupWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstIndex = 1;
            int? lastIndex = 1;
            bool? hide = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostGroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, hide, folder);
            Console.WriteLine(response);

        }


        public void CellsPostGroupWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstIndex = 1;
            int? lastIndex = 1;
            bool? hide = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostGroupWorksheetRows(name, sheetName, firstIndex, lastIndex, hide, folder);
            Console.WriteLine(response);

        }


        public void CellsPostHideWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startColumn = 1;
            int? totalColumns = 2;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostHideWorksheetColumns(name, sheetName, startColumn, totalColumns, folder);
            Console.WriteLine(response);

        }

        public void CellsPostHideWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startrow = 1;
            int? totalRows = 2;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostHideWorksheetRows(name, sheetName, startrow, totalRows, folder);
            Console.WriteLine(response);

        }


        public void CellsPostRowStyleExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 20;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostRowStyle(name, sheetName, rowIndex, style, folder);
            Console.WriteLine(response);

        }

        public void CellsGetCellHtmlStringExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsGetCellHtmlString(name, sheetName, cellName, folder);
            Console.WriteLine(response);
        }

        public void CellsPostSetCellHtmlStringExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostSetCellHtmlString(name, sheetName, cellName, folder);
            Console.WriteLine(response);

        }


        public void CellsPostSetCellRangeValueExample(string Value, string Type)
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellarea = "A1:C10";
            string value = Value;
            string type = Type;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostSetCellRangeValue(name, sheetName, cellarea, value, type, folder);
            Console.WriteLine(response);

        }


        public void CellsPostSetWorksheetColumnWidthExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            double? width = 10;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostSetWorksheetColumnWidth(name, sheetName, columnIndex, width, folder);
            Console.WriteLine(response);

        }

        public void CellsPostUngroupWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstIndex = 1;
            int? lastIndex = 5;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUngroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, folder);
            Console.WriteLine(response);

        }


        public void CellsPostUngroupWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstIndex = 1;
            int? lastIndex = 5;
            bool? isAll = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUngroupWorksheetRows(name, sheetName, firstIndex, lastIndex, isAll, folder);
            Console.WriteLine(response);

        }


        public void CellsPostUnhideWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startcolumn = 1;
            int? totalColumns = 2;
            double? width = 10;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUnhideWorksheetColumns(name, sheetName, startcolumn, totalColumns, width, folder);
            Console.WriteLine(response);

        }


        public void CellsPostUnhideWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startrow = 1;
            int? totalRows = 8;
            double? height = 18;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUnhideWorksheetRows(name, sheetName, startrow, totalRows, height, folder);
            Console.WriteLine(response);

        }

        public void CellsPostUpdateWorksheetCellStyleExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 19;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUpdateWorksheetCellStyle(name, sheetName, cellName, style, folder);
            Console.WriteLine(response);

        }


        public void CellsPostUpdateWorksheetRangeStyleExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "A1:C10";
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 15;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUpdateWorksheetRangeStyle(name, sheetName, range, style, folder);
            Console.WriteLine(response);

        }


        public void CellsPostUpdateWorksheetRowExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            double? height = 10.8;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostUpdateWorksheetRow(name, sheetName, rowIndex, height, folder);
            Console.WriteLine(response);

        }


        public void CellsPostWorksheetCellSetValueExample(string Value, string Type, string Formula)
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "A1";
            string value = Value;
            string type = Type;
            string formula = Formula;
            string folder = null;
            var response = instance.CellsPostWorksheetCellSetValue(name, sheetName, cellName, value, type, formula, folder);
            Console.WriteLine(response);

        }


        public void CellsPostWorksheetMergeExample()
        {
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 4;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostWorksheetMerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Console.WriteLine(response);

        }


        public void CellsPostWorksheetUnmergeExample()
        {
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 4;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPostWorksheetUnmerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Console.WriteLine(response);

        }


        public void CellsPutInsertWorksheetColumnsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPutInsertWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Console.WriteLine(response);

        }


        public void CellsPutInsertWorksheetRowExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPutInsertWorksheetRow(name, sheetName, rowIndex, folder);
            Console.WriteLine(response);

        }

        public void CellsPutInsertWorksheetRowsExample()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? startrow = 1;
            int? totalRows = 2;
            bool? updateReference = true;
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsPutInsertWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
            Console.WriteLine(response);

        }

    }

}