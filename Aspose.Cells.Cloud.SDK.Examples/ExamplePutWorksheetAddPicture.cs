using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Book1.xlsx";
string waterMarkPNG = "WaterMark.png";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
this.UploadFile( waterMarkPNG, remoteFolder + "/WaterMark.png", "");

var request = new PutWorksheetAddPictureRequest(
    name: remoteName,
    sheetName: "Sheet6",
    upperLeftRow: 1,
    upperLeftColumn: 1,
    lowerRightRow: 10,
    lowerRightColumn: 10,
    picturePath: remoteFolder + "/WaterMark.png",
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PutWorksheetAddPicture(request);
