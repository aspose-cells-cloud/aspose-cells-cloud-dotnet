// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="XmlControllerTests.cs">
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
    /// Test case of AutoFilterController.
    /// </summary>
    [TestClass]
    public class XmlControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostWorkbookExportXML of XmlController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookExportXML()
        {
            string localName = "Template.xlsx";
            string remoteName = "Template.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorkbookExportXMLRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookExportXML(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostWorkbookImortXML of XmlController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookImportXML()
        {
            string localName = "Template.xlsx";
            string dataXML = "data.xml";
            string remoteName = "Template.xlsx";

             this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( dataXML, remoteFolder + "/data.xml", "");

            var importXMLRequestXMLFileSource = new DataSource()
            {
                DataSourceType = "CloudFileSystem",
                DataPath = remoteFolder + "/data.xml"
            };
            var importXMLRequestImportPosition = new ImportPosition()
            {
                SheetName = "Sheet1",
                RowIndex = 3,
                ColumnIndex = 4
            };
            var importXMLRequest = new ImportXMLRequest()
            {
                XMLFileSource = importXMLRequestXMLFileSource,
                ImportPosition = importXMLRequestImportPosition
            };
            var request = new PostWorkbookImportXMLRequest(
                name: remoteName,
                importXMLRequest: importXMLRequest,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookImportXML(request);
            Assert.IsNotNull(actual);
        }
    }
}
