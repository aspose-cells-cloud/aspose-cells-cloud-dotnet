// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PropertiesControllerTests.cs">
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
    /// Test case of PropertiesController.
    /// </summary>
    [TestClass]
    public class PropertiesControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetDocumentProperties of PropertiesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetDocumentProperties()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetDocumentPropertiesRequest(
                name: remoteName,
                type: "All",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetDocumentProperties(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetDocumentProperty of PropertiesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetDocumentProperty()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetDocumentPropertyRequest(
                name: remoteName,
                propertyName: "Author",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetDocumentProperty(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutDocumentProperty of PropertiesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutDocumentProperty()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var property = new CellsDocumentProperty()
            {
                Name = "Author",
                Value = "cells developer"
            };
            var request = new PutDocumentPropertyRequest(
                name: remoteName,
                property: property,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutDocumentProperty(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteDocumentProperty of PropertiesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteDocumentProperty()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteDocumentPropertyRequest(
                name: remoteName,
                propertyName: "Author",
                type: "All",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteDocumentProperty(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteDocumentProperties of PropertiesController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteDocumentProperties()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteDocumentPropertiesRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteDocumentProperties(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
