
namespace Aspose.Cells.Cloud.SDK.Test
{
    using Aspose.Cells.Cloud.SDK.Client;
    using Aspose.Cells.Cloud.SDK.Api;
    using System.IO;
    using System;
    using System.Text;
    using Newtonsoft.Json;

    public class CellsBaseTest
    {
        protected string testbaseurl
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestApiBaseUrl"); }
        }
        protected string apiVersion = @"v3.0";
        protected ApiClient client;
        protected Client.Configuration config;
        protected string grantType = "client_credentials";
        protected string clientId
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestClientId"); }
        }
        protected string clientSecret
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestClientSecret"); }
        }
        protected static string accesstoken;
        protected string refreshtoken;
        protected string BOOK1 = "Book1.xlsx";
        protected string DataSource = "datasource.xlsx";
        protected string AssemblyTest = "assemblytest.xlsx";
        protected string MYDOC = "myDocument.xlsx";
        protected string PivTestFile = "TestCase.xlsx";
        protected string PivTestFile2 = "PivTestFile2.xlsx";
        protected string TEMPFOLDER = "DotNetTest";
        protected string BatchFolder = "BatchFiles";
        protected string OutPut = "OutPut";
        protected string NEEDUNLOCK = "needUnlock.xlsx";
        protected string SHEET1 = "Sheet1";
        protected string SHEET2 = "Sheet2";
        protected string SHEET3 = "Sheet3";
        protected string SHEET4 = "Sheet4";
        protected string SHEET5 = "Sheet5";
        protected string SHEET6 = "Sheet6";
        protected string SHEET7 = "Sheet7";
        protected string SHEET8 = "Sheet8";
        protected string CellName = "A1";
        protected string RANGE = "A1:C10";
        protected string CELLAREA = "A1:C10";
        protected bool IsDockerTest
        {
            get { return Convert.ToBoolean( Environment.GetEnvironmentVariable("CellsCloudTestIsDockerTest")); }
        }
        protected const string DownloadFolder = @"C:\data\";
        private string TestDataFolder
        {
            get
            {               
                return @"C:\TestData\";
            }
        }
        protected void UpdateDataFile(CellsApi cellsApi, string folder, string filename)
        {
            bool? exist = cellsApi.ObjectExists(folder + @"\" + filename).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(folder + @"\" + filename);
            }
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream);
        }
        protected void UpdateDataFile(CellsApi cellsApi, string filename)
        {
            bool? exist = cellsApi.ObjectExists(filename).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(filename);
            }
            cellsApi.DeleteFile(filename);
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(filename, stream);
        }
        protected void UpdateDataFileToOtherStorage(CellsApi cellsApi, string folder, string filename, string stroageName)
        {
            bool? exist = cellsApi.ObjectExists(folder + @"\" + filename, stroageName).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(folder + @"\" + filename, stroageName);
            }
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream, stroageName);
        }

        protected FileStream GetFileStream(string filename)
        {
            return File.OpenRead(TestDataFolder + filename);
        }

        protected Stream GetTestDataStream(string filename)
        {
            MemoryStream ms = new MemoryStream();
            FileStream fs = File.OpenRead(TestDataFolder + filename);
            fs.CopyTo(ms);
            ms.Position = 0;
            return ms;
        }
        protected byte[] GetTestDataByteArray(string filename)
        {
            return File.ReadAllBytes(TestDataFolder + filename);
        }
        protected string GetTestDataBase64String(string filename)
        {
            return Convert.ToBase64String( File.ReadAllBytes(TestDataFolder + filename));
        }
        protected void WriteResponseStream(string filename, Stream stream)
        {
            FileStream fs = File.Create(TestDataFolder + filename);
            stream.CopyTo(fs);
            fs.Close();
        }
        protected bool Download(Stream stream, string filename)
        {
            if ( Directory.Exists(DownloadFolder))
            {
                using (FileStream fileStream = File.Create(DownloadFolder + filename))
                {
                    fileStream.Position = 0;
                    stream.CopyTo(fileStream);
                    fileStream.Close();
                }
            }
            return true;
        }
        protected DTO.CellsCloudResponse ToCellsCloudResponse(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string dto =  reader.ReadToEnd();
                return JsonConvert.DeserializeObject<DTO.CellsCloudResponse>(dto);
            }
        }
    }
}
