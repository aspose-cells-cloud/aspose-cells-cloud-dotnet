using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Template.xlsx";
string remoteName = "Template.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var request = new PostWorkbookExportXMLRequest(
    name: remoteName,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorkbookExportXML(request);
