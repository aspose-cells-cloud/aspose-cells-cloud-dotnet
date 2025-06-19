using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetPicture
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var picture = new Picture()
        {
            Left = 10,
            Bottom = 10
        };
        var request = new PostWorksheetPictureRequest(
            name: remoteName,
            sheetName: "Sheet6",
            pictureIndex: 0,
            picture: picture,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetPicture(request);
    }
}