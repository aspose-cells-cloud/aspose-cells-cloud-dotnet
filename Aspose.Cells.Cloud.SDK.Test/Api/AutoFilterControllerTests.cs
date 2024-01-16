// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AutoFilterControllerTests.cs">
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
    /// Test case of AutoFilterController.
    /// </summary>
    [TestClass]
    public class AutoFilterControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetAutoFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetAutoFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetAutoFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetAutoFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetDateFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetDateFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetDateFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                dateTimeGroupingType: "Year",
                year: 1920,
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetDateFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                criteria: "Year",
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetIconFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetIconFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetIconFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                iconSetType: "ArrowsGray3",
                iconId: 1,
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetIconFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetCustomFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetCustomFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetCustomFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                operatorType1: "LessOrEqual",
                criteria1: "1",
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetCustomFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetDynamicFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetDynamicFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetDynamicFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                dynamicFilterType: "BelowAverage",
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetDynamicFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFilterTop10 of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFilterTop10()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFilterTop10Request(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                isTop: true,
                isPercent: true,
                itemCount: 1,
                matchBlanks: false,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFilterTop10(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetColorFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetColorFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var colorFilterForegroundColorColor = new Color()
            {
                R = 48,
                G = 48,
                B = 48
            };
            var colorFilterForegroundColor = new CellsColor()
            {
                Type = "Automatic",
                Color = colorFilterForegroundColorColor
            };
            var colorFilter = new ColorFilterRequest()
            {
                Pattern = "Solid",
                ForegroundColor = colorFilterForegroundColor
            };
            var request = new PutWorksheetColorFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                range: "A1:B1",
                fieldIndex: 0,
                colorFilter: colorFilter,
                matchBlanks: true,
                refresh: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetColorFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetMatchBlanks of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetMatchBlanks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetMatchBlanksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                fieldIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetMatchBlanks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetMatchNonBlanks of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetMatchNonBlanks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetMatchNonBlanksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                fieldIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetMatchNonBlanks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetAutoFilterRefresh of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetAutoFilterRefresh()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetAutoFilterRefreshRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetAutoFilterRefresh(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetDateFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetDateFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetDateFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                fieldIndex: 0,
                dateTimeGroupingType: "Year",
                year: 1920,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetDateFilter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetFilter of AutoFilterController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetFilter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetFilterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                fieldIndex: 0,
                criteria: "year",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetFilter(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
