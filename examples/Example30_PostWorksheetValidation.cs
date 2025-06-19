using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetValidation
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var validation = new Validation()
        {
            Formula1 = "=A1",
            Type = "Custom"
        };
        var request = new PostWorksheetValidationRequest(
            name: remoteName,
            sheetName: "Sheet1",
            validationIndex: 0,
            validation: validation,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetValidation(request);
    }
}