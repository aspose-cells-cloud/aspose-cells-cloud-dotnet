using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

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
this.CellsApi.PostDataTransformation(request);
