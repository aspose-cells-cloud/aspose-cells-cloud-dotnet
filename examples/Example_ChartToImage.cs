namespace Aspose.Cells.Cloud.SDK.Tests.Api.Example
{
    using Aspose.Cells.Cloud.SDK.Request;
    using Aspose.Cells.Cloud.SDK.Api;

    public class CellsApiExample
    {
        string CellsCloudClientId ="....";//get from https://dashboard.aspose.cloud/#/applications
        string CellsCloudClientSecret="...";//get from https://dashboard.aspose.cloud/#/applications
       string ExampleXlsx = "example.xlsx";
        string RemoteFolder = "NetSDK";

        public void Example()
		{
			CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
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
