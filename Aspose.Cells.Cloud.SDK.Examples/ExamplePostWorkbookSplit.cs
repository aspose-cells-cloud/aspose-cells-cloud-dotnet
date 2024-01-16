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

var request = new PostWorkbookSplitRequest(
    name: remoteName,
    format: "png",
    outFolder: "OutResult",
    from: 1,
    to: 5,
    horizontalResolution: 96,
    verticalResolution: 96,
    splitNameRule: "sheetname",
    folder: remoteFolder,
    storageName: "",
    outStorageName: ""
);
this.CellsApi.PostWorkbookSplit(request);
