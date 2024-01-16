using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Book1.xlsx";
string reportDataXML = "ReportData.xml";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
this.UploadFile( reportDataXML, remoteFolder + "/ReportData.xml", "");

var request = new PostWorkbookGetSmartMarkerResultRequest(
    name: remoteName,
    xmlFile: remoteFolder + "/ReportData.xml",
    folder: remoteFolder,
    outPath: "OutResult/SmartMarkerResult.xlsx",
    storageName: "",
    outStorageName: ""
);
this.CellsApi.PostWorkbookGetSmartMarkerResult(request);
