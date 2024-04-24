// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsStatusControllerTests.cs">
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
    /// Test case of CellsStatusController.
    /// </summary>
    [TestClass]
    public class CellsStatusControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetCellsCloudServicesHealthCheck of CellsStatusController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetCellsCloudServicesHealthCheck()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetCellsCloudServicesHealthCheckRequest(
            );
            var actual =  this.CellsApi.GetCellsCloudServicesHealthCheck(request);
            Assert.AreEqual("{\"Status\":\"Cells Cloud(v24.1.0) is working fine!\"}", actual);
        }

        /// <summary>
        /// Test for GetCellsCloudServiceStatus of CellsStatusController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetCellsCloudServiceStatus()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetCellsCloudServiceStatusRequest(
            );
            var actual =  this.CellsApi.GetCellsCloudServiceStatus(request);
            Assert.AreEqual("OK", actual);
        }
    }
}
