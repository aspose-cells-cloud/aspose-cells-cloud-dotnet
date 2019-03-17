   
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
    public class CellsRangesApiExamples
    {
        private CellsRangesApi instance= new CellsRangesApi(new Config().GetConfiguration());


        public void CellsRangesGetWorksheetCellsRangeValueTest()
        {
            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            int? firstRow = 0;
            int? firstColumn = 0;
            int? rowCount = 3;
            int? columnCount = 2;
            var response = instance.CellsRangesGetWorksheetCellsRangeValue(name, sheetName, null, firstRow, firstColumn, rowCount, columnCount, folder);
            

            var rangeName = "A1:B3";
            response = instance.CellsRangesGetWorksheetCellsRangeValue(name, sheetName, rangeName, null, null, null, null, folder);
           

            rangeName = "Name_2";
            response = instance.CellsRangesGetWorksheetCellsRangeValue(name, sheetName, rangeName, null, null, null, null, folder);
            Console.WriteLine(response);
        }

        

        public void CellsRangesPostWorksheetCellsRangeColumnWidthTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            double? value = 10.01;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeColumnWidth(name, sheetName, value, range, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangeMergeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeMerge(name, sheetName, range, folder);
            Console.WriteLine(response);
        }
        
  
        public void CellsRangesPostWorksheetCellsRangeMoveToTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? destRow = 1;
            int? destColumn = 1;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeMoveTo(name, sheetName, destRow, destColumn, range, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangeOutlineBorderTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            RangeSetOutlineBorderRequest rangeOperate = 
                new RangeSetOutlineBorderRequest();
            //new Range(10,10.1,1,1,null,null,2,16.8), "LeftBorder", "None"
            rangeOperate.BorderEdge = "LeftBorder";
            rangeOperate.BorderStyle = "Dotted";
            rangeOperate.BorderColor = new Color();
            rangeOperate.BorderColor.R = 255;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 10;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 2;
            range.RowHeight = 10;
            rangeOperate.Range = range;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeOutlineBorder(name, sheetName, rangeOperate, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangeRowHeightTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            double? value = 10.99;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeRowHeight(name, sheetName, value, range, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangeStyleTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            RangeSetStyleRequest rangeOperate = new RangeSetStyleRequest();
            //new Range(10, 10.1, 1, 1, null, null, 2, 16.8), new Style (null ,new Font(null,19))
            rangeOperate.Style = new Style();
            rangeOperate.Style.Font = new Font();
            rangeOperate.Style.Font.IsBold = true;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            rangeOperate.Range = range;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeStyle(name, sheetName, rangeOperate, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangeUnMergeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeUnmerge(name, sheetName, range, folder);
            Console.WriteLine(response);
        }


        public void CellsRangesPostWorksheetCellsRangeValueTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string value = "null";
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            bool? isConverted =true;
            bool? setStyle = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRangeValue(name, sheetName, value, range, isConverted, setStyle, folder);
            Console.WriteLine(response);
        }
        

        public void CellsRangesPostWorksheetCellsRangesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            RangeCopyRequest rangeOperate = new RangeCopyRequest();
            //"copydata", new Range(10, 10.1, 1, 1, null, null, 2, 16.8), new Range(20, 10.1, 1, 1, null, null, 2, 16.8), new PasteOptions(true)
            rangeOperate.Operate = "copydata";
            rangeOperate.PasteOptions = new PasteOptions();
            rangeOperate.PasteOptions.OnlyVisibleCells = true;
            Range range = new Range(); //10,10.1,1,1,null,null,2,16.8
            range.ColumnCount = 1;
            range.ColumnWidth = 10.1;
            range.FirstColumn = 1;
            range.FirstRow = 1;
            range.RowCount = 10;
            Range range2= new Range(); //10,10.1,1,1,null,null,2,16.8
            range2.ColumnCount = 1;
            range2.ColumnWidth = 10.1;
            range2.FirstColumn = 1;
            range2.FirstRow = 20;
            range2.RowCount = 10;
            rangeOperate.Source = range;
            rangeOperate.Target = range2;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsRangesPostWorksheetCellsRanges(name, sheetName, rangeOperate, folder);
            Console.WriteLine(response);
        }
        
    }
}