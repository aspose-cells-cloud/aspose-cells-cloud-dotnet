
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
    public class CellsPivotTablesApiExamples
    {
        private CellsPivotTablesApi instance = new CellsPivotTablesApi(new Config().GetConfiguration());

        public void CellsPivotTablesDeletePivotTableFieldTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string pivotFieldType = "row";
            PivotTableFieldRequest request = new PivotTableFieldRequest();
            request.Data = new List<int?> { 1 };
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesDeletePivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPivotTablesDeleteWorksheetPivotTableTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTable(name, sheetName, pivotTableIndex, folder);
           Console.WriteLine(response);
        }

        public void CellsPivotTablesDeleteWorksheetPivotTableFilterTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            int? fieldIndex = 0;
            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, fieldIndex, needReCalculate, folder);
            Console.WriteLine(response);
        }

        public void CellsPivotTablesDeleteWorksheetPivotTableFiltersTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, needReCalculate, folder);
            Console.WriteLine(response);
        }

   
        public void CellsPivotTablesDeleteWorksheetPivotTablesTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTables(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesGetPivotTableFieldTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            int? pivotFieldIndex = 0;
            string pivotFieldType = "Row";
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesGetPivotTableField(name, sheetName, pivotTableIndex, pivotFieldIndex, pivotFieldType, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesGetWorksheetPivotTableTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivottableIndex = 0;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTable(name, sheetName, pivottableIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesGetWorksheetPivotTableFilterTest()
        {


            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            PivotFilter pivotFilter = new PivotFilter();
            pivotFilter.FieldIndex = 1;
            pivotFilter.FilterType = "Count";

            AutoFilter autoFilter = new AutoFilter();
            autoFilter.FilterColumns = new List<FilterColumn>();
            FilterColumn filterColumn = new FilterColumn();
            filterColumn.FilterType = "Top10";
            filterColumn.FieldIndex = 0;

            filterColumn.Top10Filter = new Top10Filter();
            filterColumn.Top10Filter.Items = 1;
            filterColumn.Top10Filter.IsTop = true;
            filterColumn.Top10Filter.IsPercent = false;
            autoFilter.FilterColumns.Add(filterColumn);
            pivotFilter.AutoFilter = autoFilter;

            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, pivotFilter, needReCalculate, folder);
            int filterIndex = 0;
            response = instance.CellsPivotTablesGetWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, filterIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesGetWorksheetPivotTableFiltersTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesGetWorksheetPivotTablesTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTables(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesPostPivotTableCellStyleTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            int? column = 1;
            int? row = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 17;
            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostPivotTableCellStyle(name, sheetName, pivotTableIndex, column, row, style, needReCalculate, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesPostPivotTableFieldHideItemTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string pivotFieldType = "Row";
            int? fieldIndex = 0;
            int? itemIndex = 1;
            bool? isHide = true;
            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostPivotTableFieldHideItem(name, sheetName, pivotTableIndex, pivotFieldType, fieldIndex, itemIndex, isHide, needReCalculate, folder);
            Console.WriteLine(response);
        }

        public void CellsPivotTablesPostPivotTableFieldMoveToTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            int? fieldIndex = 0;
            string from = "Row";
            string to = "Column";
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostPivotTableFieldMoveTo(name, sheetName, pivotTableIndex, fieldIndex, from, to, folder);
           Console.WriteLine(response);
        }


        public void CellsPivotTablesPostPivotTableStyleTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 18;

            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostPivotTableStyle(name, sheetName, pivotTableIndex, style, needReCalculate, folder);
            Console.WriteLine(response);
        }

        public void CellsPivotTablesPostWorksheetPivotTableCalculateTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostWorksheetPivotTableCalculate(name, sheetName, pivotTableIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesPostWorksheetPivotTableMoveTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            int? row = 1;
            int? column = 1;
            string destCellName = "C10";
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPostWorksheetPivotTableMove(name, sheetName, pivotTableIndex, row, column, destCellName, folder);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesPutPivotTableFieldTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            string pivotFieldType = "Row";
            PivotTableFieldRequest request = new PivotTableFieldRequest();
            request.Data = new List<int?>() { 1};
            bool? needReCalculate = null;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPutPivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, needReCalculate, folder);
            Console.WriteLine(response);
        }

        public void CellsPivotTablesPutWorksheetPivotTableTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            CreatePivotTableRequest request = new CreatePivotTableRequest();
            request.Name = "TestPivot";
            request.DestCellName = "C1";
            request.SourceData = "Sheet1!C6:E13";
            request.UseSameSource = true;
            string folder = "TEMPFOLDER";
            string sourceData = "Sheet1!C6:E13";
            string destCellName = "C1";
            string tableName = "TestPivot";
            bool? useSameSource = true;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTable(name, sheetName, null, folder, null, sourceData, destCellName, tableName, useSameSource);
            Console.WriteLine(response);
        }


        public void CellsPivotTablesPutWorksheetPivotTableFilterTest()
        {

            string name = "TestCase.xlsx";
            string sheetName = "SHEET4";
            int? pivotTableIndex = 0;
            PivotFilter pivotFilter = new PivotFilter();
            pivotFilter.FieldIndex = 1;
            pivotFilter.FilterType = "Count";

            AutoFilter autoFilter = new AutoFilter();
            autoFilter.FilterColumns = new List<FilterColumn>();
            FilterColumn filterColumn = new FilterColumn();
            filterColumn.FilterType = "Top10";
            filterColumn.FieldIndex = 0;

            filterColumn.Top10Filter = new Top10Filter();
            filterColumn.Top10Filter.Items = 1;
            filterColumn.Top10Filter.IsTop = true;
            filterColumn.Top10Filter.IsPercent = false;
            autoFilter.FilterColumns.Add(filterColumn);
            pivotFilter.AutoFilter = autoFilter;

            bool? needReCalculate = true;
            string folder = "TEMPFOLDER";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, pivotFilter, needReCalculate, folder);
            Console.WriteLine(response);
        }

    }
}