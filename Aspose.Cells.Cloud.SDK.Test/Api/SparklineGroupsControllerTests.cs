// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SparklineGroupsControllerTests.cs">
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
    /// Test case of SparklineGroupsController.
    /// </summary>
    [TestClass]
    public class SparklineGroupsControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetWorksheetSparklineGroups of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetSparklineGroups()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetSparklineGroupsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetSparklineGroups(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorksheetSparklineGroup of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorksheetSparklineGroup()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorksheetSparklineGroupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                sparklineIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorksheetSparklineGroup(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetSparklineGroups of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetSparklineGroups()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetSparklineGroupsRequest(
                name: remoteName,
                sheetName: "Sheet1",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetSparklineGroups(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorksheetSparklineGroup of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorksheetSparklineGroup()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorksheetSparklineGroupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                sparklineIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorksheetSparklineGroup(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorksheetSparklineGroup of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorksheetSparklineGroup()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PutWorksheetSparklineGroupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                type: "Line",
                dataRange: "C6:E13",
                isVertical: false,
                locationRange: "G6:G13",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorksheetSparklineGroup(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorksheetSparklineGroup of SparklineGroupsController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorksheetSparklineGroup()
        {
            string localName = "TestCase.xlsx";
            string remoteName = "TestCase.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var sparklineGroup = new SparklineGroup()
            {
                DisplayHidden = true,
                PlotRightToLeft = true
            };
            var request = new PostWorksheetSparklineGroupRequest(
                name: remoteName,
                sheetName: "Sheet1",
                sparklineGroupIndex: 0,
                sparklineGroup: sparklineGroup,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorksheetSparklineGroup(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
