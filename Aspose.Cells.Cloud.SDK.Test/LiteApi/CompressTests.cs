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
    public class CompressTests : CellsBaseTest
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


        [TestCase(10)]
        [TestCase(90)]
        public void PostCompressApi_Test(int compressLevel)
        {
            if(IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            IDictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(BOOK1, GetTestDataStream(BOOK1));
            var filesResult = instance.PostCompress(files, compressLevel);
            Assert.IsInstanceOf<Model.FilesResult>(filesResult, "response is FilesResult");
        }

       
    }

}
