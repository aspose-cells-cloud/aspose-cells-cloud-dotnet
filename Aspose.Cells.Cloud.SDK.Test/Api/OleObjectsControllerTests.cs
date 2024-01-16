// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OleObjectsControllerTests.cs">
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
    /// Test case of OleObjectsController.
    /// </summary>
    [TestClass]
    public class OleObjectsControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetOleObjects of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetOleObjects()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetOleObjectsRequest(
                name: remoteName,
                sheetName: "Sheet6",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetOleObjects(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetOleObject of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetOleObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetOleObjectRequest(
                name: remoteName,
                sheetName: "Sheet6",
                objectNumber: 0,
                format: "png",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetOleObject(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for DeleteWorksheetOleObjects of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetOleObjects()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetOleObjectsRequest(
                name: remoteName,
                sheetName: "Sheet6",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetOleObjects(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetOleObject of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetOleObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetOleObjectRequest(
                name: remoteName,
                sheetName: "Sheet6",
                oleObjectIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetOleObject(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostUpdateWorksheetOleObject of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWorksheetOleObject()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var ole = new OleObject()
            {
                Left = 10,
                Right = 10,
                Height = 90,
                Width = 78
            };
            var request = new PostUpdateWorksheetOleObjectRequest(
                name: remoteName,
                sheetName: "Sheet6",
                oleObjectIndex: 0,
                ole: ole,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostUpdateWorksheetOleObject(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetOleObject of OleObjectsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetOleObject()
        {
            string localName = "Book1.xlsx";
            string oLEDoc = "OLEDoc.docx";
            string wordJPG = "word.jpg";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( oLEDoc, "OLEDoc.docx", "");
            this.UploadFile( wordJPG, "word.jpg", "");

            var request = new PutWorksheetOleObjectRequest(
                name: remoteName,
                sheetName: "Sheet6",
                upperLeftRow: 1,
                upperLeftColumn: 1,
                height: 100,
                width: 80,
                oleFile: "OLEDoc.docx",
                imageFile: "word.jpg",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetOleObject(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
