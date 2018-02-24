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
    ///  Class for testing CellsPicturesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsPicturesApiTests:CellsBaseTest
    {
        private CellsPicturesApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsPicturesApi(GetConfiguration());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CellsPicturesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CellsPicturesApi
            Assert.IsInstanceOf(typeof(CellsPicturesApi), instance, "instance is a CellsPicturesApi");
        }

        
        /// <summary>
        /// Test CellsPicturesDeleteWorkSheetPictures
        /// </summary>
        [Test]
        public void CellsPicturesDeleteWorkSheetPicturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsPicturesDeleteWorksheetPictures(name, sheetName, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPicturesDeleteWorksheetPicture
        /// </summary>
        [Test]
        public void CellsPicturesDeleteWorksheetPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? pictureIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsPicturesDeleteWorksheetPicture(name, sheetName, pictureIndex, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPicturesGetWorksheetPicture
        /// </summary>
        [Test]
        public void CellsPicturesGetWorksheetPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? pictureNumber = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsPicturesGetWorksheetPicture(name, sheetName, pictureNumber, folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CellsPicturesGetWorksheetPictures
        /// </summary>
        [Test]
        public void CellsPicturesGetWorksheetPicturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsPicturesGetWorksheetPictures(name, sheetName, folder);
            Assert.IsInstanceOf<PicturesResponse>(response, "response is PicturesResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsPicturesPostWorkSheetPicture
        /// </summary>
        [Test]
        public void CellsPicturesPostWorkSheetPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            int? pictureIndex = 0;
            Picture picture = new Picture ();
            picture.Left = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsPicturesPostWorksheetPicture(name, sheetName, pictureIndex, picture, folder);
            Assert.IsInstanceOf<PictureResponse>(response, "response is PictureResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsPicturesPutWorksheetAddPicture
        /// </summary>
        [Test]
        public void CellsPicturesPutWorksheetAddPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            Picture picture =null;
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? lowerRightRow = 10;
            int? lowerRightColumn = 10;
            string picturePath = "WaterMark.png";
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            UpdateDataFile(folder, picturePath);
            var response = instance.CellsPicturesPutWorksheetAddPicture(name, sheetName,picture, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, folder + "/" + picturePath, folder);
            Assert.IsInstanceOf<PicturesResponse>(response, "response is PicturesResponse");
            Assert.AreEqual(response.Code, 200);

        }

    }

}
