namespace Aspose.Cells.Cloud.SDK.Tests.Api.Example
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    using Aspose.Cells.Cloud.SDK.Api;
    using System;
    using System.IO;

    public class CellsApiExample
    {
        string CellsCloudClientId ="....";//get from https://dashboard.aspose.cloud/#/applications
        string CellsCloudClientSecret="...";//get from https://dashboard.aspose.cloud/#/applications
        ExampleXlsx = "example.xlsx";
        RemoteFolder = "NetSDK";

        public void Example()
        {
                var uploadRequest = new UploadFileRequest(ExampleXlsx, RemoteFolder + "/" + ExampleXlsx);
                cellsApi.UploadFile(uploadRequest);
                var request = new GetWorksheetChartRequest(
                    name: ExampleXlsx,
                    sheetName: "Sheet4",
                    chartNumber: 0,
                    format: "svg",
                    folder: RemoteFolder,
                    storageName: ""
                );
                cellsApi.GetWorksheetChart(request);
        }
    }
}
