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
    ///  Class for testing CellsAutoFilterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture] 
    public class CellsAutoFilterApiTests :CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = IsDockerTest ? new CellsApi(testbaseurl) : new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

       
        /// <summary>
        /// Test CellsAutoFilterDeleteWorksheetDateFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterDeleteWorksheetDateFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? fieldIndex = 1;
            string dateTimeGroupingType = "Day";
            int? year = 2010;
            int? month = 10;
            int? day = 1;
            int? hour = 1;
            int? minute = 1;
            int? second = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterDeleteWorksheetDateFilter(name, sheetName, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterDeleteWorksheetFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterDeleteWorksheetFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? fieldIndex = 1;
            string criteria = "test";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterDeleteWorksheetFilter(name, sheetName, fieldIndex, criteria, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterGetWorksheetAutoFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterGetWorksheetAutoFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterGetWorksheetAutoFilter(name, sheetName, folder);
            Assert.IsInstanceOf<AutoFilterResponse>(response, "response is AutoFilterResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPostWorksheetAutoFilterRefresh
        /// </summary>
        [Test]
        public void CellsAutoFilterPostWorksheetAutoFilterRefreshTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPostWorksheetAutoFilterRefresh(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPostWorksheetMatchBlanks
        /// </summary>
        [Test]
        public void CellsAutoFilterPostWorksheetMatchBlanksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? fieldIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPostWorksheetMatchBlanks(name, sheetName, fieldIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPostWorksheetMatchNonBlanks
        /// </summary>
        [Test]
        public void CellsAutoFilterPostWorksheetMatchNonBlanksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? fieldIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPostWorksheetMatchNonBlanks(name, sheetName, fieldIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetColorFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetColorFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            ColorFilterRequest colorFilter = new ColorFilterRequest();
            Color color = new Color();//0, 255, 245, 2
            color.R = 255;
            color.A = 245;
            color.B = 245;
            color.G = 0;

            colorFilter.ForegroundColor = new CellsColor();
            colorFilter.ForegroundColor.Color = color;
            colorFilter.ForegroundColor.ThemeColor = new ThemeColor();
            colorFilter.ForegroundColor.ThemeColor.ColorType = "Text2";
            colorFilter.ForegroundColor.ThemeColor.Tint =1;
            colorFilter.ForegroundColor.Type = "Automatic";
            colorFilter.BackgroundColor = new CellsColor();
            colorFilter.BackgroundColor.Color = new Color();
            colorFilter.BackgroundColor.Color.A = 255;
            colorFilter.BackgroundColor.Color.R = 255;
            colorFilter.BackgroundColor.Color.B = 0;
            colorFilter.BackgroundColor.Color.G = 0;
            colorFilter.BackgroundColor.ThemeColor = new ThemeColor();
            colorFilter.BackgroundColor.ThemeColor.ColorType = "Text2";
            colorFilter.BackgroundColor.ThemeColor.Tint = 1;
            colorFilter.BackgroundColor.Type = "Automatic";
            colorFilter.Pattern = "Solid";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetColorFilter(name, sheetName, range, fieldIndex, colorFilter, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetCustomFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetCustomFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            string operatorType1 = "LessOrEqual";
            string criteria1 = "test";
            bool? isAnd = false;
            string operatorType2 = "LessOrEqual";
            string criteria2 = "test";
            bool? matchBlanks = true;
            bool? refresh = false;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetCustomFilter(name, sheetName, range, fieldIndex, operatorType1, criteria1, isAnd, operatorType2, criteria2, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetDateFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetDateFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            string dateTimeGroupingType = "Day";
            int? year = 2019;
            int? month = 1;
            int? day = 1;
            int? hour = 1;
            int? minute = 1;
            int? second = 1;
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER , BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetDateFilter(name, sheetName, range, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetDynamicFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetDynamicFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            string dynamicFilterType = "May";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetDynamicFilter(name, sheetName, range, fieldIndex, dynamicFilterType, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            string criteria = "test";
            bool? matchBlanks = true;
            bool? refresh = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetFilter(name, sheetName, range, fieldIndex, criteria, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetFilterTop10
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetFilterTop10Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            bool? isTop = true;
            bool? isPercent = true;
            int? itemCount = 1;
            bool? matchBlanks = null;
            bool? refresh = null;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetFilterTop10(name, sheetName, range, fieldIndex, isTop, isPercent, itemCount, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsAutoFilterPutWorksheetIconFilter
        /// </summary>
        [Test]
        public void CellsAutoFilterPutWorksheetIconFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string range = RANGE;
            int? fieldIndex = 0;
            string iconSetType = "None";
            int? iconId = 0;
            bool? matchBlanks = null;
            bool? refresh = null;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,TEMPFOLDER, BOOK1);
            var response = instance.CellsAutoFilterPutWorksheetIconFilter(name, sheetName, range, fieldIndex, iconSetType, iconId, matchBlanks, refresh, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}
