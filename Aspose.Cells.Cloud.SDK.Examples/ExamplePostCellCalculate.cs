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

var options = new CalculationOptions()
{
    Recursive = true,
    IgnoreError = true
};
var request = new PostCellCalculateRequest(
    name: remoteName,
    sheetName: "Sheet1",
    cellName: "A1",
    options: options,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostCellCalculate(request);
