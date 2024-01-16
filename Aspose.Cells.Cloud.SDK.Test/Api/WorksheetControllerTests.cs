// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorksheetControllerTests.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
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
    /// Test case of WorksheetController.
    /// </summary>
    [TestClass]
    public class WorksheetControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheets()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetsRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheets(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetWithFormat of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetWithFormat()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetWithFormatRequest(
                name: remoteName,
                sheetName: "Sheet1",
                format: "png",
                pageIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetWithFormat(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PutChangeVisibilityWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutChangeVisibilityWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutChangeVisibilityWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                isVisible: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutChangeVisibilityWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutActiveWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutActiveWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutActiveWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutActiveWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutInsertNewWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutInsertNewWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutInsertNewWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 1,
                sheettype: "VB",
                newsheetname: "VBASheet",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutInsertNewWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutAddNewWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutAddNewWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutAddNewWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                position: 0,
                sheettype: "VB",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutAddNewWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheets()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var matchCondition = new MatchConditionRequest()
            {
                RegexPattern = "{*}"
            };
            var request = new DeleteWorksheetsRequest(
                name: remoteName,
                matchCondition: matchCondition,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheets(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostMoveWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostMoveWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var moving = new WorksheetMovingRequest()
            {
                DestinationWorksheet = "Sheet4",
                Position = "After"
            };
            var request = new PostMoveWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                moving: moving,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostMoveWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutProtectWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutProtectWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var protectParameter = new ProtectSheetParameter()
            {
                ProtectionType = "ALL",
                Password = "123"
            };
            var request = new PutProtectWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                protectParameter: protectParameter,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutProtectWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteUnprotectWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteUnprotectWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var protectParameter = new ProtectSheetParameter()
            {
                ProtectionType = "ALL",
                Password = "123"
            };
            var request = new DeleteUnprotectWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet1",
                protectParameter: protectParameter,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteUnprotectWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetTextItems of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetTextItems()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetTextItemsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetTextItems(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetComments of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetComments()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCommentsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetComments(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetComment of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetComment()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCommentRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "B3",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetComment(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetComment of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetComment()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var comment = new Comment()
            {
                Author = "aspose cells developer",
                Note = "aspose cells cloud api add comment."
            };
            var request = new PutWorksheetCommentRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "C1",
                comment: comment,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetComment(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetComment of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetComment()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var comment = new Comment()
            {
                Author = "aspose cells developer",
                Note = "aspose cells cloud api update comment."
            };
            var request = new PostWorksheetCommentRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "B3",
                comment: comment,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetComment(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetComment of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetComment()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetCommentRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellName: "B3",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetComment(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetComments of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetComments()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetCommentsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetComments(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetMergedCells of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetMergedCells()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetMergedCellsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetMergedCells(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetMergedCell of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetMergedCell()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetMergedCellRequest(
                name: remoteName,
                sheetName: "Sheet1",
                mergedCellIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetMergedCell(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetCalculateFormula of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetCalculateFormula()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCalculateFormulaRequest(
                name: remoteName,
                sheetName: "Sheet1",
                formula: "=NOW()",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetCalculateFormula(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCalculateFormula of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCalculateFormula()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetCalculateFormulaRequest(
                name: remoteName,
                sheetName: "Sheet1",
                formula: "=NOW()",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCalculateFormula(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetTextSearch of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetTextSearch()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetTextSearchRequest(
                name: remoteName,
                sheetName: "Sheet1",
                text: "123",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetTextSearch(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetTextReplace of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetTextReplace()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetTextReplaceRequest(
                name: remoteName,
                sheetName: "Sheet1",
                oldValue: "123",
                newValue: "456",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetTextReplace(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetRangeSort of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetRangeSort()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dataSorter = new DataSorter()
            {
                CaseSensitive = true
            };
            var request = new PostWorksheetRangeSortRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellArea: "A1:C10",
                dataSorter: dataSorter,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetRangeSort(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostAutofitWorksheetRow of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAutofitWorksheetRow()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostAutofitWorksheetRowRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rowIndex: 1,
                firstColumn: 1,
                lastColumn: 8,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostAutofitWorksheetRow(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostAutofitWorksheetRows of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAutofitWorksheetRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostAutofitWorksheetRowsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startRow: 1,
                endRow: 9,
                onlyAuto: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostAutofitWorksheetRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostAutofitWorksheetColumns of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAutofitWorksheetColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostAutofitWorksheetColumnsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startColumn: 1,
                endColumn: 9,
                onlyAuto: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostAutofitWorksheetColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetBackground of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetBackground()
        {
            string localName = "Book1.xlsx";
            string waterMarkPNG = "WaterMark.png";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( waterMarkPNG, remoteFolder + "/WaterMark.png", "");

            var request = new PutWorksheetBackgroundRequest(
                name: remoteName,
                sheetName: "Sheet1",
                picPath: remoteFolder + "/WaterMark.png",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetBackground(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetBackground of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetBackground()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetBackgroundRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetBackground(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFreezePanes of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFreezePanes()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFreezePanesRequest(
                name: remoteName,
                sheetName: "Sheet1",
                row: 1,
                column: 1,
                freezedRows: 4,
                freezedColumns: 5,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFreezePanes(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetFreezePanes of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetFreezePanes()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetFreezePanesRequest(
                name: remoteName,
                sheetName: "Sheet1",
                row: 1,
                column: 1,
                freezedRows: 4,
                freezedColumns: 5,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetFreezePanes(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostCopyWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostCopyWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var options = new CopyOptions()
            {
                ColumnCharacterWidth = true
            };
            var request = new PostCopyWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet15",
                sourceSheet: "Sheet6",
                options: options,
                sourceWorkbook: "",
                sourceFolder: "",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostCopyWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostRenameWorksheet of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostRenameWorksheet()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostRenameWorksheetRequest(
                name: remoteName,
                sheetName: "Sheet5",
                newname: "Sheet55",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostRenameWorksheet(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetProperty of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetProperty()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var sheet = new Worksheet()
            {
                Name = "sheet65",
                IsGridlinesVisible = true
            };
            var request = new PostUpdateWorksheetPropertyRequest(
                name: remoteName,
                sheetName: "Sheet5",
                sheet: sheet,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetProperty(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetNamedRanges of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetNamedRanges()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetNamedRangesRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetNamedRanges(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetNamedRangeValue of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetNamedRangeValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetNamedRangeValueRequest(
                name: remoteName,
                namerange: "Name_2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetNamedRangeValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetZoom of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetZoom()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostUpdateWorksheetZoomRequest(
                name: remoteName,
                sheetName: "Sheet1",
                value: 90,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetZoom(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetPageCount of WorksheetController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetPageCount()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetPageCountRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetPageCount(request);
            Assert.IsNotNull(actual);
        }
    }
}
