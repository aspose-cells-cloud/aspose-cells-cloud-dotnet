// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConversionTests.cs">
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
    public class ConversionTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("csv","OutResult/PostExcelSaveAs.csv")]
        [DataRow("xls","OutResult/PostExcelSaveAs.xls")]
        [DataRow("html","OutResult/PostExcelSaveAs.html")]
        [DataRow("mhtml","OutResult/PostExcelSaveAs.mhtml")]
        [DataRow("ods","OutResult/PostExcelSaveAs.ods")]
        [DataRow("pdf","OutResult/PostExcelSaveAs.pdf")]
        [DataRow("xml","OutResult/PostExcelSaveAs.xml")]
        [DataRow("txt","OutResult/PostExcelSaveAs.txt")]
        [DataRow("tif","OutResult/PostExcelSaveAs.tif")]
        [DataRow("xlsb","OutResult/PostExcelSaveAs.xlsb")]
        [DataRow("xlsm","OutResult/PostExcelSaveAs.xlsm")]
        [DataRow("xlsx","OutResult/PostExcelSaveAs.xlsx")]
        [DataRow("xltm","OutResult/PostExcelSaveAs.xltm")]
        [DataRow("xltx","OutResult/PostExcelSaveAs.xltx")]
        [DataRow("xps","OutResult/PostExcelSaveAs.xps")]
        [DataRow("png","OutResult/PostExcelSaveAs.png")]
        [DataRow("md","OutResult/PostExcelSaveAs.md")]
        [DataRow("numbers","OutResult/PostExcelSaveAs.numbers")]
        [DataRow("svg","OutResult/PostExcelSaveAs.svg")]
        [DataRow("docx","OutResult/PostExcelSaveAs.docx")]
        [DataRow("pptx","OutResult/PostExcelSaveAs.pptx")]
        [DataRow("json","OutResult/PostExcelSaveAs.json")]
        [DataRow("sql","OutResult/PostExcelSaveAs.sql")]
        public void TestWorkbookSaveAs(string format,string newfilename)
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var saveOptions = new PdfSaveOptions()
            {
                SaveFormat = format
            };
            var request = new PostWorkbookSaveAsRequest(
                name: remoteName,
                newfilename: newfilename,
                saveOptions: saveOptions,
                folder: remoteFolder
            );
            var actual =  this.CellsApi.PostWorkbookSaveAs(request);
            Assert.AreEqual(200, actual.Code);
        }

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
        [DataRow("tif")]
        [DataRow("xlsb")]
        [DataRow("xps")]
        [DataRow("png")]
        [DataRow("md")]
        [DataRow("numbers")]
        [DataRow("wmf")]
        [DataRow("svg")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("sql")]
        public void TestGetWorkbookFormat(string format)
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookRequest(
                name: remoteName,
                format: format,
                folder: remoteFolder
            );
            var actual =  this.CellsApi.GetWorkbook(request);
            Assert.IsNotNull(actual);
        }

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
        [DataRow("tif")]
        [DataRow("xlsb")]
        [DataRow("xps")]
        [DataRow("png")]
        [DataRow("md")]
        [DataRow("numbers")]
        [DataRow("wmf")]
        [DataRow("svg")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("sql")]
        public void TestConvertWorkbook(string format)
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

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

        /// <summary>
        /// Test for converting workbook to one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("csv","OutResult/ConvertWorkbook.csv")]
        [DataRow("xls","OutResult/ConvertWorkbook.xls")]
        [DataRow("html","OutResult/ConvertWorkbook.html")]
        [DataRow("mhtml","OutResult/ConvertWorkbook.mhtml")]
        [DataRow("ods","OutResult/ConvertWorkbook.ods")]
        [DataRow("pdf","OutResult/ConvertWorkbook.pdf")]
        [DataRow("xml","OutResult/ConvertWorkbook.xml")]
        [DataRow("txt","OutResult/ConvertWorkbook.txt")]
        [DataRow("tif","OutResult/ConvertWorkbook.tif")]
        [DataRow("xlsb","OutResult/ConvertWorkbook.xlsb")]
        [DataRow("xlsm","OutResult/ConvertWorkbook.xlsm")]
        [DataRow("xlsx","OutResult/ConvertWorkbook.xlsx")]
        [DataRow("xltm","OutResult/ConvertWorkbook.xltm")]
        [DataRow("xltx","OutResult/ConvertWorkbook.xltx")]
        [DataRow("xps","OutResult/ConvertWorkbook.xps")]
        [DataRow("png","OutResult/ConvertWorkbook.png")]
        [DataRow("md","OutResult/ConvertWorkbook.md")]
        [DataRow("numbers","OutResult/ConvertWorkbook.numbers")]
        [DataRow("svg","OutResult/ConvertWorkbook.svg")]
        [DataRow("docx","OutResult/ConvertWorkbook.docx")]
        [DataRow("pptx","OutResult/ConvertWorkbook.pptx")]
        [DataRow("json","OutResult/ConvertWorkbook.json")]
        [DataRow("sql","OutResult/ConvertWorkbook.sql")]
        public void TestConvertWorkbookSaveCloud(string format,string outPath)
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(localName,mapFiles);       
            var request = new PutConvertWorkbookRequest(
                file: mapFiles,
                format: format,
                outPath: outPath
            );
            var actual =  this.CellsApi.PutConvertWorkbook(request);
            Assert.IsNotNull(actual);
        }
    }
}
