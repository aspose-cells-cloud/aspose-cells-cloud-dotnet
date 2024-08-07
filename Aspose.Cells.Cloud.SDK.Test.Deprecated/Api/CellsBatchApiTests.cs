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
using System.Net;

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
    public class CellsBatchApiTests : CellsBaseTest
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
        [TestCase("pdf")]
        [TestCase("png")]
        [TestCase("emf")]
        [TestCase("tiff")]
        [TestCase("docx")]
        [TestCase("svg")]
        public void CellsBatchApiTests_Convert(string format)
        {
            // TODO uncomment below to test the method and replace null with proper value
            if( instance.ObjectExists(OutPut).Exists.Value)
            {
                instance.DeleteFolder(OutPut,null,true);
            }
            instance.CreateFolder(OutPut);
            if (instance.ObjectExists(BatchFolder).Exists.Value)
            {
                instance.DeleteFolder(BatchFolder, null, true);
            }
            instance.CreateFolder(BatchFolder);
            UpdateDataFile(instance, BatchFolder, BOOK1);
            UpdateDataFile(instance, BatchFolder, MYDOC);
            UpdateDataFile(instance, BatchFolder, DataSource);
            UpdateDataFile(instance, BatchFolder, AssemblyTest);
            
            BatchConvertRequest batchConvertRequest = new BatchConvertRequest();
            batchConvertRequest.Format = format;
            batchConvertRequest.MatchCondition = new MatchConditionRequest();
            batchConvertRequest.MatchCondition.FullMatchConditions = new List<string> {"Book1.xlsx", "myDocument.xlsx" };
            batchConvertRequest.SourceFolder = BatchFolder;
            var response =  instance.PostBatchConvert(batchConvertRequest);
            Assert.IsInstanceOf<Stream>(response, "response is CellsCloudResponse");
            Download(response, "CellsBatchApiTests_Convert_"+format+".zip");
            
        }
        /// <summary>
        /// Test CellsSaveAsPostDocumentSaveAs
        /// </summary>
        [TestCase("pdf")]
        [TestCase("png")]
        [TestCase("emf")]
        [TestCase("tiff")]
        [TestCase("docx")]
        [TestCase("svg")]
        public void CellsBatchApiTests_Convert_outfolser(string format)
        {
            // TODO uncomment below to test the method and replace null with proper value
            if (instance.ObjectExists(OutPut).Exists.Value)
            {
                instance.DeleteFolder(OutPut, null, true);
            }
            instance.CreateFolder(OutPut);
            if (instance.ObjectExists(BatchFolder).Exists.Value)
            {
                instance.DeleteFolder(BatchFolder, null, true);
            }
            instance.CreateFolder(BatchFolder);
            UpdateDataFile(instance, BatchFolder, BOOK1);
            UpdateDataFile(instance, BatchFolder, MYDOC);
            UpdateDataFile(instance, BatchFolder, DataSource);
            UpdateDataFile(instance, BatchFolder, AssemblyTest);

            BatchConvertRequest batchConvertRequest = new BatchConvertRequest();
            batchConvertRequest.Format = format;
            batchConvertRequest.MatchCondition = new MatchConditionRequest();
            batchConvertRequest.MatchCondition.FullMatchConditions = new List<string> { "Book1.xlsx", "myDocument.xlsx" };
            batchConvertRequest.SourceFolder = BatchFolder;
            batchConvertRequest.OutFolder = OutPut;
            var response = instance.PostBatchConvert(batchConvertRequest);
            Assert.IsInstanceOf<Stream>(response, "response is CellsCloudResponse");
            CellsCloudResponse cellsCloudResponse = ToCellsCloudResponse(response);
            Assert.AreEqual(cellsCloudResponse.Code, 200);

        }

    }

}
