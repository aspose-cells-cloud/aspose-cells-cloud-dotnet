// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapesControllerTests.cs">
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
    /// Test case of ShapesController.
    /// </summary>
    [TestClass]
    public class ShapesControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetShapes of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetShapes()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetShapesRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetShapes(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetShapeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                shapeindex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetShape(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var shapeDTO = new Shape()
            {
            };
            var request = new PutWorksheetShapeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                shapeDTO: shapeDTO,
                drawingType: "arc",
                upperLeftRow: 1,
                upperLeftColumn: 1,
                top: 10,
                left: 10,
                width: 100,
                height: 100,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetShape(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetShapes of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetShapes()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetShapesRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetShapes(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetShapeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                shapeindex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetShape(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dto = new Shape()
            {
                LowerRightColumn = 10
            };
            var request = new PostWorksheetShapeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                shapeindex: 0,
                dto: dto,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetShape(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetGroupShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetGroupShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var listShape = new List<int?>()
            {
                0,
                1
            };
            var request = new PostWorksheetGroupShapeRequest(
                name: remoteName,
                sheetName: "Sheet6",
                listShape: listShape,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetGroupShape(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetUngroupShape of ShapesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetUngroupShape()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorksheetUngroupShapeRequest(
                name: remoteName,
                sheetName: "Sheet1",
                shapeindex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetUngroupShape(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
