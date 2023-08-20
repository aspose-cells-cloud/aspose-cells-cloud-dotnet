// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LightCellsTests.cs">
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

namespace Aspose.Cells.Cloud.SDK.Tests.Api.Document
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    /// <summary>
    /// Test  of how to convert excel workbook to one of the available formats.
    /// </summary>
    [TestClass]
    public class LightCellsTests : CellsTestCommon
    {
        /// <summary>
        /// Test for save workbook as one of the available formats.
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
        public void TestPostSplit(string format)
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostSplitRequest(
                file: mapFiles,
                format: format
            );
            var actual =  this.CellsApi.PostSplit(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
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
        public void TestPostAssemble(string format)
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostAssembleRequest(
                file: mapFiles,
                datasource: "ds",
                format: format
            );
            var actual =  this.CellsApi.PostAssemble(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("csv","workbook")]
        [DataRow("xls","workbook")]
        [DataRow("html","workbook")]
        [DataRow("mhtml","workbook")]
        [DataRow("ods","workbook")]
        [DataRow("pdf","workbook")]
        [DataRow("xml","workbook")]
        [DataRow("txt","workbook")]
        [DataRow("tif","workbook")]
        [DataRow("xlsb","workbook")]
        [DataRow("xlsm","workbook")]
        [DataRow("xlsx","workbook")]
        [DataRow("xltm","workbook")]
        [DataRow("xltx","workbook")]
        [DataRow("xps","workbook")]
        [DataRow("png","workbook")]
        [DataRow("jpg","workbook")]
        [DataRow("gif","workbook")]
        [DataRow("emf","workbook")]
        [DataRow("bmp","workbook")]
        [DataRow("md","workbook")]
        [DataRow("numbers","workbook")]
        [DataRow("wmf","workbook")]
        [DataRow("svg","workbook")]
        [DataRow("docx","workbook")]
        [DataRow("pptx","workbook")]
        [DataRow("json","workbook")]
        [DataRow("sql","workbook")]
        [DataRow("csv","worksheet")]
        [DataRow("xls","worksheet")]
        [DataRow("html","worksheet")]
        [DataRow("mhtml","worksheet")]
        [DataRow("ods","worksheet")]
        [DataRow("pdf","worksheet")]
        [DataRow("xml","worksheet")]
        [DataRow("txt","worksheet")]
        [DataRow("tif","worksheet")]
        [DataRow("xlsb","worksheet")]
        [DataRow("xlsm","worksheet")]
        [DataRow("xlsx","worksheet")]
        [DataRow("xltm","worksheet")]
        [DataRow("xltx","worksheet")]
        [DataRow("xps","worksheet")]
        [DataRow("png","worksheet")]
        [DataRow("jpg","worksheet")]
        [DataRow("gif","worksheet")]
        [DataRow("emf","worksheet")]
        [DataRow("bmp","worksheet")]
        [DataRow("md","worksheet")]
        [DataRow("numbers","worksheet")]
        [DataRow("wmf","worksheet")]
        [DataRow("svg","worksheet")]
        [DataRow("docx","worksheet")]
        [DataRow("pptx","worksheet")]
        [DataRow("json","worksheet")]
        [DataRow("sql","worksheet")]
        [DataRow("pdf","chart")]
        [DataRow("tif","chart")]
        [DataRow("png","chart")]
        [DataRow("jpg","chart")]
        [DataRow("gif","chart")]
        [DataRow("emf","chart")]
        [DataRow("bmp","chart")]
        [DataRow("png","picture")]
        [DataRow("jpg","picture")]
        [DataRow("gif","picture")]
        [DataRow("emf","picture")]
        [DataRow("bmp","picture")]
        [DataRow("csv","listobject")]
        [DataRow("xls","listobject")]
        [DataRow("html","listobject")]
        [DataRow("mhtml","listobject")]
        [DataRow("ods","listobject")]
        [DataRow("pdf","listobject")]
        [DataRow("xml","listobject")]
        [DataRow("txt","listobject")]
        [DataRow("tif","listobject")]
        [DataRow("xlsb","listobject")]
        [DataRow("xlsm","listobject")]
        [DataRow("xlsx","listobject")]
        [DataRow("xltm","listobject")]
        [DataRow("xltx","listobject")]
        [DataRow("xps","listobject")]
        [DataRow("png","listobject")]
        [DataRow("jpg","listobject")]
        [DataRow("gif","listobject")]
        [DataRow("emf","listobject")]
        [DataRow("bmp","listobject")]
        [DataRow("md","listobject")]
        [DataRow("numbers","listobject")]
        [DataRow("wmf","listobject")]
        [DataRow("svg","listobject")]
        [DataRow("docx","listobject")]
        [DataRow("pptx","listobject")]
        [DataRow("json","listobject")]
        [DataRow("sql","listobject")]
        [DataRow("png","oleobject")]
        [DataRow("jpg","oleobject")]
        [DataRow("gif","oleobject")]
        [DataRow("emf","oleobject")]
        [DataRow("bmp","oleobject")]
        public void TestPostExport(string format,string objectType)
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new PostExportRequest(
                file: mapFiles,
                objectType: objectType,
                format: format
            );
            var actual =  this.CellsApi.PostExport(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow(50)]
        [DataRow(90)]
        public void TestPostCompress(int? compressLevel)
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostCompressRequest(
                file: mapFiles
            );
            var actual =  this.CellsApi.PostCompress(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("csv",true)]
        [DataRow("xls",true)]
        [DataRow("html",true)]
        [DataRow("mhtml",true)]
        [DataRow("ods",true)]
        [DataRow("pdf",true)]
        [DataRow("xml",true)]
        [DataRow("txt",true)]
        [DataRow("tif",true)]
        [DataRow("xlsb",true)]
        [DataRow("xlsm",true)]
        [DataRow("xlsx",true)]
        [DataRow("xltm",true)]
        [DataRow("xltx",true)]
        [DataRow("xps",true)]
        [DataRow("png",true)]
        [DataRow("jpg",true)]
        [DataRow("gif",true)]
        [DataRow("emf",true)]
        [DataRow("bmp",true)]
        [DataRow("md",true)]
        [DataRow("numbers",true)]
        [DataRow("wmf",true)]
        [DataRow("svg",true)]
        [DataRow("docx",false)]
        [DataRow("pptx",false)]
        [DataRow("json",false)]
        [DataRow("sql",false)]
        public void TestPostMerge(string format,bool? mergeToOneSheet)
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostMergeRequest(
                file: mapFiles,
                format: format,
                mergeToOneSheet: mergeToOneSheet
            );
            var actual =  this.CellsApi.PostMerge(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUnlock()
        {
            string needUnlockXlsx = "needUnlock.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(needUnlockXlsx,mapFiles);       
            var request = new PostUnlockRequest(
                file: mapFiles,
                password: "123456"
            );
            var actual =  this.CellsApi.PostUnlock(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostProtect()
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostProtectRequest(
                file: mapFiles,
                protectWorkbookRequst : new ProtectWorkbookRequst { AwaysOpenOnlyReady = true },
                password: "123456"
            );
            var actual =  this.CellsApi.PostProtect(request);
            Assert.IsNotNull(actual.Files);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostSearch()
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostSearchRequest(
                file: mapFiles,
                text: "12"
            );
            var actual =  this.CellsApi.PostSearch(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostReplace()
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostReplaceRequest(
                file: mapFiles,
                text: "12",
                newtext: "newtext"
            );
            var actual =  this.CellsApi.PostReplace(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostReplaceOnlySheetname()
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostReplaceRequest(
                file: mapFiles,
                text: "12",
                newtext: "newtext",
                sheetname: "Sheet1"
            );
            var actual =  this.CellsApi.PostReplace(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWatermark()
        {
            string assemblyTestXlsx = "assemblytest.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(assemblyTestXlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostWatermarkRequest(
                file: mapFiles,
                text: "aspose.cells cloud sdk",
                color: "#773322"
            );
            var actual =  this.CellsApi.PostWatermark(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("chart")]
        [DataRow("comment")]
        [DataRow("picture")]
        [DataRow("shape")]
        [DataRow("listobject")]
        [DataRow("hyperlink")]
        [DataRow("oleobject")]
        [DataRow("pivottable")]
        [DataRow("validation")]
        [DataRow("Background")]
        public void TestPostClearObjects(string objecttype)
        {
            string book1Xlsx = "Book1.xlsx";
            string dataSourceXlsx = "datasource.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(book1Xlsx,mapFiles);       
            AddFileParameter(dataSourceXlsx,mapFiles);       
            var request = new PostClearObjectsRequest(
                file: mapFiles,
                objecttype: objecttype
            );
            var actual =  this.CellsApi.PostClearObjects(request);
            Assert.IsNotNull(actual);
        }
        /// <summary>
        /// Test for repair workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("xlsx")]
        [DataRow("pdf")]
        [DataRow("csv")]
        [DataRow("png")]
        public void TestPostRepair(string format)
        {
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new PostRepairRequest(
                file: mapFiles,
                format: format
            );
            var actual =  this.CellsApi.PostRepair(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        [DataRow("rows","pdf")]
        [DataRow("cols","pdf")]
        [DataRow("both","pdf")]
        [DataRow("rows","csv")]
        [DataRow("cols","png")]
        [DataRow("both","xlsx")]
        public void TestPostReverse(string rotateType,string format)
        {
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new PostReverseRequest(
                file: mapFiles,
                rotateType: rotateType,
                format: format
            );
            var actual =  this.CellsApi.PostReverse(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetMetadata()
        {
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new GetMetadataRequest(
                file: mapFiles,
                type: "all"
            );
            var actual =  this.CellsApi.GetMetadata(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteMetadata()
        {
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new DeleteMetadataRequest(
                file: mapFiles,
                type: "all"
            );
            var actual =  this.CellsApi.DeleteMetadata(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for save workbook as one of the available formats.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostMetadata()
        {
            string book1Xlsx = "Book1.xlsx";

            System.Collections.Generic.IDictionary<string, System.IO.Stream> mapFiles =new System.Collections.Generic.Dictionary<string, System.IO.Stream>(); 
            var cellsDocumentscellsDocument0 = new CellsDocumentProperty()
            {
                Name = "Author",
                Value = "roy.wang"
            };
            var cellsDocuments = new List<CellsDocumentProperty>()
            {
                cellsDocumentscellsDocument0
            };
            AddFileParameter(book1Xlsx,mapFiles);       
            var request = new PostMetadataRequest(
                file: mapFiles,
                cellsDocuments: cellsDocuments
            );
            var actual =  this.CellsApi.PostMetadata(request);
            Assert.IsNotNull(actual);
        }
    }
}
