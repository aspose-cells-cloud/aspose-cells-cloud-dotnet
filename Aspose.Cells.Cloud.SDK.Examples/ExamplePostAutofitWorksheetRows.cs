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

var request = new PostAutofitWorksheetRowsRequest(
    name: remoteName,
    sheetName: "Sheet1",
    startRow: 1,
    endRow: 9,
    onlyAuto: true,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostAutofitWorksheetRows(request);
