﻿/* 
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
    public class MetadataTests : CellsBaseTest
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

        /// <summary>
        /// Test OAuthPost
        /// </summary>
        [Test]
        public void MetadataApisTest_Updata()
        {
            if (IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(DataSource, GetTestDataStream(DataSource));
            files.Add(AssemblyTest, GetTestDataStream(AssemblyTest));
            var cellsDocumentProperties = instance.GetMetadata(files, null);
            Assert.IsInstanceOf<IList<CellsDocumentProperty>>(cellsDocumentProperties, "response is IList<CellsDocumentProperty>");
            CellsDocumentProperty cellsDocumentProperty = new CellsDocumentProperty();
            cellsDocumentProperty.Name = "Title";
            cellsDocumentProperty.Value = "Aspose.Cells Cloud";
            List<CellsDocumentProperty> listCellsDocumentProperty = new List<CellsDocumentProperty>();
            listCellsDocumentProperty.Add(cellsDocumentProperty);
            files.Clear();
            files.Add(DataSource, GetTestDataStream(DataSource));
            files.Add(AssemblyTest, GetTestDataStream(AssemblyTest));
            var filesResult = instance.PostMetadata(files, listCellsDocumentProperty);
            Assert.IsInstanceOf<FilesResult>(filesResult, "response is FilesResult");
            
        }

        [Test]
        public void MetadataApisTest_Delete()
        {
            if (IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
       
            files.Add(DataSource, GetTestDataStream(DataSource));
            files.Add(AssemblyTest, GetTestDataStream(AssemblyTest));
            var filesResult = instance.DeleteMetadata(files);
            Assert.IsInstanceOf<FilesResult>(filesResult, "response is FilesResult");

        }
    }
}
