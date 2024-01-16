using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Book1.xlsx";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var importOptionData = new List<int?>()
{
    1,
    2,
    3,
    4
};
var importOption = new ImportIntArrayOption()
{
    DestinationWorksheet = "Sheet1",
    FirstColumn = 1,
    FirstRow = 3,
    ImportDataType = "IntArray",
    IsInsert = true,
    IsVertical = true,
    Data = importOptionData
};
var request = new PostImportDataRequest(
    name: remoteName,
    importOption: importOption,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostImportData(request);
