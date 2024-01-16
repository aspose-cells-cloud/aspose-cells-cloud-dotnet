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

var colorFilterForegroundColorColor = new Color()
{
    R = 48,
    G = 48,
    B = 48
};
var colorFilterForegroundColor = new CellsColor()
{
    Type = "Automatic",
    Color = colorFilterForegroundColorColor
};
var colorFilter = new ColorFilterRequest()
{
    Pattern = "Solid",
    ForegroundColor = colorFilterForegroundColor
};
var request = new PutWorksheetColorFilterRequest(
    name: remoteName,
    sheetName: "Sheet1",
    range: "A1:B1",
    fieldIndex: 0,
    colorFilter: colorFilter,
    matchBlanks: true,
    refresh: true,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetColorFilter(request);
