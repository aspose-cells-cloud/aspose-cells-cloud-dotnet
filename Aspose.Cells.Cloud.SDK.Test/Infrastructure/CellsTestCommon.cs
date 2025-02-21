// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsTestCommon.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Tests
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Request;

    public class CellsTestCommon
    {
        private string BaseUri
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestApiBaseUrl"); }
        }

        private string ApiVersion
        {
            get
            {
                string apiVersion = Environment.GetEnvironmentVariable("CellsCloudTestApiBaseUrl");
                return string.IsNullOrEmpty(apiVersion)?apiVersion:"v3.0";
            }            
        } 

        private string ClientId
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestClientId"); }
        }
        private string ClientSecret
        {
            get { return Environment.GetEnvironmentVariable("CellsCloudTestClientSecret"); }
        }

        protected const string ProductName = "Cells";

        protected CellsApi CellsApi;

        public CellsTestCommon()
        {
            this.CellsApi = new CellsApi(this.ClientId, this.ClientSecret, this.BaseUri,this.ApiVersion);
          //  this.CellsApi.IsLocalCloud = true;
        }

        public void UploadFile(string filename , string remotepath , string storageName)
        {
            string localPath = this.GetLocalFilePath(filename);
            using (Stream stream = File.OpenRead(localPath))
            {
                UploadFileRequest uploadFileRequest = new UploadFileRequest();
                FileInfo fileInfo = new FileInfo(localPath);
                uploadFileRequest.path = remotepath;
                uploadFileRequest.storageName = storageName;
                uploadFileRequest.UploadFiles = new Dictionary<string, Stream>() { { fileInfo.Name, File.OpenRead(localPath) } };
                this.CellsApi.UploadFile(uploadFileRequest);
            }
        }

        public void AddFileParameter(string filename , IDictionary<string,Stream> mapFiles)
        {
            string localPath = this.GetLocalFilePath(filename);
            FileInfo fileInfo = new FileInfo(localPath);
            mapFiles.Add(fileInfo.Name, File.OpenRead(localPath));
        }

        public void DownloadFile(string remotepath, string filename)
        {
            Request.DownloadFileRequest downloadFileRequest = new Request.DownloadFileRequest();
            downloadFileRequest.path = remotepath;
            using (Stream responseStream = this.CellsApi.DownloadFile(downloadFileRequest))
            {
                string localPath = this.GetDownloadFilePath(filename);
                if (string.IsNullOrEmpty(localPath))
                {
                    return;
                }
                using( Stream outStream = File.OpenWrite(localPath))
                {
                    responseStream.CopyTo(outStream);
                }
            }
        }        
        public string GetLocalFilePath(string filename)
        {
            string localFolder = Environment.GetEnvironmentVariable("CellsCloudTestLocalFolder");
            if (string.IsNullOrEmpty(localFolder))
            {
                localFolder = Environment.CurrentDirectory;
                int pos = localFolder.IndexOf("bin");
                if(pos >0)
                {
                    localFolder = Path.Combine( localFolder.Substring(0, pos),"./../TestData","CellsCloud");
                }
            }

            return Path.Combine(localFolder, filename);
        }
        public string GetDownloadFilePath(string filename)
        {
            string localFolder = Environment.GetEnvironmentVariable("CellsCloudTestOutFolder");
            if (string.IsNullOrEmpty(localFolder))
            {
                localFolder = @"D:\projects\test\Aspose.Cells.Cloud.SDK\DotNet\download";
                if (!Directory.Exists(localFolder))
                {
                    return null;
                }
            }
            return Path.Combine(localFolder, filename);
        }

    }
}
