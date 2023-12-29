// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConversionJsonTests.cs">
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

namespace Aspose.Cells.Cloud.SDK.Tests.Api.Conversion
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    /// <summary>
    /// Test  of how to convert excel workbook to one of the available formats.
    /// </summary>
    [TestClass]
    public class ConversionJsonTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for get workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("csv")]
        [DataRow("xls")]
        [DataRow("html")]
        [DataRow("mhtml")]
        [DataRow("ods")]
        [DataRow("pdf")]
        [DataRow("xml")]
        [DataRow("txt")]
        [DataRow("xlsb")]
        [DataRow("xps")]
        [DataRow("md")]
        [DataRow("numbers")]
        [DataRow("svg")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("sql")]
        public void TestConvertWorkbook(string format)
        {
            string localName = "codegen-spec.json";
            string remoteName = "codegen-spec.json";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(localName,mapFiles);       
            var request = new PutConvertWorkbookRequest(
                file: mapFiles,
                format: format
            );
            var actual =  this.CellsApi.PutConvertWorkbook(request);
            Assert.IsNotNull(actual);
        }
    }
}
