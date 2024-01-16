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

var request = new GetWorksheetCellsRangeValueRequest(
    name: remoteName,
    sheetName: "Sheet1",
    namerange: "Name_2",
    firstRow: 0,
    firstColumn: 0,
    rowCount: 3,
    columnCount: 2,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.GetWorksheetCellsRangeValue(request);
