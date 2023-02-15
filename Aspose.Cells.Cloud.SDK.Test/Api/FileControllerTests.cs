// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileControllerTests.cs">
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
    /// Test case of FileController.
    /// </summary>
    [TestClass]
    public class FileControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for DownloadFile of FileController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDownloadFile()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DownloadFileRequest(
                path: remoteFolder + "/" + remoteName,
                storageName: "",
                versionId: ""
            );
            var actual =  this.CellsApi.DownloadFile(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for UploadFile of FileController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestUploadFile()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(localName,mapFiles);       
            var request = new UploadFileRequest(
                uploadFiles: mapFiles,
                path: remoteFolder + "/" + remoteName,
                storageName: ""
            );
            var actual =  this.CellsApi.UploadFile(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for CopyFile of FileController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestCopyFile()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new CopyFileRequest(
                srcPath: remoteFolder + "/" + remoteName,
                destPath: "OutResult/" + remoteName,
                srcStorageName: "",
                destStorageName: "",
                versionId: ""
            );
         this.CellsApi.CopyFile(request);
        }

        /// <summary>
        /// Test for MoveFile of FileController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestMoveFile()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new MoveFileRequest(
                srcPath: remoteFolder + "/" + remoteName,
                destPath: "OutResult/" + remoteName,
                srcStorageName: "",
                destStorageName: "",
                versionId: ""
            );
         this.CellsApi.MoveFile(request);
        }

        /// <summary>
        /// Test for DeleteFile of FileController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteFile()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteFileRequest(
                path: remoteFolder + "/" + remoteName,
                storageName: "",
                versionId: ""
            );
         this.CellsApi.DeleteFile(request);
        }
    }
}
