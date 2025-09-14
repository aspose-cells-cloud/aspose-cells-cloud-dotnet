namespace Aspose.Cells.Cloud.SDK.Api.ExampleQuickstart
{
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Request;

    public class Example_Repair
    {
        public static void Run()
        {
            RepairExcel();
            UnprotectSpreadsheet();
        }
        public static void RepairExcel()
        {
            CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
            Model.FilesResult result = cellsApi.PostRepair(new PostRepairRequest {  File = new Dictionary<string, Stream> { { "NeedRepairedExcel.xlsx", System.IO.File.OpenRead("NeedRepairedExcel.xlsx")} } });
            foreach (var file in result.Files)
            {
                File.WriteAllBytes(file.Filename, Convert.FromBase64String(file.FileContent));
            }
        }

        public static void UnprotectSpreadsheet()
        {
            CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
            cellsApi.UnprotectSpreadsheet(new UnprotectSpreadsheetRequest { Spreadsheet = "ProtectedBook1.xlsx", password = "123456", modifyPassword = "654321" }, "UnprotectedBook1.xlsx");
        }
    }
}