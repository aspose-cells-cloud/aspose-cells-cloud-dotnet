using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostPivotTableFieldHideItem
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var request = new PostPivotTableFieldHideItemRequest(
            name: remoteName,
            sheetName: "Sheet4",
            pivotTableIndex: 0,
            pivotFieldType: "Row",
            fieldIndex: 0,
            itemIndex: 1,
            isHide: true,
            needReCalculate: true,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostPivotTableFieldHideItem(request);
    }
}