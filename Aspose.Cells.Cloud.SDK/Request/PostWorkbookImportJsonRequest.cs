// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookImportJsonRequest.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookImportJson" /> operation.
    /// </summary>
    public class PostWorkbookImportJsonRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookImportJsonRequest"/> class.
        /// </summary>
        public PostWorkbookImportJsonRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookImportJsonRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook(Excel/ODS/...) name.</param>
        /// <param name="importJsonRequest"></param>
        /// <param name="password">password</param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="storageName">Storage name.</param>
        /// <param name="outPath">Output file path.</param>
        /// <param name="outStorageName">Storage name for output file.</param>
        /// <param name="checkExcelRestriction">check Excel restriction.</param>
        public PostWorkbookImportJsonRequest(string name, ImportJsonRequest importJsonRequest, string password = null, string folder = null, string storageName = null, string outPath = null, string outStorageName = null, bool? checkExcelRestriction = null)
        {
            this.name = name;
            this.importJsonRequest = importJsonRequest;
            this.password = password;
            this.folder = folder;
            this.storageName = storageName;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.checkExcelRestriction = checkExcelRestriction;
        }

        /// <summary>
        /// The workbook(Excel/ODS/...) name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets importJsonRequest.
        /// </summary>
        public ImportJsonRequest importJsonRequest { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Original workbook folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// Output file path.
        /// </summary>
        public string outPath { get; set; }

        /// <summary>
        /// Storage name for output file.
        /// </summary>
        public string outStorageName { get; set; }

        /// <summary>
        /// check Excel restriction.
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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookImportJson");
            }

            // verify the required parameter 'importJsonRequest' is set
            if ( this.importJsonRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'importJsonRequest' when calling PostWorkbookImportJson");
            }

            var path = baseUri + "/cells/{name}/importjson";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.importJsonRequest != null ? JsonConvert.SerializeObject(this.importJsonRequest) : null);
            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
