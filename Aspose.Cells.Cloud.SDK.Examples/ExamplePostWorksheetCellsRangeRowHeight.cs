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

var range = new Range()
{
    ColumnCount = 1,
    ColumnWidth = 10.0f,
    FirstRow = 1,
    RowCount = 10
};
var request = new PostWorksheetCellsRangeRowHeightRequest(
    name: remoteName,
    sheetName: "Sheet1",
    range: range,
    value: 10.9f,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorksheetCellsRangeRowHeight(request);
