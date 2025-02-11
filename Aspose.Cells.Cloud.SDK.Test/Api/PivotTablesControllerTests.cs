// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotTablesControllerTests.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    /// Test case of PivotTablesController.
    /// </summary>
    [TestClass]
    public class PivotTablesControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetPivotTables of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetPivotTables()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetPivotTablesRequest(
                name: remoteName,
                sheetName: "Sheet4",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetPivotTables(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetPivotTable of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetPivotTable()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetPivotTableRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivottableIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetPivotTable(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetPivotTableField of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetPivotTableField()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetPivotTableFieldRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldIndex: 0,
                pivotFieldType: "Row",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetPivotTableField(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetPivotTableFilters of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetPivotTableFilters()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetPivotTableFiltersRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetPivotTableFilters(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetPivotTableFilter of PivotTablesController.
        /// </summary>
      //  [TestCategory(ProductName)]
      //  [TestMethod]
     //   public void TestGetWorksheetPivotTableFilter()
     //   {
      //      string localName = "TestCase.xlsx";
      //      string remoteName = "TestCase.xlsx";

      //      this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

        //    var request = new GetWorksheetPivotTableFilterRequest(
      //          name: remoteName,
       //         sheetName: "Sheet3",
        //        pivotTableIndex: 0,
        //        filterIndex: 0,
         //       folder: remoteFolder,
          //      storageName: ""
        //    );
         //   var actual =  this.CellsApi.GetWorksheetPivotTableFilter(request);
        //    Assert.AreEqual(200, actual.Code);
      //  }

        /// <summary>
        /// Test for PutWorksheetPivotTable of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetPivotTable()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetPivotTableRequest(
                name: remoteName,
                sheetName: "Sheet4",
                folder: remoteFolder,
                sourceData: "=Sheet1!C6:E13",
                destCellName: "C1",
                tableName: "TestPivot",
                useSameSource: true,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetPivotTable(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutPivotTableField of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutPivotTableField()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var pivotTableFieldRequestData = new List<int?>()
            {
                0
            };
            var pivotTableFieldRequest = new PivotTableFieldRequest()
            {
                Data = pivotTableFieldRequestData
            };
            var request = new PutPivotTableFieldRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldType: "Row",
                pivotTableFieldRequest: pivotTableFieldRequest,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutPivotTableField(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetPivotTableFilter of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetPivotTableFilter()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";
            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            Top10Filter top10Filter = new Top10Filter
            {
                Items = 1,
                IsTop = true,
                IsPercent = true
            };
            FilterColumn filterColumn = new FilterColumn
            {
                FilterType = "Top10Filter",
                FieldIndex = 0,
                Top10Filter = top10Filter
            };
            List<FilterColumn> filterColumns = new List<FilterColumn> { filterColumn };

            AutoFilter autoFilter = new AutoFilter
            {
                FilterColumns = filterColumns
            };
            var filter = new PivotFilter()
            {
                FieldIndex = 1,
                FilterType = "Count",
                AutoFilter = autoFilter

            };
            var request = new PutWorksheetPivotTableFilterRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                filter: filter,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetPivotTableFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableFieldHideItem of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableFieldHideItem()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostPivotTableFieldHideItemRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldType: "Row",
                fieldIndex: 0,
                itemIndex: 1,
                isHide: true,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableFieldHideItem(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableFieldMoveTo of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableFieldMoveTo()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostPivotTableFieldMoveToRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                fieldIndex: 0,
                from: "Row",
                to: "Column",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableFieldMoveTo(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableCellStyle of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableCellStyle()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostPivotTableCellStyleRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                column: 1,
                row: 1,
                style: style,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableCellStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableStyle of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableStyle()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var styleFont = new Font()
            {
                Size = 16
            };
            var style = new Style()
            {
                Font = styleFont
            };
            var request = new PostPivotTableStyleRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                style: style,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableUpdatePivotFields of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableUpdatePivotFields()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var pivotField = new PivotField()
            {
                ShowCompact = true
            };
            var request = new PostPivotTableUpdatePivotFieldsRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldType: "Row",
                pivotField: pivotField,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableUpdatePivotFields(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPivotTableUpdatePivotField of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPivotTableUpdatePivotField()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var pivotField = new PivotField()
            {
                ShowCompact = true
            };
            var request = new PostPivotTableUpdatePivotFieldRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldIndex: 0,
                pivotFieldType: "Row",
                pivotField: pivotField,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPivotTableUpdatePivotField(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetPivotTableCalculate of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetPivotTableCalculate()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetPivotTableCalculateRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetPivotTableCalculate(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetPivotTableMove of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetPivotTableMove()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetPivotTableMoveRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                row: 1,
                column: 1,
                destCellName: "C10",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetPivotTableMove(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetPivotTables of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetPivotTables()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetPivotTablesRequest(
                name: remoteName,
                sheetName: "Sheet4",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetPivotTables(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetPivotTable of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetPivotTable()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetPivotTableRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetPivotTable(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeletePivotTableField of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeletePivotTableField()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var pivotTableFieldRequestData = new List<int?>()
            {
                0
            };
            var pivotTableFieldRequest = new PivotTableFieldRequest()
            {
                Data = pivotTableFieldRequestData
            };
            var request = new DeletePivotTableFieldRequest(
                name: remoteName,
                sheetName: "Sheet4",
                pivotTableIndex: 0,
                pivotFieldType: "Row",
                pivotTableFieldRequest: pivotTableFieldRequest,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeletePivotTableField(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetPivotTableFilters of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetPivotTableFilters()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetPivotTableFiltersRequest(
                name: remoteName,
                sheetName: "Sheet3",
                pivotTableIndex: 0,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetPivotTableFilters(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetPivotTableFilter of PivotTablesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetPivotTableFilter()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetPivotTableFilterRequest(
                name: remoteName,
                sheetName: "Sheet3",
                pivotTableIndex: 0,
                fieldIndex: 0,
                needReCalculate: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetPivotTableFilter(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
