// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListObjectsControllerTests.cs">
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
    /// Test case of ListObjectsController.
    /// </summary>
    [TestClass]
    public class ListObjectsControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetListObjects of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetListObjects()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetListObjectsRequest(
                name: remoteName,
                sheetName: "Sheet7",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetListObjects(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetListObject of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetListObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetListObjectRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listobjectindex: 0,
                format: "pdf",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetListObject(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PutWorksheetListObject of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetListObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetListObjectRequest(
                name: remoteName,
                sheetName: "Sheet7",
                startRow: 1,
                startColumn: 1,
                endRow: 6,
                endColumn: 6,
                folder: remoteFolder,
                hasHeaders: true,
                displayName: "true",
                showTotals: false,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetListObject(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetListObjects of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetListObjects()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetListObjectsRequest(
                name: remoteName,
                sheetName: "Sheet7",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetListObjects(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetListObject of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetListObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetListObjectRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetListObject(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListObject of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var listObject = new ListObject()
            {
                ShowHeaderRow = true
            };
            var request = new PostWorksheetListObjectRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                listObject: listObject,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListObject(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListObjectConvertToRange of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListObjectConvertToRange()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetListObjectConvertToRangeRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListObjectConvertToRange(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListObjectSummarizeWithPivotTable of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListObjectSummarizeWithPivotTable()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var createPivotTableRequestPivotFieldColumns = new List<int?>()
            {
                2
            };
            var createPivotTableRequestPivotFieldData = new List<int?>()
            {
                1
            };
            var createPivotTableRequestPivotFieldRows = new List<int?>()
            {
                0
            };
            var createPivotTableRequest = new CreatePivotTableRequest()
            {
                DestCellName = "C1",
                Name = "testp",
                SourceData = "=Sheet2!A1:E8",
                UseSameSource = true,
                PivotFieldColumns = createPivotTableRequestPivotFieldColumns,
                PivotFieldData = createPivotTableRequestPivotFieldData,
                PivotFieldRows = createPivotTableRequestPivotFieldRows
            };
            var request = new PostWorksheetListObjectSummarizeWithPivotTableRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                destsheetName: "Sheet2",
                createPivotTableRequest: createPivotTableRequest,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListObjectSummarizeWithPivotTable(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListObjectSortTable of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListObjectSortTable()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dataSorter = new DataSorter()
            {
                CaseSensitive = true
            };
            var request = new PostWorksheetListObjectSortTableRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                dataSorter: dataSorter,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListObjectSortTable(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListColumn of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListColumn()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var listColumn = new ListColumn()
            {
                Name = "test cloumn"
            };
            var request = new PostWorksheetListColumnRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                columnIndex: 0,
                listColumn: listColumn,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListColumn(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetListColumnsTotal of ListObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetListColumnsTotal()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var tableTotalRequeststableTotalRequest0 = new TableTotalRequest()
            {
                ListColumnIndex = 1,
                TotalsCalculation = "Average"
            };
            var tableTotalRequests = new List<TableTotalRequest>()
            {
                tableTotalRequeststableTotalRequest0
            };
            var request = new PostWorksheetListColumnsTotalRequest(
                name: remoteName,
                sheetName: "Sheet7",
                listObjectIndex: 0,
                tableTotalRequests: tableTotalRequests,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetListColumnsTotal(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
