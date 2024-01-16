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

var request = new PutWorksheetFilterTop10Request(
    name: remoteName,
    sheetName: "Sheet1",
    range: "A1:B1",
    fieldIndex: 0,
    isTop: true,
    isPercent: true,
    itemCount: 1,
    matchBlanks: false,
    refresh: true,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetFilterTop10(request);
