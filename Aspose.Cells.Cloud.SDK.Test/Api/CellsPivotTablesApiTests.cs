namespace Aspose.Cells.Cloud.SDK.Test
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    /// <summary>
    ///  Class for testing CellsPivotTablesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsPivotTablesApiTests:CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

       
        /// <summary>
        /// Test CellsPivotTablesDeletePivotTableField
        /// </summary>
        [Test]
        public void CellsPivotTablesDeletePivotTableFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string pivotFieldType = "row";
            PivotTableFieldRequest request = new PivotTableFieldRequest();
            request.Data = new List<int?> { 1 };
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesDeletePivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPivotTablesDeleteWorksheetPivotTable
        /// </summary>
        [Test]
        public void CellsPivotTablesDeleteWorksheetPivotTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTable(name, sheetName, pivotTableIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPivotTablesDeleteWorksheetPivotTableFilter
        /// </summary>
        [Test]
        public void CellsPivotTablesDeleteWorksheetPivotTableFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
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
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, pivotFilter, needReCalculate, folder);
            Assert.AreEqual(response.Code, 200);

            int? fieldIndex = 0;
            response = instance.CellsPivotTablesDeleteWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, fieldIndex, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPivotTablesDeleteWorksheetPivotTableFilters
        /// </summary>
        [Test]
        public void CellsPivotTablesDeleteWorksheetPivotTableFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            bool? needReCalculate = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesDeleteWorksheetPivotTables
        /// </summary>
        [Test]
        public void CellsPivotTablesDeleteWorksheetPivotTablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesDeleteWorksheetPivotTables(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesGetPivotTableField
        /// </summary>
        [Test]
        public void CellsPivotTablesGetPivotTableFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            int? pivotFieldIndex = 0;
            string pivotFieldType = "Row";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesGetPivotTableField(name, sheetName, pivotTableIndex, pivotFieldIndex, pivotFieldType, folder);
            Assert.IsInstanceOf<PivotFieldResponse>(response, "response is PivotFieldResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesGetWorksheetPivotTable
        /// </summary>
        [Test]
        public void CellsPivotTablesGetWorksheetPivotTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivottableIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTable(name, sheetName, pivottableIndex, folder);
            Assert.IsInstanceOf<PivotTableResponse>(response, "response is PivotTableResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesGetWorksheetPivotTableFilter
        /// </summary>
        [Test]
        public void CellsPivotTablesGetWorksheetPivotTableFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            string name = PivTestFile;
            string sheetName = SHEET4;
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
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, pivotFilter, needReCalculate, folder);
            Assert.AreEqual(response.Code, 200);
            int filterIndex = 0;
            response = instance.CellsPivotTablesGetWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, filterIndex, folder);
            Assert.IsInstanceOf<PivotFilterResponse>(response, "response is PivotFilterResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesGetWorksheetPivotTableFilters
        /// </summary>
        [Test]
        public void CellsPivotTablesGetWorksheetPivotTableFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, folder);
            Assert.IsInstanceOf<PivotFiltersResponse>(response, "response is PivotFiltersResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesGetWorksheetPivotTables
        /// </summary>
        [Test]
        public void CellsPivotTablesGetWorksheetPivotTablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesGetWorksheetPivotTables(name, sheetName, folder);
            Assert.IsInstanceOf<PivotTablesResponse>(response, "response is PivotTablesResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPostPivotTableCellStyle
        /// </summary>
        [Test]
        public void CellsPivotTablesPostPivotTableCellStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            int? column = 1;
            int? row = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 17;
            bool? needReCalculate = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostPivotTableCellStyle(name, sheetName, pivotTableIndex, column, row, style, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPostPivotTableFieldHideItem
        /// </summary>
        [Test]
        public void CellsPivotTablesPostPivotTableFieldHideItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string pivotFieldType = "Row";
            int? fieldIndex = 0;
            int? itemIndex = 1;
            bool? isHide = true;
            bool? needReCalculate = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostPivotTableFieldHideItem(name, sheetName, pivotTableIndex, pivotFieldType, fieldIndex, itemIndex, isHide, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPostPivotTableFieldMoveTo
        /// </summary>
        [Test]
        public void CellsPivotTablesPostPivotTableFieldMoveToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            int? fieldIndex = 0;
            string from = "Row";
            string to = "Column";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostPivotTableFieldMoveTo(name, sheetName, pivotTableIndex, fieldIndex, from, to, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsPivotTablesPostPivotTableFieldMoveTo
        /// </summary>
        [Test]
        public void CellsPivotTablesPostPivotTableFieldFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            int? fieldIndex = 0;
            PivotField pivotField = new PivotField();
            pivotField.ShowCompact = true; 
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsPivotTablesPostPivotTableUpdatePivotField(name, sheetName, pivotTableIndex, fieldIndex, "Row", pivotField,true,folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsPivotTablesPostPivotTableStyle
        /// </summary>
        [Test]
        public void CellsPivotTablesPostPivotTableStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 18;

            bool? needReCalculate = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostPivotTableStyle(name, sheetName, pivotTableIndex, style, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPostWorksheetPivotTableCalculate
        /// </summary>
        [Test]
        public void CellsPivotTablesPostWorksheetPivotTableCalculateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostWorksheetPivotTableCalculate(name, sheetName, pivotTableIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPostWorksheetPivotTableMove
        /// </summary>
        [Test]
        public void CellsPivotTablesPostWorksheetPivotTableMoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            int? row = 1;
            int? column = 1;
            string destCellName = "C10";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPostWorksheetPivotTableMove(name, sheetName, pivotTableIndex, row, column, destCellName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPutPivotTableField
        /// </summary>
        [Test]
        public void CellsPivotTablesPutPivotTableFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            int? pivotTableIndex = 0;
            string pivotFieldType = "Row";
            PivotTableFieldRequest request = new PivotTableFieldRequest();
            request.Data = new List<int?>() { 1};
            bool? needReCalculate = null;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPutPivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPutWorksheetPivotTable
        /// </summary>
        [Test]
        public void CellsPivotTablesPutWorksheetPivotTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
            CreatePivotTableRequest request = new CreatePivotTableRequest();
            //"TestPiov", "=Sheet2!A1:E8", "C10",true
            request.Name = "TestPivot";
            request.DestCellName = "C1";
            request.SourceData = "Sheet1!C6:E13";
            request.UseSameSource = true;
            request.PivotFieldColumns = new List<int?> { 1};
            request.PivotFieldData = new List<int?> { 2 };
            request.PivotFieldRows = new List<int?> { 3 };
            request = null;
            string folder = TEMPFOLDER;
            string sourceData = "Sheet1!C6:E13";
            string destCellName = "C1";
            string tableName = "TestPivot";
            bool? useSameSource = true;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTable(name, sheetName, request, folder, null, sourceData, destCellName, tableName, useSameSource);
            Assert.IsInstanceOf<PivotTableResponse>(response, "response is PivotTableResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsPivotTablesPutWorksheetPivotTable
        /// </summary>
        [Test]
        public void CellsPivotTablesPutWorksheetPivotTableTest_2()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile2;
            string sheetName = SHEET3;
            CreatePivotTableRequest request = new CreatePivotTableRequest();            
            request.DestCellName = "C1";
            request.Name = "Test";
            request.PivotFieldColumns = new List<int?>(){ 0, 1};
            request.PivotFieldRows = new List<int?>() { 2, 3 };
            request.PivotFieldData = new List<int?>() { 4 };
            request.SourceData = "Sheet2!$A$1:$E$8";
            request.UseSameSource = false;

            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTable(name, sheetName, request, folder, null, null, null, null, null);
            Assert.IsInstanceOf<PivotTableResponse>(response, "response is PivotTableResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsPivotTablesPutWorksheetPivotTableFilter
        /// </summary>
        [Test]
        public void CellsPivotTablesPutWorksheetPivotTableFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = PivTestFile;
            string sheetName = SHEET4;
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
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, pivotFilter, needReCalculate, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

    }

}
