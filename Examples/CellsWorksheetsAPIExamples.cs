                          
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
    public class CellsWorksheetsApiExamples
    {
        private CellsWorksheetsApi instance= new CellsWorksheetsApi(new Config().GetConfiguration ());


        public void CellsWorksheetsDeleteUnprotectWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            ProtectSheetParameter protectParameter = new ProtectSheetParameter ();
            protectParameter.Password = "12345";
            protectParameter.ProtectionType = "All";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteUnprotectWorksheet(name, sheetName, protectParameter, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsDeleteWorkSheetBackgroundTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteWorksheetBackground(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsDeleteWorkSheetCommentTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "C1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteWorksheetComment(name, sheetName, cellName, folder);
            Console.WriteLine(response);
        }
        


        public void CellsWorksheetsDeleteWorkSheetCommentsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteWorksheetComments(name, sheetName, folder);
            Console.WriteLine(response);
        }
        
 
        public void CellsWorksheetsDeleteWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteWorksheet(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsDeleteWorksheetFreezePanesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? row = 1;
            int? column = 1;
            int? freezedRows = 2;
            int? freezedColumns = 2;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsDeleteWorksheetFreezePanes(name, sheetName, row, column, freezedRows, freezedColumns, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetNamedRangesTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetNamedRanges(name, folder);
            Console.WriteLine(response);
        }

        public void CellsWorksheetsGetWorkSheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? verticalResolution = 100;
            int? horizontalResolution = 90;
            string format = "png";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheet(name, sheetName, format, verticalResolution, horizontalResolution, folder);
            Console.WriteLine(response);

        }
        

        public void CellsWorksheetsGetWorkSheetCalculateFormulaTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string formula = "=NOW()";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetCalculateFormula(name, sheetName, formula, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetWorkSheetCommentTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "B3";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetComment(name, sheetName, cellName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetWorkSheetCommentsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetComments(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetWorkSheetMergedCellTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? mergedCellIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetMergedCell(name, sheetName, mergedCellIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetWorkSheetMergedCellsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetMergedCells(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsGetWorkSheetTextItemsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheetTextItems(name, sheetName, folder);
            Console.WriteLine(response);
        }

        public void CellsWorksheetsGetWorkSheetsTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsGetWorksheets(name, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostAutofitWorksheetColumnsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? firstColumn = 1;
            int? lastColumn = 10;
            AutoFitterOptions autoFitterOptions = null;
            int? firstRow = 1;
            int? lastRow = 19;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostAutofitWorksheetColumns(name, sheetName, firstColumn, lastColumn, autoFitterOptions, firstRow, lastRow, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostAutofitWorksheetRowTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? rowIndex = 1;
            int? firstColumn = 1;
            int? lastColumn = 10;
            AutoFitterOptions autoFitterOptions = new AutoFitterOptions();
            autoFitterOptions.AutoFitMergedCells = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostAutofitWorksheetRow(name, sheetName, rowIndex, firstColumn, lastColumn, autoFitterOptions, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostAutofitWorksheetRowsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            AutoFitterOptions autoFitterOptions = new AutoFitterOptions();
            autoFitterOptions.AutoFitMergedCells = true;
            int? startRow = 1;
            int? endRow = 10;
            bool? onlyAuto = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostAutofitWorksheetRows(name, sheetName, autoFitterOptions, startRow, endRow, onlyAuto, folder);
           Console.WriteLine(response);
        }

        public void CellsWorksheetsPostCopyWorksheetTest()
        {

            string name = "NewCopy.xlsx";
            string sheetName = "SHEET5";
            string sourceSheet = "SHEET6";
            CopyOptions options = new CopyOptions();
            options.ColumnCharacterWidth = true;
            string sourceWorkbook = "Book1.xlsx";
            string sourceFolder = null;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile(folder, sourceWorkbook);
            var response = instance.CellsWorksheetsPostCopyWorksheet(name, sheetName, sourceSheet, options,  sourceWorkbook, sourceFolder, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostMoveWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            WorksheetMovingRequest moving = new WorksheetMovingRequest();//"SHEET3", "after"
            moving.DestinationWorksheet = "SHEET3";
            moving.Position = "after";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostMoveWorksheet(name, sheetName, moving, folder);
            Console.WriteLine(response);
        }

        public void CellsWorksheetsPostRenameWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string newname = "renametest";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostRenameWorksheet(name, sheetName, newname, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostUpdateWorksheetPropertyTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            Worksheet sheet = new Worksheet();
            sheet.Index = 0;
            sheet.IsGridlinesVisible = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostUpdateWorksheetProperty(name, sheetName, sheet, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostUpdateWorksheetZoomTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? value = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostUpdateWorksheetZoom(name, sheetName, value, folder);
           Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostWorkSheetCommentTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "B3";
            Comment comment = new Comment();
            comment.Author = "Roy";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostWorksheetComment(name, sheetName, cellName, comment, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostWorkSheetTextSearchTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string text = "123456";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostWorksheetTextSearch(name, sheetName, text, folder);
            Console.WriteLine(response);
        }

        public void CellsWorksheetsPostWorksheetRangeSortTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellArea = "a1:a10";
            DataSorter dataSorter = new DataSorter();
            dataSorter.CaseSensitive = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostWorksheetRangeSort(name, sheetName, cellArea, dataSorter, folder);
           Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPostWorsheetTextReplaceTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string oldValue = "1234";
            string newValue = "56678";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPostWorsheetTextReplace(name, sheetName, oldValue, newValue, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPutAddNewWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? position = 1;
            string sheettype = "VB";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPutAddNewWorksheet(name, sheetName, position, sheettype, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPutChangeVisibilityWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            bool? isVisible = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPutChangeVisibilityWorksheet(name, sheetName, isVisible, folder);
            Console.WriteLine(response);
        }
        
  

        public void CellsWorksheetsPutProtectWorksheetTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            ProtectSheetParameter protectParameter =  new ProtectSheetParameter();
            protectParameter.ProtectionType = "All";
            protectParameter.Password = "123";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPutProtectWorksheet(name, sheetName, protectParameter, folder);
            Console.WriteLine(response);
        }



        public void CellsWorksheetsPutWorkSheetCommentTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string cellName = "C1";
            Comment comment = new Comment ();
            comment.Author = "roy";
            WorkbookEncryptionRequest encryption = new WorkbookEncryptionRequest();
            encryption.Password = "123456";
            encryption.KeyLength = 128;
            encryption.EncryptionType = "XOR";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPutWorksheetComment(name, sheetName, cellName, comment, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetsPutWorksheetFreezePanesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? row = 1;
            int? column = 1;
            int? freezedRows = 4;
            int? freezedColumns = 5;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetsPutWorksheetFreezePanes(name, sheetName, row, column, freezedRows, freezedColumns, folder);
            Console.WriteLine(response);
        }
        
    }
}