// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsControllerTests.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Tests.Api.Api
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    /// <summary>
    /// Test case of CellsController.
    /// </summary>
    [TestClass]
    public class CellsControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostClearContents of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostClearContents()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostClearContentsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:C10",
                startRow: 1,
                startColumn: 1,
                endRow: 3,
                endColumn: 3,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostClearContents(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostClearFormats of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostClearFormats()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostClearFormatsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:C10",
                startRow: 1,
                startColumn: 1,
                endRow: 3,
                endColumn: 3,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostClearFormats(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetRangeStyle of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetRangeStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostUpdateWorksheetRangeStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:C10",
                style: style,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetRangeStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetMerge of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetMerge()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetMergeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startRow: 1,
                startColumn: 1,
                totalRows: 4,
                totalColumns: 4,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetMerge(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetUnmerge of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetUnmerge()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetUnmergeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startRow: 1,
                startColumn: 1,
                totalRows: 4,
                totalColumns: 4,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetUnmerge(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetCells of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetCells()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCellsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                offest: 1,
                count: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetCells(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetCell of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetCell()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCellRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellOrMethodName: "A1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetCell(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for GetWorksheetCellStyle of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetCellStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCellStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetCellStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellSetValue of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellSetValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetCellSetValueRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                value: "1",
                type: "int",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellSetValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetCellStyle of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetCellStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostUpdateWorksheetCellStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                style: style,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetCellStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostSetCellRangeValue of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostSetCellRangeValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostSetCellRangeValueRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellarea: "A1:C10",
                value: "Test",
                type: "string",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostSetCellRangeValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCopyCellIntoCell of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCopyCellIntoCell()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostCopyCellIntoCellRequest(
                name: remoteName,
                destCellName: "C1",
                sheetName: "Sheet1",
                worksheet: "Sheet2",
                cellname: "A1",
                row: 1,
                column: 1,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCopyCellIntoCell(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetCellHtmlString of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetCellHtmlString()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetCellHtmlStringRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetCellHtmlString(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostSetCellHtmlString of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostSetCellHtmlString()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostSetCellHtmlStringRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostSetCellHtmlString(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCellCalculate of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCellCalculate()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var options = new CalculationOptions()
            {
                Recursive = true,
                IgnoreError = true
            };
            var request = new PostCellCalculateRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "A1",
                options: options,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCellCalculate(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCellCharacters of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCellCharacters()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var optionsvalue0Font = new Font()
            {
                IsBold = true,
                Size = 16
            };
            var optionsvalue0 = new FontSetting()
            {
                Length = 5,
                StartIndex = 0,
                Font = optionsvalue0Font
            };
            var options = new List<FontSetting>()
            {
                optionsvalue0
            };
            var request = new PostCellCharactersRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "E36",
                options: options,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCellCharacters(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                offset: 1,
                count: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostSetWorksheetColumnWidth of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostSetWorksheetColumnWidth()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostSetWorksheetColumnWidthRequest(
                name: remoteName,
                sheetName: "Sheet1",
                columnIndex: 1,
                width: 10.9f,
                count: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostSetWorksheetColumnWidth(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetColumn of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetColumn()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetColumnRequest(
                name: remoteName,
                sheetName: "Sheet1",
                columnIndex: 1,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetColumn(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutInsertWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutInsertWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutInsertWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                columnIndex: 1,
                columns: 10,
                updateReference: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutInsertWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                columnIndex: 1,
                columns: 10,
                updateReference: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostHideWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostHideWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostHideWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startColumn: 1,
                totalColumns: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostHideWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUnhideWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUnhideWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUnhideWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startColumn: 1,
                totalColumns: 10,
                width: 10.9f,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUnhideWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostGroupWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostGroupWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostGroupWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                firstIndex: 1,
                lastIndex: 9,
                hide: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostGroupWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUngroupWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUngroupWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUngroupWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                firstIndex: 1,
                lastIndex: 9,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUngroupWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCopyWorksheetColumns of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCopyWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostCopyWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                sourceColumnIndex: 1,
                destinationColumnIndex: 19,
                columnNumber: 8,
                worksheet: "Sheet2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCopyWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostColumnStyle of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostColumnStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostColumnStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                columnIndex: 1,
                style: style,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostColumnStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                offset: 1,
                count: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetRow of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetRow()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetRowRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetRow(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetRow of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetRow()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetRowRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 1,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetRow(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startrow: 1,
                totalRows: 10,
                updateReference: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutInsertWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutInsertWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutInsertWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startrow: 1,
                totalRows: 10,
                updateReference: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutInsertWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutInsertWorksheetRow of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutInsertWorksheetRow()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutInsertWorksheetRowRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutInsertWorksheetRow(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetRow of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetRow()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUpdateWorksheetRowRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 0,
                height: 10.8f,
                count: 9,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetRow(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostHideWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostHideWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostHideWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startrow: 1,
                totalRows: 6,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostHideWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUnhideWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUnhideWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUnhideWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startrow: 1,
                totalRows: 8,
                height: 10.9f,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUnhideWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostGroupWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostGroupWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostGroupWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                firstIndex: 1,
                lastIndex: 9,
                hide: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostGroupWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUngroupWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUngroupWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUngroupWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                firstIndex: 1,
                lastIndex: 9,
                isAll: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUngroupWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCopyWorksheetRows of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCopyWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostCopyWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                sourceRowIndex: 1,
                destinationRowIndex: 12,
                rowNumber: 5,
                worksheet: "Sheet2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCopyWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostRowStyle of CellsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostRowStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostRowStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 1,
                style: style,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostRowStyle(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
