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
    ///  Class for testing CellsWorksheetValidationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsWorksheetValidationsApiTests:CellsBaseTest
    {
        private CellsWorksheetValidationsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsWorksheetValidationsApi(GetConfiguration());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CellsWorksheetValidationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CellsWorksheetValidationsApi
            Assert.IsInstanceOf(typeof(CellsWorksheetValidationsApi), instance, "instance is a CellsWorksheetValidationsApi");
        }

        
        /// <summary>
        /// Test CellsWorksheetValidationsDeleteWorkSheetValidation
        /// </summary>
        [Test]
        public void CellsWorksheetValidationsDeleteWorkSheetValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? validationIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsDeleteWorksheetValidation(name, sheetName, validationIndex, folder);
            Assert.IsInstanceOf<ValidationResponse>(response, "response is ValidationResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsWorksheetValidationsGetWorkSheetValidation
        /// </summary>
        [Test]
        public void CellsWorksheetValidationsGetWorkSheetValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? validationIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsGetWorksheetValidation(name, sheetName, validationIndex, folder);
            Assert.IsInstanceOf<ValidationResponse>(response, "response is ValidationResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsWorksheetValidationsGetWorkSheetValidations
        /// </summary>
        [Test]
        public void CellsWorksheetValidationsGetWorkSheetValidationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsGetWorksheetValidations(name, sheetName, folder);
            Assert.IsInstanceOf<ValidationsResponse>(response, "response is ValidationsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsWorksheetValidationsPostWorkSheetValidation
        /// </summary>
        [Test]
        public void CellsWorksheetValidationsPostWorkSheetValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? validationIndex = 0;
            Validation validation = new Validation();
            validation.Formula1 = "=(OR(A1=\"Yes\",A1=\"No\"))";
            validation.Type = "Custom";
            validation.IgnoreBlank = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            UpdateDataFile(TEMPFOLDER, BOOK1);
            var response = instance.CellsWorksheetValidationsPostWorksheetValidation(name, sheetName, validationIndex, validation, folder);
            Assert.IsInstanceOf<ValidationResponse>(response, "response is ValidationResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsWorksheetValidationsPutWorkSheetValidation
        /// </summary>
        [Test]
        public void CellsWorksheetValidationsPutWorkSheetValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsPutWorksheetValidation(name, sheetName, range, folder);
            Assert.IsInstanceOf<ValidationResponse>(response, "response is ValidationResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
