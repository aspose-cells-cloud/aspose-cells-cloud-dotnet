using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetOleObject
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string oLEDoc = "OLEDoc.docx";
        string wordJPG = "word.jpg";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetOleObjectRequest(
            name: remoteName,
            sheetName: "Sheet6",
            upperLeftRow: 1,
            upperLeftColumn: 1,
            height: 100,
            width: 80,
            oleFile: "OLEDoc.docx",
            imageFile: "word.jpg",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetOleObject(request);
    }
}