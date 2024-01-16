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

var title = new Title()
{
    IsVisible = true
};
var request = new PutWorksheetChartTitleRequest(
    name: remoteName,
    sheetName: "Sheet4",
    chartIndex: 0,
    title: title,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetChartTitle(request);
