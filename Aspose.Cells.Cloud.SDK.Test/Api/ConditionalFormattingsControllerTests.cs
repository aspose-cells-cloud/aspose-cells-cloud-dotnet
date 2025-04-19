// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConditionalFormattingsControllerTests.cs">
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
    /// Test case of ConditionalFormattingsController.
    /// </summary>
    [TestClass]
    public class ConditionalFormattingsControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetConditionalFormattings of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetConditionalFormattings()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetConditionalFormattingsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetConditionalFormattings(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetConditionalFormatting of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetConditionalFormatting()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetConditionalFormattingRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetConditionalFormatting(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetConditionalFormatting of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetConditionalFormatting()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var formatcondition = new FormatCondition()
            {
                Type = "CellValue",
                Operator = "Between",
                Formula1 = "v1",
                Formula2 = "v2"
            };
            var request = new PutWorksheetConditionalFormattingRequest(
                name: remoteName,
                sheetName: "Sheet1",
                formatcondition: formatcondition,
                cellArea: "A1:C10",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetConditionalFormatting(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFormatCondition of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFormatCondition()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFormatConditionRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                cellArea: "A1:C10",
                type: "CellValue",
                operatorType: "Between",
                formula1: "v1",
                formula2: "v2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFormatCondition(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFormatConditionArea of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFormatConditionArea()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFormatConditionAreaRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                cellArea: "A1:C10",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFormatConditionArea(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetFormatConditionCondition of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetFormatConditionCondition()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetFormatConditionConditionRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                type: "CellValue",
                operatorType: "Between",
                formula1: "v1",
                formula2: "v2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetFormatConditionCondition(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetConditionalFormattings of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetConditionalFormattings()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetConditionalFormattingsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetConditionalFormattings(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetConditionalFormatting of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetConditionalFormatting()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetConditionalFormattingRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetConditionalFormatting(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetConditionalFormattingArea of ConditionalFormattingsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetConditionalFormattingArea()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetConditionalFormattingAreaRequest(
                name: remoteName,
                sheetName: "Sheet1",
                startRow: 1,
                startColumn: 1,
                totalRows: 4,
                totalColumns: 6,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetConditionalFormattingArea(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
