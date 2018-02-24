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
    ///  Class for testing CellsTaskApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsTaskApiTests:CellsBaseTest
    {
        private CellsTaskApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsTaskApi(GetConfiguration());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CellsTaskApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CellsTaskApi
            Assert.IsInstanceOf(typeof(CellsTaskApi), instance, "instance is a CellsTaskApi");
        }

        
        /// <summary>
        /// Test CellsTaskPostRunTask
        /// </summary>
        [Test]
        public void CellsTaskPostRunTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);

            TaskData taskData = new TaskData();
            taskData.Tasks = new List<TaskDescription>();
            TaskDescription task1 = new TaskDescription();
            task1.TaskType = "SplitWorkbook";

            SplitWorkbookTaskParameter param1 = new SplitWorkbookTaskParameter();
            param1.DestinationFileFormat = "xlsx";
            param1.DestinationFilePosition = new FileSource();
            param1.DestinationFilePosition.FilePath = TEMPFOLDER;
            param1.DestinationFilePosition.FileSourceType = "CloudFileSystem";
            param1.SplitNameRule = "sheetname";
            param1.Workbook = new FileSource();
            param1.Workbook.FileSourceType = "CloudFileSystem";
            param1.Workbook.FilePath = TEMPFOLDER + "\\" + BOOK1;
            task1.TaskParameter = param1;
            taskData.Tasks.Add(task1);
            var response = instance.CellsTaskPostRunTask(taskData);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        
    }

}
