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

var request = new PutWorkbookCreateRequest(
    name: "PutWorkbookCreate.xlsx",
    templateFile: remoteFolder + "/" + remoteName,
    dataFile: remoteFolder + "/ReportData.xml",
    isWriteOver: true,
    folder: remoteFolder,
    storageName: "",
    checkExcelRestriction: true
);
this.CellsApi.PutWorkbookCreate(request);
