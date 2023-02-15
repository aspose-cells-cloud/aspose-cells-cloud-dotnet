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

namespace Aspose.Cells.Cloud.SDK.Test.LiteApi
{
    /// <summary>
    ///  Class for testing OAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImportTests : CellsBaseTest
    {
        private ILightCellsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LightCellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }
        
        [Test]
        public void PostImportApi_intarray()
        { 
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(BOOK1, GetTestDataStream( BOOK1));
            files.Add(MYDOC, GetTestDataStream(MYDOC));
            ImportIntArrayOption data = new ImportIntArrayOption();
            data.DestinationWorksheet = SHEET1;
            data.FirstColumn = 1;
            data.FirstRow = 3;
            data.ImportDataType = "IntArray";
            data.IsVertical = true;
            data.Data = new List<int?> { 1, 2, 3, 4 };
            var filesResult = instance.PostImport(files, data);
            Assert.IsInstanceOf<FilesResult>(filesResult, "response is AccessTokenResponse");
        }

        [Test]
        public void PostImportApi_stringarray()
        {
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(BOOK1, GetTestDataStream(BOOK1));
            files.Add(MYDOC, GetTestDataStream(MYDOC));
            ImportIntArrayOption data = new ImportIntArrayOption();
            data.DestinationWorksheet = SHEET1;
            data.FirstColumn = 1;
            data.FirstRow = 3;
            data.ImportDataType = "StringArray";
            data.IsVertical = true;
            data.Data = new List<int?> { 1, 2, 3, 4 };
            var filesResult = instance.PostImport(files, data);
            Assert.IsInstanceOf<FilesResult>(filesResult, "response is AccessTokenResponse");
        }

        [Test]
        public void PostImportApi_picture()
        {
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(BOOK1, GetTestDataStream(BOOK1));
            files.Add(MYDOC, GetTestDataStream(MYDOC));
            ImportPictureOption data = new ImportPictureOption();
            data.DestinationWorksheet = SHEET1;
            data.LowerRightColumn = 21;
            data.LowerRightRow = 23;
            data.UpperLeftColumn = 10;
            data.UpperLeftRow = 13;
            data.ImportDataType = "Picture";
            data.Data = GetTestDataBase64String("WaterMark.png");
            var filesResult = instance.PostImport(files, data);
            Assert.IsInstanceOf<FilesResult>(filesResult, "response is AccessTokenResponse");
        }
    }

}