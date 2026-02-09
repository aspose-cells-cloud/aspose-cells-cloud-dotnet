using Aspose.Cells.Cloud.SDK.Api;

namespace Aspose.Cells.Cloud.SDK.Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Example_WordCase.Run();
            //Example_TrimContent.Run();
            CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
            Stream stream = cellsApi.DownloadFile( new Request.DownloadFileRequest("PowerShell-7.5.3-win-x64.msi") );
            using( Stream file = File.Create(@"D:\test\PowerShell-7.5.3-win-x64.msi"))
            {
                stream.CopyTo(file);
                stream.Close();
                file.Close();
            }
        }
    }
}
