using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

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
this.CellsApi.PostWorkbookDataCleansing(request);
