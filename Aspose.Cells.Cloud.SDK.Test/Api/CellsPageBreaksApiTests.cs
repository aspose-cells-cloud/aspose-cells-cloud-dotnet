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
    ///  Class for testing CellsPageBreaksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsPageBreaksApiTests:CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        
        /// <summary>
        /// Test CellsPageBreaksDeleteHorizontalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksDeleteHorizontalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksDeleteHorizontalPageBreak(name, sheetName, index, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksDeleteHorizontalPageBreaks
        /// </summary>
        [Test]
        public void CellsPageBreaksDeleteHorizontalPageBreaksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? row = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksDeleteHorizontalPageBreaks(name, sheetName, row, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksDeleteVerticalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksDeleteVerticalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksDeleteVerticalPageBreak(name, sheetName, index, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksDeleteVerticalPageBreaks
        /// </summary>
        [Test]
        public void CellsPageBreaksDeleteVerticalPageBreaksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? column = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksDeleteVerticalPageBreaks(name, sheetName, column, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksGetHorizontalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksGetHorizontalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksGetHorizontalPageBreak(name, sheetName, index, folder);
            Assert.IsInstanceOf<HorizontalPageBreakResponse>(response, "response is HorizontalPageBreakResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksGetHorizontalPageBreaks
        /// </summary>
        [Test]
        public void CellsPageBreaksGetHorizontalPageBreaksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksGetHorizontalPageBreaks(name, sheetName, folder);
            Assert.IsInstanceOf<HorizontalPageBreaksResponse>(response, "response is HorizontalPageBreaksResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksGetVerticalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksGetVerticalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksGetVerticalPageBreak(name, sheetName, index, folder);
            Assert.IsInstanceOf<VerticalPageBreakResponse>(response, "response is VerticalPageBreakResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksGetVerticalPageBreaks
        /// </summary>
        [Test]
        public void CellsPageBreaksGetVerticalPageBreaksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksGetVerticalPageBreaks(name, sheetName, folder);
            Assert.IsInstanceOf<VerticalPageBreaksResponse>(response, "response is VerticalPageBreaksResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksPutHorizontalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksPutHorizontalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellname = CellName;
            int? row = 1;
            int? column = 1;
            int? startColumn = 1;
            int? endColumn = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksPutHorizontalPageBreak(name, sheetName, cellname, row, column, startColumn, endColumn, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPageBreaksPutVerticalPageBreak
        /// </summary>
        [Test]
        public void CellsPageBreaksPutVerticalPageBreakTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellname = CellName;
            int? column = 1;
            int? row = 1;
            int? startRow = 1;
            int? endRow = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPageBreaksPutVerticalPageBreak(name, sheetName, cellname, column, row, startRow, endRow, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
