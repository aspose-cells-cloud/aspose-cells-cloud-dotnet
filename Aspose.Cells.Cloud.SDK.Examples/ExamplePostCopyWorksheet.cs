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

var options = new CopyOptions()
{
    ColumnCharacterWidth = true
};
var request = new PostCopyWorksheetRequest(
    name: remoteName,
    sheetName: "Sheet15",
    sourceSheet: "Sheet6",
    options: options,
    sourceWorkbook: "",
    sourceFolder: "",
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostCopyWorksheet(request);
