using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostAddTextContent
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "BookText.xlsx";
        string remoteName = "BookText.xlsx";

        var addTextOptionsDataSource = new DataSource()
        {
            DataSourceType = "CloudFileSystem",
            DataPath = "TestData/In/BookText.xlsx"
        };
        var addTextOptions = new AddTextOptions()
        {
            DataSource = addTextOptionsDataSource,
            Text = "Aspose.Cells Cloud is an excellent product.",
            Worksheet = "202401",
            SelectPoistion = "AtTheBeginning",
            SkipEmptyCells = true
        };
        var request = new PostAddTextContentRequest(
            addTextOptions: addTextOptions
        );
        cellsApi.PostAddTextContent(request);
    }
}