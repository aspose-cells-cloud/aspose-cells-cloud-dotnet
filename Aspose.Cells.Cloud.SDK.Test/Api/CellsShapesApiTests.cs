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
    ///  Class for testing CellsShapesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsShapesApiTests:CellsBaseTest
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
        /// Test CellsShapesDeleteWorksheetShape
        /// </summary>
        [Test]
        public void CellsShapesDeleteWorksheetShapeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? shapeindex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesDeleteWorksheetShape(name, sheetName, shapeindex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsShapesDeleteWorksheetShapes
        /// </summary>
        [Test]
        public void CellsShapesDeleteWorksheetShapesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesDeleteWorksheetShapes(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsShapesGetWorksheetShape
        /// </summary>
        [Test]
        public void CellsShapesGetWorksheetShapeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? shapeindex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesGetWorksheetShape(name, sheetName, shapeindex, folder);
            Assert.IsInstanceOf<ShapeResponse>(response, "response is ShapeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsShapesGetWorksheetShapes
        /// </summary>
        [Test]
        public void CellsShapesGetWorksheetShapesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesGetWorksheetShapes(name, sheetName, folder);
            Assert.IsInstanceOf<ShapesResponse>(response, "response is ShapesResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsShapesPostWorksheetShape
        /// </summary>
        [Test]
        public void CellsShapesPostWorksheetShapeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? shapeindex = 0;
            Shape dto = new Shape();
            dto.LowerRightColumn = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesPostWorksheetShape(name, sheetName, shapeindex, dto, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsShapesPutWorksheetShape
        /// </summary>
        [Test]
        public void CellsShapesPutWorksheetShapeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string drawingType = "button";
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? top = 10;
            int? left = 10;
            int? width = 100;
            int? height = 90;
            Shape shape = new Shape();
            shape.LowerRightRow = 10;
            shape.LowerRightColumn = 10;
            shape.Height = 100;
            shape.Width = 100;
            shape.MsoDrawingType = "button";

            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsShapesPutWorksheetShape(name, sheetName, shape, drawingType, upperLeftRow, upperLeftColumn, top, left, width, height,  folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is ShapeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
