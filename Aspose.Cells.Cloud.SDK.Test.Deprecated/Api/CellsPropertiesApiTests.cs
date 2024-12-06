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
    ///  Class for testing CellsPropertiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsPropertiesApiTests:CellsBaseTest
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
        /// Test CellsPropertiesDeleteDocumentProperties
        /// </summary>
        [Test]
        public void CellsPropertiesDeleteDocumentPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPropertiesDeleteDocumentProperties(name, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsDocumentPropertiesResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPropertiesDeleteDocumentProperty
        /// </summary>
        [Test]
        public void CellsPropertiesDeleteDocumentPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string propertyName = "Author";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPropertiesDeleteDocumentProperty(name, propertyName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsDocumentPropertiesResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPropertiesGetDocumentProperties
        /// </summary>
        [Test]
        public void CellsPropertiesGetDocumentPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPropertiesGetDocumentProperties(name, folder);
            Assert.IsInstanceOf<CellsDocumentPropertiesResponse>(response, "response is CellsDocumentPropertiesResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPropertiesGetDocumentProperty
        /// </summary>
        [Test]
        public void CellsPropertiesGetDocumentPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string propertyName = "Author";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPropertiesGetDocumentProperty(name, propertyName, folder);
            Assert.IsInstanceOf<CellsDocumentPropertyResponse>(response, "response is CellsDocumentPropertyResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsPropertiesPutDocumentProperty
        /// </summary>
        [Test]
        public void CellsPropertiesPutDocumentPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string propertyName = "Name";
            CellsDocumentProperty property = new CellsDocumentProperty();
            //(null, "Author", "Val"
            property.Name = "Author";
            property.Value = "Val";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsPropertiesPutDocumentProperty(name, propertyName, property, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsDocumentPropertyResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
