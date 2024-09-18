using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "BookText.xlsx";
string remoteName = "BookText.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var trimContentOptionsDataSource = new DataSource()
{
    DataSourceType = "CloudFileSystem",
    DataPath = "BookText.xlsx"
};
var trimContentOptionsScopeOptions = new ScopeOptions()
{
    Scope = "EntireWorkbook"
};
var trimContentOptions = new TrimContentOptions()
{
    DataSource = trimContentOptionsDataSource,
    TrimLeading = true,
    TrimTrailing = true,
    TrimSpaceBetweenWordTo1 = true,
    RemoveAllLineBreaks = true,
    ScopeOptions = trimContentOptionsScopeOptions
};
var request = new PostTrimContentRequest(
    trimContentOptions: trimContentOptions
);
this.CellsApi.PostTrimContent(request);
