// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartAreaControllerTests.cs">
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
    /// Test case of ChartAreaController.
    /// </summary>
    [TestClass]
    public class ChartAreaControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for GetChartArea of ChartAreaController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetChartArea()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetChartAreaRequest(
                name: remoteName,
                sheetName: "Sheet4",
                chartIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetChartArea(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetChartAreaFillFormat of ChartAreaController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetChartAreaFillFormat()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetChartAreaFillFormatRequest(
                name: remoteName,
                sheetName: "Sheet4",
                chartIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetChartAreaFillFormat(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetChartAreaBorder of ChartAreaController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetChartAreaBorder()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetChartAreaBorderRequest(
                name: remoteName,
                sheetName: "Sheet4",
                chartIndex: 0,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetChartAreaBorder(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}
