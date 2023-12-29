// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookImportXMLRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookImportXML" /> operation.
    /// </summary>
    public class PostWorkbookImportXMLRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookImportXMLRequest"/> class.
        /// </summary>
        public PostWorkbookImportXMLRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookImportXMLRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="importXMLRequest">Import XML request.</param>
        /// <param name="password">The password needed to open an Excel file.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        /// <param name="outPath">Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.</param>
        /// <param name="outStorageName">The storage name where the output file is situated.</param>
        /// <param name="checkExcelRestriction">Whether check restriction of excel file when user modify cells related objects.</param>
        /// <param name="region">The regional settings for workbook.</param>
        public PostWorkbookImportXMLRequest(string name, ImportXMLRequest importXMLRequest, string password = null, string folder = null, string storageName = null, string outPath = null, string outStorageName = null, bool? checkExcelRestriction = null, string region = null)
        {
            this.name = name;
            this.importXMLRequest = importXMLRequest;
            this.password = password;
            this.folder = folder;
            this.storageName = storageName;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.checkExcelRestriction = checkExcelRestriction;
            this.region = region;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Import XML request.
        /// </summary>
        public ImportXMLRequest importXMLRequest { get; set; }

        /// <summary>
        /// The password needed to open an Excel file.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.
        /// </summary>
        public string outPath { get; set; }

        /// <summary>
        /// The storage name where the output file is situated.
        /// </summary>
        public string outStorageName { get; set; }

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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookImportXML");
            }

            // verify the required parameter 'importXMLRequest' is set
            if ( this.importXMLRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'importXMLRequest' when calling PostWorkbookImportXML");
            }

            var path = baseUri + "/cells/{name}/importxml";
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
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.importXMLRequest != null ? JsonConvert.SerializeObject(this.importXMLRequest) : null);
            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
