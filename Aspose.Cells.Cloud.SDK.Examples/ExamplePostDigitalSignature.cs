using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Book1.xlsx";
string roywangPFX = "roywang.pfx";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
this.UploadFile( roywangPFX, remoteFolder + "/roywang.pfx", "");

var request = new PostDigitalSignatureRequest(
    name: remoteName,
    digitalsignaturefile: remoteFolder + "/roywang.pfx",
    password: "123456",
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostDigitalSignature(request);
