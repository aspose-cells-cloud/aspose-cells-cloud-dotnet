/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsSaveAsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsSaveAsApiTests:CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        
        /// <summary>
        /// Test CellsSaveAsPostDocumentSaveAs
        /// </summary>
        [Test]
        public void CellsSaveAsPostDocumentSaveAsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            SaveOptions saveOptions = null;
            string newfilename = "newbook.xlsx";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Assert.IsInstanceOf<SaveResponse>(response, "response is SaveResponse");
        }
        /// <summary>
        /// Test CellsSaveAsPostDocumentSaveAs
        /// </summary>
        [Test]
        public void CellsSaveAsPostDocumentSaveAsPDFTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            PdfSaveOptions saveOptions = new PdfSaveOptions();
            saveOptions.OnePagePerSheet = true;
            saveOptions.SaveFormat = "pdf";
            string newfilename = "newbook.pdf";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Assert.IsInstanceOf<SaveResponse>(response, "response is SaveResponse");
        }
        /// <summary>
        /// Test CellsSaveAsPostDocumentSaveAs
        /// </summary>
        [Test]
        public void CellsSaveAsPostDocumentSaveAsMDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            MarkdownSaveOptions saveOptions = new MarkdownSaveOptions();
            saveOptions.SaveFormat = "markdown";
            string newfilename = "newbook.md";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = TEMPFOLDER;
            //UpdateDataFile(instance,folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Assert.IsInstanceOf<SaveResponse>(response, "response is SaveResponse");
        }
        /// <summary>
        /// Test CellsSaveAsPostDocumentSaveAs
        /// </summary>
        [Test]
        public void CellsSaveAsPostDocumentSaveAsHTMLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            HtmlSaveOptions saveOptions = new HtmlSaveOptions();
            saveOptions.SaveFormat = "html";
            string newfilename = "newbook.html";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = TEMPFOLDER;
            //UpdateDataFile(instance,folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Assert.IsInstanceOf<SaveResponse>(response, "response is SaveResponse");
        }
    }

}
