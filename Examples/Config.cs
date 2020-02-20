using System;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using System.Collections.Generic;
using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using System.IO;


namespace cells_cloud_charp
{
    public class Config
    {

        protected static ApiClient client;
        protected static Configuration config;
        protected static OAuthApi oauth2 = null;
        protected static string grantType = "client_credentials";
        protected static string clientId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
        protected static string clientSecret = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
        protected static string accesstoken;
        protected static string refreshtoken;
        public Configuration GetConfiguration()
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
            config = new Configuration(client, headerParameters);
            return config;
        }

        public void UpdateDataFile(string folder, string filename)
        {
            StorageApi storageApi = new StorageApi(clientSecret, clientId);
            DeleteFileRequest file = new DeleteFileRequest();
            PutCreateRequest newfile = new PutCreateRequest();
            if (string.IsNullOrEmpty(folder))
            {
                file.Path = filename;
                newfile.Path = filename;
                newfile.File = File.Open("example_data/" + filename, FileMode.Open);
            }
            else
            {
                file.Path = folder + "/" + filename;
                newfile.Path = folder + "/" + filename;
                newfile.File = File.Open("example_data/" + filename, FileMode.Open);
            }
            storageApi.DeleteFile(file);
            storageApi.PutCreate(newfile);
            newfile.File.Close();
        }



    }
}