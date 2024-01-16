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

var rangeOperateSource = new Range()
{
    ColumnCount = 1,
    ColumnWidth = 10.0f,
    FirstRow = 1,
    RowCount = 10
};
var rangeOperateTarget = new Range()
{
    ColumnCount = 1,
    ColumnWidth = 10.0f,
    FirstRow = 10,
    RowCount = 10
};
var rangeOperate = new RangeCopyRequest()
{
    Operate = "copydata",
    Source = rangeOperateSource,
    Target = rangeOperateTarget
};
var request = new PostWorksheetCellsRangesCopyRequest(
    name: remoteName,
    sheetName: "Sheet1",
    rangeOperate: rangeOperate,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorksheetCellsRangesCopy(request);
