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

var listColumn = new ListColumn()
{
    Name = "test cloumn"
};
var request = new PostWorksheetListColumnRequest(
    name: remoteName,
    sheetName: "Sheet7",
    listObjectIndex: 0,
    columnIndex: 0,
    listColumn: listColumn,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorksheetListColumn(request);
