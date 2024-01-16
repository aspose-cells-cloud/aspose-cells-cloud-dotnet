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

var tableTotalRequeststableTotalRequest0 = new TableTotalRequest()
{
    ListColumnIndex = 1,
    TotalsCalculation = "Average"
};
var tableTotalRequests = new List<TableTotalRequest>()
{
    tableTotalRequeststableTotalRequest0
};
var request = new PostWorksheetListColumnsTotalRequest(
    name: remoteName,
    sheetName: "Sheet7",
    listObjectIndex: 0,
    tableTotalRequests: tableTotalRequests,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorksheetListColumnsTotal(request);
