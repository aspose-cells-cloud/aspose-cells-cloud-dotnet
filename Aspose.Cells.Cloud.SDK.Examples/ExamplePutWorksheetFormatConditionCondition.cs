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

var request = new PutWorksheetFormatConditionConditionRequest(
    name: remoteName,
    sheetName: "Sheet1",
    index: 0,
    type: "CellValue",
    operatorType: "Between",
    formula1: "v1",
    formula2: "v2",
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetFormatConditionCondition(request);
