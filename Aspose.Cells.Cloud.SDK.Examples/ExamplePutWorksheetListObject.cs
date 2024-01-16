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

var request = new PutWorksheetListObjectRequest(
    name: remoteName,
    sheetName: "Sheet7",
    startRow: 1,
    startColumn: 1,
    endRow: 6,
    endColumn: 6,
    folder: remoteFolder,
    hasHeaders: true,
    displayName: "true",
    showTotals: false,
    storageName: ""
);
this.CellsApi.PutWorksheetListObject(request);
