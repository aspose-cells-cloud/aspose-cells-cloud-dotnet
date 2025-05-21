// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSearchRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostSearch" /> operation.
    /// </summary>
    public class PostSearchRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSearchRequest"/> class.
        /// </summary>
        public PostSearchRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSearchRequest"/> class.
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="text">Find content</param>
        /// <param name="password">The password needed to open an Excel file.</param>
        /// <param name="sheetname">The worksheet name. Locate the specified text content in the worksheet.</param>
        /// <param name="checkExcelRestriction">Whether check restriction of excel file when user modify cells related objects.</param>
                
        public PostSearchRequest(string localPath ,  string text  ,  string password   = null,  string sheetname   = null,  bool? checkExcelRestriction   = null)
        {
            this.LocalPath = localPath ;
            this.text = text;
            this.password = password;
            this.sheetname = sheetname;
            this.checkExcelRestriction = checkExcelRestriction;
        }
        [System.Obsolete]
        public PostSearchRequest(IDictionary<string, System.IO.Stream> file, string text, string password = null, string sheetname = null, bool? checkExcelRestriction = null)
        {
            this.File = file;
            this.text = text;
            this.password = password;
            this.sheetname = sheetname;
            this.checkExcelRestriction = checkExcelRestriction;
        }           
        
        /// <summary>
        /// File to upload
        /// </summary>
        public IDictionary<string, System.IO.Stream> File { get; set; }
        public string LocalPath { get; set; }


        /// <summary>
        /// Find content
        /// </summary>
        public string text { get; set; }


        /// <summary>
        /// The password needed to open an Excel file.
        /// </summary>
        public string password { get; set; }


        /// <summary>
        /// The worksheet name. Locate the specified text content in the worksheet.
        /// </summary>
        public string sheetname { get; set; }


        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.
        /// </summary>
        public bool? checkExcelRestriction { get; set; }
        

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
            if (  this.File == null  && string.IsNullOrEmpty(this.LocalPath)   )
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling PostSearch");
            }

            // verify the required parameter 'text' is set
            if (string.IsNullOrEmpty (this.text ))
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling PostSearch");
            }

            var path = baseUri + "/cells/search";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "text", this.text);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (!string.IsNullOrEmpty(this.sheetname))  path = UrlHelper.AddQueryParameterToUrl(path, "sheetname", this.sheetname);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
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
