
namespace Aspose.Cells.Cloud.SDK.Test
{
    using Aspose.Cells.Cloud.SDK.Client;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Storage.Cloud.Sdk.Api;
    using Aspose.Storage.Cloud.Sdk.Model;
    using Aspose.Storage.Cloud.Sdk.Model.Requests;
    using System.IO;
    using System.Collections.Generic;
    public class CellsBaseTest
    {
        protected ApiClient client;
        protected Client.Configuration config;
        protected static OAuthApi oauth2 =null;
        protected string grantType = "client_credentials";
        protected string clientId = "your app sid";
        protected string clientSecret = "your app key";
        protected static string accesstoken;
        protected string refreshtoken;
        protected string BOOK1 = "Book1.xlsx";
        protected string MYDOC = "myDocument.xlsx";
        protected string PivTestFile = "TestCase.xlsx";
        protected string TEMPFOLDER = "Temp";
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
        protected StorageApi storageApi;
        private string TestDataFolder = @"D:\Projects\Aspose\Aspose.Cloud\Aspose.Cells.Cloud.SDK\src\TestData\";
        protected void UpdateDataFile( string folder, string filename)
        {
            this.storageApi = new StorageApi( clientSecret, clientId);
            DeleteFileRequest file = new DeleteFileRequest();
            PutCreateRequest newfile = new PutCreateRequest();
            if (string.IsNullOrEmpty(folder))
            {
                file.Path =  filename;
                newfile.Path = filename;
                newfile.File = File.Open(TestDataFolder + filename, FileMode.Open);
            }
            else
            {
                file.Path = folder + "/" + filename;
                newfile.Path = folder + "/" + filename;
                newfile.File = File.Open(TestDataFolder + filename, FileMode.Open);
            }
            storageApi.DeleteFile(file);
            storageApi.PutCreate(newfile);
            newfile.File.Close();
        }
        protected void UpdateDataFileForDropBox(string folder, string filename)
        {
            this.storageApi = new StorageApi(clientSecret, clientId);
            DeleteFileRequest file = new DeleteFileRequest();
            PutCreateRequest newfile = new PutCreateRequest();
            file.Storage = "DropBox";
            newfile.Storage = "DropBox";
            if (string.IsNullOrEmpty(folder))
            {
                file.Path = filename;
                newfile.Path = filename;
                newfile.File = File.Open(TestDataFolder + filename, FileMode.Open);
            }
            else
            {
                file.Path = folder + "/" + filename;
                newfile.Path = folder + "/" + filename;
                newfile.File = File.Open(TestDataFolder + filename, FileMode.Open);
            }
            this.storageApi.DeleteFile(file);
            this.storageApi.PutCreate(newfile);
            newfile.File.Close();
        }
        protected Stream GetTestDataStream( string filename)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(System.Text.Encoding.Default.GetString(File.ReadAllBytes(TestDataFolder + filename)));
            writer.Flush();
            ms.Position = 0;
            return ms;
        }
        protected byte[] GetTestDataByteArray(string filename)
        {
            return File.ReadAllBytes(TestDataFolder + filename);
        }
        protected void WriteResponseStream(string filename, Stream stream)
        {
            FileStream fs = File.Create(TestDataFolder + filename);
            stream.CopyTo(fs);
            fs.Close();
        }
        protected Client.Configuration GetConfiguration()
        {
            if (oauth2 == null)
            {
                oauth2 = new OAuthApi("https://api.aspose.cloud");
                var oauth2response = oauth2.OAuthPost(grantType, clientId, clientSecret);
                accesstoken = oauth2response.AccessToken;
                refreshtoken = oauth2response.RefreshToken;
            }
            Dictionary<string, string> headerParameters = new Dictionary<string, string>();
            headerParameters.Add("Authorization", "Bearer " + accesstoken);
            client = new ApiClient();
            config = new Client.Configuration(client, headerParameters);
            return config;
        }
    }
}
