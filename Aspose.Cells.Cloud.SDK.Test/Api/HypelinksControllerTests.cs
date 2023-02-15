// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HypelinksControllerTests.cs">
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
    /// Test case of HypelinksController.
    /// </summary>
    [TestClass]
    public class HypelinksControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorkSheetHyperlinks of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkSheetHyperlinks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkSheetHyperlinksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkSheetHyperlinks(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkSheetHyperlink of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkSheetHyperlink()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkSheetHyperlinkRequest(
                name: remoteName,
                sheetName: "Sheet1",
                hyperlinkIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkSheetHyperlink(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorkSheetHyperlink of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorkSheetHyperlink()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorkSheetHyperlinkRequest(
                name: remoteName,
                sheetName: "Sheet1",
                hyperlinkIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorkSheetHyperlink(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkSheetHyperlink of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkSheetHyperlink()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var hyperlink = new Hyperlink()
            {
                Address = "https://products.aspose.cloud/cells/"
            };
            var request = new PostWorkSheetHyperlinkRequest(
                name: remoteName,
                sheetName: "Sheet1",
                hyperlinkIndex: 0,
                hyperlink: hyperlink,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkSheetHyperlink(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorkSheetHyperlink of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorkSheetHyperlink()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorkSheetHyperlinkRequest(
                name: remoteName,
                sheetName: "Sheet1",
                firstRow: 1,
                firstColumn: 1,
                totalRows: 2,
                totalColumns: 3,
                address: "https://products.aspose.cloud/cells/",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorkSheetHyperlink(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorkSheetHyperlinks of HypelinksController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorkSheetHyperlinks()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorkSheetHyperlinksRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorkSheetHyperlinks(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
