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

var request = new PostClearContentsRequest(
    name: remoteName,
    sheetName: "Sheet1",
    range: "A1:C10",
    startRow: 1,
    startColumn: 1,
    endRow: 3,
    endColumn: 3,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostClearContents(request);
