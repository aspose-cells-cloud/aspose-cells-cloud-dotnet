using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Book1.xlsx";
string myDocumentXLSX = "myDocument.xlsx";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
this.UploadFile( myDocumentXLSX, remoteFolder + "/myDocument.xlsx", "");

var request = new PostWorkbooksMergeRequest(
    name: remoteName,
    mergeWith: remoteFolder + "/myDocument.xlsx",
    folder: remoteFolder,
    storageName: "",
    mergedStorageName: ""
);
this.CellsApi.PostWorkbooksMerge(request);
