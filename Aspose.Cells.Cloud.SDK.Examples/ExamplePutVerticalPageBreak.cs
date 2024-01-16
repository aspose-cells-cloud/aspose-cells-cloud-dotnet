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

var request = new PutVerticalPageBreakRequest(
    name: remoteName,
    sheetName: "Sheet1",
    cellname: "A1",
    column: 1,
    row: 1,
    startRow: 1,
    endRow: 1,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutVerticalPageBreak(request);
