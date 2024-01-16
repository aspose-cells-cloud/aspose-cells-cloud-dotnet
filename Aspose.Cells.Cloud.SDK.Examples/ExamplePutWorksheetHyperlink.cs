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

var request = new PutWorksheetHyperlinkRequest(
    name: remoteName,
    sheetName: "Sheet1",
    firstRow: 1,
    firstColumn: 1,
    totalRows: 2,
    totalColumns: 3,
    address: "https://products.aspose.cloud/cells/",
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetHyperlink(request);
