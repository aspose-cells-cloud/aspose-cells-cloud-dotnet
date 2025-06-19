using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetShape
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var shapeDTO = new Shape()
        {
        };
        var request = new PutWorksheetShapeRequest(
            name: remoteName,
            sheetName: "Sheet1",
            shapeDTO: shapeDTO,
            drawingType: "arc",
            upperLeftRow: 1,
            upperLeftColumn: 1,
            top: 10,
            left: 10,
            width: 100,
            height: 100,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetShape(request);
    }
}