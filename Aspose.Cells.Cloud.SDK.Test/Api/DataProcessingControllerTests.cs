// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataProcessingControllerTests.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Tests.Api.Api
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    /// <summary>
    /// Test case of DataProcessingController.
    /// </summary>
    [TestClass]
    public class DataProcessingControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostWorkbookDataCleansing of DataProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookDataCleansing()
        {
            string localName = "BookCsvDuplicateData.csv";
            string remoteName = "BookCsvDuplicateData.csv";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dataCleansingDataFillDataFillDefaultValue = new DataFillValue()
            {
                DefaultDate = "2024-01-01",
                DefaultNumber = 0,
                DefaultBoolean = false
            };
            var dataCleansingDataFill = new DataFill()
            {
                DataFillDefaultValue = dataCleansingDataFillDataFillDefaultValue
            };
            var dataCleansing = new DataCleansing()
            {
                NeedFillData = true,
                DataFill = dataCleansingDataFill
            };
            var request = new PostWorkbookDataCleansingRequest(
                name: remoteName,
                dataCleansing: dataCleansing,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookDataCleansing(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostWorkbookDataDeduplication of DataProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookDataDeduplication()
        {
            string localName = "BookCsvDuplicateData.csv";
            string remoteName = "BookCsvDuplicateData.csv";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var deduplicationRegion = new DeduplicationRegion()
            {
            };
            var request = new PostWorkbookDataDeduplicationRequest(
                name: remoteName,
                deduplicationRegion: deduplicationRegion,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookDataDeduplication(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostWorkbookDataFill of DataProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookDataFill()
        {
            string localName = "BookCsvDuplicateData.csv";
            string remoteName = "BookCsvDuplicateData.csv";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dataFillDataFillDefaultValue = new DataFillValue()
            {
                DefaultDate = "2024-01-01",
                DefaultNumber = 0,
                DefaultBoolean = false
            };
            var dataFill = new DataFill()
            {
                DataFillDefaultValue = dataFillDataFillDefaultValue
            };
            var request = new PostWorkbookDataFillRequest(
                name: remoteName,
                dataFill: dataFill,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookDataFill(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostDataTransformation of DataProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostDataTransformation()
        {
            string localName = "BookTableL2W.xlsx";
            string remoteName = "BookTableL2W.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var dataTransformationRequestLoadDataLoadTo = new LoadTo()
            {
                beginColumnIndex = 2,
                beginRowIndex = 3,
                Worksheet = "L2W"
            };
            var dataTransformationRequestLoadDataDataQueryDataItem = new DataItem()
            {
                DataItemType = "Table",
                Value = "Table1"
            };
            var dataTransformationRequestLoadDataDataQueryDataSource = new DataSource()
            {
                DataSourceType = "CloudFileSystem",
                DataPath = "BookTableL2W.xlsx"
            };
            var dataTransformationRequestLoadDataDataQuery = new DataQuery()
            {
                Name = "DataQuery",
                DataItem = dataTransformationRequestLoadDataDataQueryDataItem,
                DataSource = dataTransformationRequestLoadDataDataQueryDataSource,
                DataSourceDataType = "ListObject"
            };
            var dataTransformationRequestLoadData = new LoadData()
            {
                LoadTo = dataTransformationRequestLoadDataLoadTo,
                DataQuery = dataTransformationRequestLoadDataDataQuery
            };
            var dataTransformationRequestAppliedStepsAppliedStep0AppliedOperateUnpivotColumnNames = new List<string>()
            {
                "2017",
                "2018",
                "2019"
            };
            var dataTransformationRequestAppliedStepsAppliedStep0AppliedOperate = new UnpivotColumn()
            {
                AppliedOperateType = "UnpivotColumn",
                ValueMapName = "Count",
                ColumnMapName = "Date",
                UnpivotColumnNames = dataTransformationRequestAppliedStepsAppliedStep0AppliedOperateUnpivotColumnNames
            };
            var dataTransformationRequestAppliedStepsAppliedStep0 = new AppliedStep()
            {
                StepName = "UnpivotColumn",
                AppliedOperate = dataTransformationRequestAppliedStepsAppliedStep0AppliedOperate
            };
            var dataTransformationRequestAppliedSteps = new List<AppliedStep>()
            {
                dataTransformationRequestAppliedStepsAppliedStep0
            };
            var dataTransformationRequest = new DataTransformationRequest()
            {
                LoadData = dataTransformationRequestLoadData,
                AppliedSteps = dataTransformationRequestAppliedSteps
            };
            var request = new PostDataTransformationRequest(
            );
            var actual =  this.CellsApi.PostDataTransformation(request);
            Assert.IsNotNull(actual);
        }
    }
}
