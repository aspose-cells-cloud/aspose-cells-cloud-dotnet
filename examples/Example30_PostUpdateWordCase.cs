using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostUpdateWordCase
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "BookText.xlsx";
        string remoteName = "BookText.xlsx";

        var wordCaseOptionsDataSource = new DataSource()
        {
            DataSourceType = "CloudFileSystem",
            DataPath = "TestData/In/BookText.xlsx"
        };
        var wordCaseOptionsScopeOptions = new ScopeOptions()
        {
            Scope = "EntireWorkbook"
        };
        var wordCaseOptions = new WordCaseOptions()
        {
            DataSource = wordCaseOptionsDataSource,
            WordCaseType = "None",
            ScopeOptions = wordCaseOptionsScopeOptions
        };
        var request = new PostUpdateWordCaseRequest(
            wordCaseOptions: wordCaseOptions
        );
        cellsApi.PostUpdateWordCase(request);
    }
}