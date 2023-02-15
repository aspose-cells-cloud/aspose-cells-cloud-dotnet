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
        [DataRow("csv","DotNetSDK/OutResult/PostExcelSaveAs.csv")]
        [DataRow("xls","DotNetSDK/OutResult/PostExcelSaveAs.xls")]
        [DataRow("html","DotNetSDK/OutResult/PostExcelSaveAs.html")]
        [DataRow("mhtml","DotNetSDK/OutResult/PostExcelSaveAs.mhtml")]
        [DataRow("ods","DotNetSDK/OutResult/PostExcelSaveAs.ods")]
        [DataRow("pdf","DotNetSDK/OutResult/PostExcelSaveAs.pdf")]
        [DataRow("xml","DotNetSDK/OutResult/PostExcelSaveAs.xml")]
        [DataRow("txt","DotNetSDK/OutResult/PostExcelSaveAs.txt")]
        [DataRow("tif","DotNetSDK/OutResult/PostExcelSaveAs.tif")]
        [DataRow("xlsb","DotNetSDK/OutResult/PostExcelSaveAs.xlsb")]
        [DataRow("xlsm","DotNetSDK/OutResult/PostExcelSaveAs.xlsm")]
        [DataRow("xlsx","DotNetSDK/OutResult/PostExcelSaveAs.xlsx")]
        [DataRow("xltm","DotNetSDK/OutResult/PostExcelSaveAs.xltm")]
        [DataRow("xltx","DotNetSDK/OutResult/PostExcelSaveAs.xltx")]
        [DataRow("xps","DotNetSDK/OutResult/PostExcelSaveAs.xps")]
        [DataRow("png","DotNetSDK/OutResult/PostExcelSaveAs.png")]
        [DataRow("jpg","DotNetSDK/OutResult/PostExcelSaveAs.jpg")]
        [DataRow("gif","DotNetSDK/OutResult/PostExcelSaveAs.gif")]
        [DataRow("emf","DotNetSDK/OutResult/PostExcelSaveAs.emf")]
        [DataRow("bmp","DotNetSDK/OutResult/PostExcelSaveAs.bmp")]
        [DataRow("md","DotNetSDK/OutResult/PostExcelSaveAs.md")]
        [DataRow("numbers","DotNetSDK/OutResult/PostExcelSaveAs.numbers")]
        [DataRow("wmf","DotNetSDK/OutResult/PostExcelSaveAs.wmf")]
        [DataRow("svg","DotNetSDK/OutResult/PostExcelSaveAs.svg")]
        [DataRow("docx","DotNetSDK/OutResult/PostExcelSaveAs.docx")]
        [DataRow("pptx","DotNetSDK/OutResult/PostExcelSaveAs.pptx")]
        [DataRow("json","DotNetSDK/OutResult/PostExcelSaveAs.json")]
        [DataRow("sql","DotNetSDK/OutResult/PostExcelSaveAs.sql")]
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
        [DataRow("xlsm")]
        [DataRow("xlsx")]
        [DataRow("xltm")]
        [DataRow("xltx")]
        [DataRow("xps")]
        [DataRow("png")]
        [DataRow("jpg")]
        [DataRow("gif")]
        [DataRow("emf")]
        [DataRow("bmp")]
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
        [DataRow("xlsm")]
        [DataRow("xlsx")]
        [DataRow("xltm")]
        [DataRow("xltx")]
        [DataRow("xps")]
        [DataRow("png")]
        [DataRow("jpg")]
        [DataRow("gif")]
        [DataRow("emf")]
        [DataRow("bmp")]
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
        [DataRow("csv","DotNetSDK/OutResult/ConvertWorkbook.csv")]
        [DataRow("xls","DotNetSDK/OutResult/ConvertWorkbook.xls")]
        [DataRow("html","DotNetSDK/OutResult/ConvertWorkbook.html")]
        [DataRow("mhtml","DotNetSDK/OutResult/ConvertWorkbook.mhtml")]
        [DataRow("ods","DotNetSDK/OutResult/ConvertWorkbook.ods")]
        [DataRow("pdf","DotNetSDK/OutResult/ConvertWorkbook.pdf")]
        [DataRow("xml","DotNetSDK/OutResult/ConvertWorkbook.xml")]
        [DataRow("txt","DotNetSDK/OutResult/ConvertWorkbook.txt")]
        [DataRow("tif","DotNetSDK/OutResult/ConvertWorkbook.tif")]
        [DataRow("xlsb","DotNetSDK/OutResult/ConvertWorkbook.xlsb")]
        [DataRow("xlsm","DotNetSDK/OutResult/ConvertWorkbook.xlsm")]
        [DataRow("xlsx","DotNetSDK/OutResult/ConvertWorkbook.xlsx")]
        [DataRow("xltm","DotNetSDK/OutResult/ConvertWorkbook.xltm")]
        [DataRow("xltx","DotNetSDK/OutResult/ConvertWorkbook.xltx")]
        [DataRow("xps","DotNetSDK/OutResult/ConvertWorkbook.xps")]
        [DataRow("png","DotNetSDK/OutResult/ConvertWorkbook.png")]
        [DataRow("jpg","DotNetSDK/OutResult/ConvertWorkbook.jpg")]
        [DataRow("gif","DotNetSDK/OutResult/ConvertWorkbook.gif")]
        [DataRow("emf","DotNetSDK/OutResult/ConvertWorkbook.emf")]
        [DataRow("bmp","DotNetSDK/OutResult/ConvertWorkbook.bmp")]
        [DataRow("md","DotNetSDK/OutResult/ConvertWorkbook.md")]
        [DataRow("numbers","DotNetSDK/OutResult/ConvertWorkbook.numbers")]
        [DataRow("wmf","DotNetSDK/OutResult/ConvertWorkbook.wmf")]
        [DataRow("svg","DotNetSDK/OutResult/ConvertWorkbook.svg")]
        [DataRow("docx","DotNetSDK/OutResult/ConvertWorkbook.docx")]
        [DataRow("pptx","DotNetSDK/OutResult/ConvertWorkbook.pptx")]
        [DataRow("json","DotNetSDK/OutResult/ConvertWorkbook.json")]
        [DataRow("sql","DotNetSDK/OutResult/ConvertWorkbook.sql")]
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
