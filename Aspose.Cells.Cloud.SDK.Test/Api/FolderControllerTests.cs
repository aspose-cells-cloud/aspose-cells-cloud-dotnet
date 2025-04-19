// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderControllerTests.cs">
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
    /// Test case of FolderController.
    /// </summary>
    [TestClass]
    public class FolderControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetFilesList of FolderController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetFilesList()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetFilesListRequest(
                path: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetFilesList(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for CreateFolder of FolderController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestCreateFolder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new CreateFolderRequest(
                path: "OutResult/NewFolder",
                storageName: ""
            );
         this.CellsApi.CreateFolder(request);
        }

        /// <summary>
        /// Test for CopyFolder of FolderController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestCopyFolder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new CopyFolderRequest(
                srcPath: remoteFolder,
                destPath: "OutResult/Create",
                srcStorageName: "",
                destStorageName: ""
            );
         this.CellsApi.CopyFolder(request);
        }

        /// <summary>
        /// Test for MoveFolder of FolderController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestMoveFolder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new MoveFolderRequest(
                srcPath: "OutResult/Create",
                destPath: "OutResult/Move",
                srcStorageName: "",
                destStorageName: ""
            );
         this.CellsApi.MoveFolder(request);
        }

        /// <summary>
        /// Test for DeleteFolder of FolderController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteFolder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteFolderRequest(
                path: "OutResult/Create",
                storageName: "",
                recursive: true
            );
         this.CellsApi.DeleteFolder(request);
        }
    }
}
