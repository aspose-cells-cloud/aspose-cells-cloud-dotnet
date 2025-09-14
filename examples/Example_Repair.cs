namespace Aspose.Cells.Cloud.SDK.Api.ExampleQuickstart
{
    using System;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Request;

    public class Example_Protect
    {
        public static void Run()
        {
            ProtectSpreadsheet();
            UnprotectSpreadsheet();
        }
        public static void ProtectSpreadsheet()
        {
            CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
            cellsApi.ProtectSpreadsheet(new ProtectSpreadsheetRequest { Spreadsheet = "Book1.xlsx" , password= "123456" , modifyPassword ="654321" } , "ProtectedBook1.xlsx");
        }

        public static void UnprotectSpreadsheet()
        {
            CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
            cellsApi.UnprotectSpreadsheet(new UnprotectSpreadsheetRequest { Spreadsheet = "ProtectedBook1.xlsx", password = "123456", modifyPassword = "654321" }, "UnprotectedBook1.xlsx");
        }
    }
}