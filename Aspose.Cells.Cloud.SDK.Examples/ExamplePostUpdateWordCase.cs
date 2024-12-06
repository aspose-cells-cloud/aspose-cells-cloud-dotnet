using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "BookText.xlsx";
string remoteName = "BookText.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var wordCaseOptionsDataSource = new DataSource()
{
    DataSourceType = "CloudFileSystem",
    DataPath = "BookText.xlsx"
};
var wordCaseOptionsScopeOptions = new ScopeOptions()
{
    Scope = "EntireWorkbook"
};
var wordCaseOptions = new WordCaseOptions()
{
    DataSource = wordCaseOptionsDataSource,
    WordCaseType = "None",
    ScopeOptions = wordCaseOptionsScopeOptions
};
var request = new PostUpdateWordCaseRequest(
    wordCaseOptions: wordCaseOptions
);
this.CellsApi.PostUpdateWordCase(request);
