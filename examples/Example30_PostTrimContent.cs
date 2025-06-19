using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostTrimContent
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "BookText.xlsx";
        string remoteName = "BookText.xlsx";

        var trimContentOptionsDataSource = new DataSource()
        {
            DataSourceType = "CloudFileSystem",
            DataPath = "TestData/In/BookText.xlsx"
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
        cellsApi.PostTrimContent(request);
    }
}