// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageBreaksControllerTests.cs">
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
    /// Test case of PageBreaksController.
    /// </summary>
    [TestClass]
    public class PageBreaksControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetVerticalPageBreaks of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetVerticalPageBreaks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetVerticalPageBreaksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetVerticalPageBreaks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetHorizontalPageBreaks of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetHorizontalPageBreaks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetHorizontalPageBreaksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetHorizontalPageBreaks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetVerticalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetVerticalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetVerticalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetVerticalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetHorizontalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetHorizontalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetHorizontalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetHorizontalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutVerticalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutVerticalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutVerticalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellname: "A1",
                column: 1,
                row: 1,
                startRow: 1,
                endRow: 1,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutVerticalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutHorizontalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutHorizontalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutHorizontalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                cellname: "A1",
                row: 1,
                column: 1,
                startColumn: 1,
                endColumn: 1,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutHorizontalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteVerticalPageBreaks of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteVerticalPageBreaks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteVerticalPageBreaksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                column: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteVerticalPageBreaks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteHorizontalPageBreaks of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteHorizontalPageBreaks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteHorizontalPageBreaksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                row: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteHorizontalPageBreaks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteVerticalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteVerticalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteVerticalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteVerticalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteHorizontalPageBreak of PageBreaksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteHorizontalPageBreak()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteHorizontalPageBreakRequest(
                name: remoteName,
                sheetName: "Sheet1",
                index: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteHorizontalPageBreak(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
