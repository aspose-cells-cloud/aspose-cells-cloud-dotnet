// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UploadFileRequest.cs">
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

namespace Aspose.Cells.Cloud.SDK.Request
{
    using Aspose.Cells.Cloud.SDK.Model;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.UploadFile" /> operation.
    /// </summary>
    public class UploadFileRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest"/> class.
        /// </summary>
        public UploadFileRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest"/> class.
        /// </summary>
        /// <param name="uploadFiles">Upload files to cloud storage.</param>
        /// <param name="path"></param>
        /// <param name="storageName"></param>
        public UploadFileRequest(string  uploadFiles, string  path, string  storageName = null)
        {
            this.UploadFiles = uploadFiles;
            this.path = path;
            this.storageName = storageName;
        }
        
        /// <summary>
        /// Upload files to cloud storage.
        /// </summary>
            public string UploadFiles { get; set; }


        /// <summary>
        /// Gets or sets path.
        /// </summary>
        public string path { get; set; }


        /// <summary>
        /// Gets or sets storageName.
        /// </summary>
        public string storageName { get; set; }
        

        /// <summary>
        /// Gets or sets extendQueryParameterMap.
        /// </summary>
        public IDictionary<string, string> extendQueryParameterMap ;

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="baseUri">Api base uri.</param>
        /// <returns>The http request instance.</returns>
        public HttpWebRequest CreateHttpRequest(string baseUri,IDictionary<string, string> defaultHeaderMap, List<Invoker.IRequestHandler> requestHandlers)
        {
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, object>();
            string localVarPostBody ="";
            string localVarHttpContentType = "application/json";
            // verify the required parameter 'uploadFiles' is set
            if (    string.IsNullOrEmpty(this.UploadFiles)    )
            {
                throw new ApiException(400, "Missing required parameter 'uploadFiles' when calling UploadFile");
            }

            // verify the required parameter 'path' is set
            if (string.IsNullOrEmpty (this.path ))
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            var path = baseUri + "/cells/storage/file/{path}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "path", this.path);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            if (!string.IsNullOrEmpty(UploadFiles ) && System.IO.File.Exists(UploadFiles )) {
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(UploadFiles);
                        localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(UploadFiles), fileInfo.Name));
               }



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
