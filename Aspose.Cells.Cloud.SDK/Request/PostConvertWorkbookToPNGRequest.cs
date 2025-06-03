// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostConvertWorkbookToPNGRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostConvertWorkbookToPNG" /> operation.
    /// </summary>
    public class PostConvertWorkbookToPNGRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConvertWorkbookToPNGRequest"/> class.
        /// </summary>
        public PostConvertWorkbookToPNGRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostConvertWorkbookToPNGRequest"/> class.
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="password">The password needed to open an Excel file.</param>
        /// <param name="checkExcelRestriction">Whether check restriction of excel file when user modify cells related objects.</param>
        /// <param name="region">The regional settings for workbook.</param>
        public PostConvertWorkbookToPNGRequest(string localPath ,  string password   = null,  bool? checkExcelRestriction   = null,  string region   = null)
        {
            this.LocalPath = localPath ;
            this.password = password;
            this.checkExcelRestriction = checkExcelRestriction;
            this.region = region;
        }
        [System.Obsolete]
        public PostConvertWorkbookToPNGRequest(IDictionary<string, System.IO.Stream>  file, string  password = null, bool?  checkExcelRestriction = null, string  region = null)
        {
            this.File = file;
            this.password = password;
            this.checkExcelRestriction = checkExcelRestriction;
            this.region = region;
        }
        
        /// <summary>
        /// File to upload
        /// </summary>
            public string LocalPath { get; set; }
            public IDictionary<string, System.IO.Stream> File { get; set; }      


        /// <summary>
        /// The password needed to open an Excel file.
        /// </summary>
        public string password { get; set; }


        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.
        /// </summary>
        public bool? checkExcelRestriction { get; set; }


        /// <summary>
        /// The regional settings for workbook.
        /// </summary>
        public string region { get; set; }
        

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
            // verify the required parameter 'file' is set
            if (   string.IsNullOrEmpty(this.LocalPath) ||  this.File == null    )
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling PostConvertWorkbookToPNG");
            }

            var path = baseUri + "/cells/convert/png";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            if (!string.IsNullOrEmpty(LocalPath ) && System.IO.File.Exists(LocalPath )) {
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(LocalPath);
                        localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(LocalPath), fileInfo.Name));
               }

            if (File != null){
                    foreach (KeyValuePair<string, System.IO.Stream> keyValueFileParam in File )
                    {
                        localVarFileParams.Add(keyValueFileParam.Key, UrlHelper.ToFileInfo(keyValueFileParam.Value, keyValueFileParam.Key));
                    }
            }


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
