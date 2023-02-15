// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetupControllerTests.cs">
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
    /// Test case of PageSetupController.
    /// </summary>
    [TestClass]
    public class PageSetupControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetPageSetup of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetPageSetup()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetPageSetupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetPageSetup(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostPageSetup of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostPageSetup()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var pageSetup = new PageSetup()
            {
                BlackAndWhite = true,
                CenterHorizontally = true,
                CenterVertically = true
            };
            var request = new PostPageSetupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                pageSetup: pageSetup,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostPageSetup(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteHeaderFooter of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteHeaderFooter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteHeaderFooterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteHeaderFooter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetHeader of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetHeader()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetHeaderRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetHeader(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostHeader of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostHeader()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostHeaderRequest(
                name: remoteName,
                sheetName: "Sheet1",
                section: 1,
                script: "Update add header",
                isFirstPage: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostHeader(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetFooter of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetFooter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetFooterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetFooter(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostFooter of PageSetupController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostFooter()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostFooterRequest(
                name: remoteName,
                sheetName: "Sheet1",
                section: 1,
                script: "add footer script",
                isFirstPage: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostFooter(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
