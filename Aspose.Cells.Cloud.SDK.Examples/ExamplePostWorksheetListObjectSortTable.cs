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

var dataSorter = new DataSorter()
{
    CaseSensitive = true
};
var request = new PostWorksheetListObjectSortTableRequest(
    name: remoteName,
    sheetName: "Sheet7",
    listObjectIndex: 0,
    dataSorter: dataSorter,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorksheetListObjectSortTable(request);
