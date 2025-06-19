using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorkbookCalculateFormula
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var options = new CalculationOptions()
        {
            IgnoreError = true,
            Recursive = true
        };
        var request = new PostWorkbookCalculateFormulaRequest(
            name: remoteName,
            options: options,
            ignoreError: true,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorkbookCalculateFormula(request);
    }
}