/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsApiTests : CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi(clientId, clientSecret);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test CellsDeleteWorksheetColumns
        /// </summary>
        [Test]
        public void CellsDeleteWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsDeleteWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Assert.IsInstanceOf<ColumnsResponse>(response, "response is ColumnsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsDeleteWorksheetColumns
        /// </summary>
        [Test]
        public void CellsDeleteWorksheetColumnsForNewConstructorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var instanceNew = new CellsApi( clientId, clientSecret);
            var response = instanceNew.CellsDeleteWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Assert.IsInstanceOf<ColumnsResponse>(response, "response is ColumnsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsDeleteWorksheetRow
        /// </summary>
        [Test]
        public void CellsDeleteWorksheetRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsDeleteWorksheetRow(name, sheetName, rowIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsDeleteWorksheetRow
        /// </summary>
        [Test]
        public void CellsDeleteWorksheetRowForNewConstructorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsDeleteWorksheetRow(name, sheetName, rowIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsDeleteWorksheetRows
        /// </summary>
        [Test]
        public void CellsDeleteWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startrow = 1;
            int? totalRows = 2;
            bool? updateReference = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsDeleteWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsGetWorksheetCell
        /// </summary>
        [TestCase("A1")]
        [TestCase("firstcell")]
        [TestCase("endcell")]
        public void CellsGetWorksheetCellTest(string paramCellOrMethodName)
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellOrMethodName = paramCellOrMethodName;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetCell(name, sheetName, cellOrMethodName, folder);
            Assert.IsInstanceOf<Object>(response, "response is System.IO.Stream");
            //Assert.AreEqual(response.Code, 200);
        }

        [TestCase("maxrow")]
        [TestCase("maxdatarow")]
        [TestCase("maxcolumn")]
        [TestCase("maxdatacolumn")]
        [TestCase("minrow")]
        [TestCase("mindatarow")]
        [TestCase("mincolumn")]
        [TestCase("mindatacolumn")]
        public void CellsGetWorksheetCellTest1(string paramCellOrMethodName)
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellOrMethodName = paramCellOrMethodName;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetCell(name, sheetName, cellOrMethodName, folder);
            Assert.IsInstanceOf<Object>(response, "response is System.IO.Stream");
        }

        /// <summary>
        /// Test CellsGetWorksheetCellStyle
        /// </summary>
        [Test]
        public void CellsGetWorksheetCellStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetCellStyle(name, sheetName, cellName, folder);
            Assert.IsInstanceOf<StyleResponse>(response, "response is StyleResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsGetWorksheetCells
        /// </summary>
        [Test]
        public void CellsGetWorksheetCellsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? offest = 1;
            int? count = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetCells(name, sheetName, offest, count, folder);
            Assert.IsInstanceOf<CellsResponse>(response, "response is CellsResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsGetWorksheetColumn
        /// </summary>
        [Test]
        public void CellsGetWorksheetColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetColumn(name, sheetName, columnIndex, folder);
            Assert.IsInstanceOf<ColumnResponse>(response, "response is ColumnResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsGetWorksheetColumns
        /// </summary>
        [Test]
        public void CellsGetWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetColumns(name, sheetName, folder);
            Assert.IsInstanceOf<ColumnsResponse>(response, "response is ColumnsResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsGetWorksheetRow
        /// </summary>
        [Test]
        public void CellsGetWorksheetRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetRow(name, sheetName, rowIndex, folder);
            Assert.IsInstanceOf<RowResponse>(response, "response is RowResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsGetWorksheetRows
        /// </summary>
        [Test]
        public void CellsGetWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetWorksheetRows(name, sheetName, folder);
            Assert.IsInstanceOf<RowsResponse>(response, "response is RowsResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostCellCalculate
        /// </summary>
        [Test]
        public void CellsPostCellCalculateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            CalculationOptions options = new CalculationOptions();
            options.Recursive = true;
            options.IgnoreError = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostCellCalculate(name, sheetName, cellName, options, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostCellCharacters
        /// </summary>
        [Test]
        public void CellsPostCellCharactersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET2;
            string cellName = "G8";
            List<FontSetting> options = new List<FontSetting>();
            Font font = new Font();
            font.Size = 10;
            FontSetting fs1 = new FontSetting();
            fs1.Font = font;
            fs1.Length = 2;
            fs1.StartIndex = 0;
            options.Add(fs1);
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostCellCharacters(name, sheetName, cellName, options, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostClearContents
        /// </summary>
        [Test]
        public void CellsPostClearContentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 3;
            int? endColumn = 3;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostClearContents(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostClearFormats
        /// </summary>
        [Test]
        public void CellsPostClearFormatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 3;
            int? endColumn = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostClearFormats(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostColumnStyle
        /// </summary>
        [Test]
        public void CellsPostColumnStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.IsBold = true;
            style.Font.Size = 16;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostColumnStyle(name, sheetName, columnIndex, style, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostCopyCellIntoCell
        /// </summary>
        [Test]
        public void CellsPostCopyCellIntoCellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string destCellName = "C1";
            string sheetName = SHEET1;
            string worksheet = SHEET2;
            string cellName = CellName;
            int? row = 1;
            int? column = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostCopyCellIntoCell(name, destCellName, sheetName, worksheet, cellName, row, column, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostCopyWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPostCopyWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? sourceColumnIndex = 1;
            int? destinationColumnIndex = 21;
            int? columnNumber = 1;
            string worksheet = SHEET2;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostCopyWorksheetColumns(name, sheetName, sourceColumnIndex, destinationColumnIndex, columnNumber, worksheet, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostCopyWorksheetRows
        /// </summary>
        [Test]
        public void CellsPostCopyWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? sourceRowIndex = 1;
            int? destinationRowIndex = 1;
            int? rowNumber = 1;
            string worksheet = SHEET2;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostCopyWorksheetRows(name, sheetName, sourceRowIndex, destinationRowIndex, rowNumber, worksheet, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostGroupWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPostGroupWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? firstIndex = 1;
            int? lastIndex = 1;
            bool? hide = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostGroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, hide, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostGroupWorksheetRows
        /// </summary>
        [Test]
        public void CellsPostGroupWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? firstIndex = 1;
            int? lastIndex = 1;
            bool? hide = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostGroupWorksheetRows(name, sheetName, firstIndex, lastIndex, hide, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostHideWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPostHideWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startColumn = 1;
            int? totalColumns = 2;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostHideWorksheetColumns(name, sheetName, startColumn, totalColumns, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostHideWorksheetRows
        /// </summary>
        [Test]
        public void CellsPostHideWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startrow = 1;
            int? totalRows = 2;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostHideWorksheetRows(name, sheetName, startrow, totalRows, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostRowStyle
        /// </summary>
        [Test]
        public void CellsPostRowStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 20;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostRowStyle(name, sheetName, rowIndex, style, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }
        /// <summary>
        /// Test CellsGetCellHtmlString
        /// </summary>
        [Test]
        public void CellsGetCellHtmlStringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsGetCellHtmlString(name, sheetName, cellName, folder);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CellsPostSetCellHtmlString
        /// </summary>
        [Test]
        public void CellsPostSetCellHtmlStringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            string folder = TEMPFOLDER;
            string htmlString = "https://api.aspose.cloud/v3.0/cells";
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostSetCellHtmlString(name, sheetName, cellName, System.Text.Encoding.Default.GetBytes(htmlString),folder);
            Assert.IsInstanceOf<CellResponse>(response, "response is CellResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostSetCellRangeValue
        /// </summary>
        [TestCase("1", "int")]
        [TestCase("12345", "String")]
        [TestCase("2017-10-1", "Date")]
        public void CellsPostSetCellRangeValueTest(string Value, string Type)
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellarea = CELLAREA;
            string value = Value;
            string type = Type;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostSetCellRangeValue(name, sheetName, cellarea, value, type, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostSetWorksheetColumnWidth
        /// </summary>
        [Test]
        public void CellsPostSetWorksheetColumnWidthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            double? width = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostSetWorksheetColumnWidth(name, sheetName, columnIndex, width, folder);
            Assert.IsInstanceOf<ColumnResponse>(response, "response is ColumnResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUngroupWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPostUngroupWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? firstIndex = 1;
            int? lastIndex = 5;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUngroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUngroupWorksheetRows
        /// </summary>
        [Test]
        public void CellsPostUngroupWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? firstIndex = 1;
            int? lastIndex = 5;
            bool? isAll = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUngroupWorksheetRows(name, sheetName, firstIndex, lastIndex, isAll, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUnhideWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPostUnhideWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startcolumn = 1;
            int? totalColumns = 2;
            double? width = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUnhideWorksheetColumns(name, sheetName, startcolumn, totalColumns, width, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUnhideWorksheetRows
        /// </summary>
        [Test]
        public void CellsPostUnhideWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startrow = 1;
            int? totalRows = 8;
            double? height = 18;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUnhideWorksheetRows(name, sheetName, startrow, totalRows, height, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUpdateWorksheetCellStyle
        /// </summary>
        [Test]
        public void CellsPostUpdateWorksheetCellStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 19;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUpdateWorksheetCellStyle(name, sheetName, cellName, style, folder);
            Assert.IsInstanceOf<StyleResponse>(response, "response is StyleResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUpdateWorksheetRangeStyle
        /// </summary>
        [Test]
        public void CellsPostUpdateWorksheetRangeStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            Style style = new Style();
            style.Font = new Font();
            style.Font.Size = 15;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUpdateWorksheetRangeStyle(name, sheetName, range, style, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostUpdateWorksheetRow
        /// </summary>
        [Test]
        public void CellsPostUpdateWorksheetRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            double? height = 10.8;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostUpdateWorksheetRow(name, sheetName, rowIndex, height, folder);
            Assert.IsInstanceOf<RowResponse>(response, "response is RowResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostWorksheetCellSetValue
        /// </summary>
        [TestCase("1", "String", null)]
        [TestCase("2018/10/09", "DateTime", "=Now()")]
        [TestCase("1", "int", null)]
        public void CellsPostWorksheetCellSetValueTest(string Value, string Type, string Formula)
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellName = CellName;
            string value = Value;
            string type = Type;
            string formula = Formula;
            string folder = TEMPFOLDER;
            var response = instance.CellsPostWorksheetCellSetValue(name, sheetName, cellName, value, type, formula, folder);
            Assert.IsInstanceOf<CellResponse>(response, "response is CellResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostWorksheetMerge
        /// </summary>
        [Test]
        public void CellsPostWorksheetMergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostWorksheetMerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPostWorksheetUnmerge
        /// </summary>
        [Test]
        public void CellsPostWorksheetUnmergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPostWorksheetUnmerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPutInsertWorksheetColumns
        /// </summary>
        [Test]
        public void CellsPutInsertWorksheetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? columnIndex = 1;
            int? columns = 1;
            bool? updateReference = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPutInsertWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
            Assert.IsInstanceOf<ColumnsResponse>(response, "response is ColumnsResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPutInsertWorksheetRow
        /// </summary>
        [Test]
        public void CellsPutInsertWorksheetRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? rowIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPutInsertWorksheetRow(name, sheetName, rowIndex, folder);
            Assert.IsInstanceOf<RowResponse>(response, "response is RowResponse");
            Assert.AreEqual(response.Status, "OK");
        }

        /// <summary>
        /// Test CellsPutInsertWorksheetRows
        /// </summary>
        [Test]
        public void CellsPutInsertWorksheetRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startrow = 1;
            int? totalRows = 2;
            bool? updateReference = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsPutInsertWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Status, "OK");
        }

    }

}
