// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RangesControllerTests.cs">
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
    /// Test case of RangesController.
    /// </summary>
    [TestClass]
    public class RangesControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostWorksheetCellsRanges of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangesCopy()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var rangeOperateSource = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var rangeOperateTarget = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 10,
                RowCount = 10
            };
            var rangeOperate = new RangeCopyRequest()
            {
                Operate = "copydata",
                Source = rangeOperateSource,
                Target = rangeOperateTarget
            };
            var request = new PostWorksheetCellsRangesCopyRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rangeOperate: rangeOperate,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangesCopy(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeMerge of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeMerge()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeMergeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeMerge(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeUnMerge of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeUnMerge()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeUnMergeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeUnMerge(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeStyle of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var rangeOperateStyleFont = new Font()
            {
                Size = 16
            };
            var rangeOperateStyle = new Style()
            {
                Font = rangeOperateStyleFont
            };
            var rangeOperateRange = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var rangeOperate = new RangeSetStyleRequest()
            {
                Style = rangeOperateStyle,
                Range = rangeOperateRange
            };
            var request = new PostWorksheetCellsRangeStyleRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rangeOperate: rangeOperate,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetCellsRangeValue of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetCellsRangeValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetCellsRangeValueRequest(
                name: remoteName,
                sheetName: "Sheet1",
                namerange: "Name_2",
                firstRow: 0,
                firstColumn: 0,
                rowCount: 3,
                columnCount: 2,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetCellsRangeValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeValue of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeValueRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                value: "100",
                isConverted: true,
                setStyle: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeMoveTo of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeMoveTo()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeMoveToRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                destRow: 10,
                destColumn: 10,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeMoveTo(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeOutlineBorder of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeOutlineBorder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var rangeOperateborderColor = new Color()
            {
                R = 48,
                G = 48,
                B = 48
            };
            var rangeOperateRange = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var rangeOperate = new RangeSetOutlineBorderRequest()
            {
                borderEdge = "LeftBorder",
                borderStyle = "Dotted",
                borderColor = rangeOperateborderColor,
                Range = rangeOperateRange
            };
            var request = new PostWorksheetCellsRangeOutlineBorderRequest(
                name: remoteName,
                sheetName: "Sheet1",
                rangeOperate: rangeOperate,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeOutlineBorder(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeColumnWidth of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeColumnWidth()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeColumnWidthRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                value: 10.7f,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeColumnWidth(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeRowHeight of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeRowHeight()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var range = new Range()
            {
                ColumnCount = 1,
                ColumnWidth = 10.0f,
                FirstRow = 1,
                RowCount = 10
            };
            var request = new PostWorksheetCellsRangeRowHeightRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: range,
                value: 10.9f,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeRowHeight(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetCellsRange of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetCellsRange()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetCellsRangeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:C6",
                shift: "Down",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetCellsRange(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetCellsRange of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetCellsRange()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetCellsRangeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:C6",
                shift: "Up",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetCellsRange(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetCellsRangeSort of RangesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetCellsRangeSort()
        {
            string localName = "Group.xlsx";
            string remoteName = "Group.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var rangeOperateDataSorter = new DataSorter()
            {
                CaseSensitive = true
            };
            var rangeOperateCellArea = new Range()
            {
                ColumnCount = 3,
                FirstColumn = 0,
                FirstRow = 0,
                RowCount = 15
            };
            var rangeOperate = new RangeSortRequest()
            {
                DataSorter = rangeOperateDataSorter,
                CellArea = rangeOperateCellArea
            };
            var request = new PostWorksheetCellsRangeSortRequest(
                name: remoteName,
                sheetName: "book1",
                rangeSortRequest: rangeOperate,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetCellsRangeSort(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
