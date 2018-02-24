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
    ///  Class for testing CellsOleObjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsOleObjectsApiTests : CellsBaseTest
    {
        private CellsOleObjectsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsOleObjectsApi(GetConfiguration ());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CellsOleObjectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CellsOleObjectsApi
            Assert.IsInstanceOf(typeof(CellsOleObjectsApi), instance, "instance is a CellsOleObjectsApi");
        }

        
        /// <summary>
        /// Test CellsOleObjectsDeleteWorksheetOleObject
        /// </summary>
        [Test]
        public void CellsOleObjectsDeleteWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? oleObjectIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsDeleteWorksheetOleObject(name, sheetName, oleObjectIndex, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsOleObjectsDeleteWorksheetOleObjects
        /// </summary>
        [Test]
        public void CellsOleObjectsDeleteWorksheetOleObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsDeleteWorksheetOleObjects(name, sheetName, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsOleObjectsGetWorksheetOleObject
        /// </summary>
        [Test]
        public void CellsOleObjectsGetWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? objectNumber = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsGetWorksheetOleObject(name, sheetName, objectNumber, folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }

        /// <summary>
        /// Test CellsOleObjectsGetWorksheetOleObjects
        /// </summary>
        [Test]
        public void CellsOleObjectsGetWorksheetOleObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsGetWorksheetOleObjects(name, sheetName, folder);
            Assert.IsInstanceOf<OleObjectsResponse>(response, "response is OleObjectsResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsOleObjectsPostUpdateWorksheetOleObject
        /// </summary>
        [Test]
        public void CellsOleObjectsPostUpdateWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? oleObjectIndex = 0;
            OleObject ole = new OleObject();
            ole.Left = 10;
            ole.Right = 10;
            ole.Height = 90;
            ole.Width = 78;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsPostUpdateWorksheetOleObject(name, sheetName, oleObjectIndex, ole, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsOleObjectsPutWorksheetOleObject
        /// </summary>
        [Test]
        public void CellsOleObjectsPutWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            OleObject oleObject = null;
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? height = 100;
            int? width = 80;
            string oleFile = "OLEDoc.docx";
            string imageFile = "word.jpg";
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            UpdateDataFile(folder, oleFile);
            UpdateDataFile(folder, imageFile);
            var response = instance.CellsOleObjectsPutWorksheetOleObject(name, sheetName, oleObject, upperLeftRow, upperLeftColumn, height, width, folder +"/"+ oleFile, folder + "/" + imageFile, folder);
            Assert.IsInstanceOf<OleObjectResponse>(response, "response is OleObjectResponse");
            Assert.AreEqual(response.Code, 200);
        }

    }

}
