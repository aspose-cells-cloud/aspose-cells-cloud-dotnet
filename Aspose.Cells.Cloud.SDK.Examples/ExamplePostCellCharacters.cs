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

var optionsvalue0Font = new Font()
{
    IsBold = true,
    Size = 16
};
var optionsvalue0 = new FontSetting()
{
    Length = 5,
    StartIndex = 0,
    Font = optionsvalue0Font
};
var options = new List<FontSetting>()
{
    optionsvalue0
};
var request = new PostCellCharactersRequest(
    name: remoteName,
    sheetName: "Sheet1",
    cellName: "E36",
    options: options,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostCellCharacters(request);
