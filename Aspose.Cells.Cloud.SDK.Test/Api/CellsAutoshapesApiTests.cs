/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsAutoshapesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsAutoshapesApiTests :CellsBaseTest
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
        /// Test CellsAutoshapesGetWorksheetAutoshape
        /// </summary>
        [Test]
        public void CellsAutoshapesGetWorksheetAutoshapeTest()
        {
            if(IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET2;
            int? autoshapeNumber = 4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshape(name, sheetName, autoshapeNumber, "PNG", folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        /// <summary>
        /// Test CellsAutoshapesGetWorksheetAutoshape
        /// </summary>
        [Test]
        public void CellsAutoshapesGetWorksheetAutoshapeDTOTest()
        {
            if (IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET2;
            int? autoshapeNumber = 4;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshape(name, sheetName, autoshapeNumber, null, folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        /// <summary>
        /// Test CellsAutoshapesGetWorksheetAutoshapes
        /// </summary>
        [Test]
        public void CellsAutoshapesGetWorksheetAutoshapesTest()
        {
            if (IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET2;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshapes(name, sheetName, folder);
            Assert.IsInstanceOf<AutoShapesResponse>(response, "response is AutoShapesResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
