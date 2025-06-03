// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SearchBrokenLinksInRemoteRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SearchBrokenLinksInRemote" /> operation.
    /// </summary>
    public class SearchBrokenLinksInRemoteRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBrokenLinksInRemoteRequest"/> class.
        /// </summary>
        public SearchBrokenLinksInRemoteRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="SearchBrokenLinksInRemoteRequest"/> class.
            /// </summary>
            /// <param name="name">The name of the workbook file to be search.</param>
            /// <param name="sheetname">Specify the worksheet for the lookup.</param>
            /// <param name="cellarea">Specify the cell area for the lookup</param>
            /// <param name="folder">The folder path where the workbook is stored.</param>
            /// <param name="storageName">(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.</param>
            /// <param name="regoin">The spreadsheet region setting.</param>
            /// <param name="password">The password for opening spreadsheet file.</param>
            public SearchBrokenLinksInRemoteRequest(string  name, string  sheetname = null, string  cellarea = null, string  folder = null, string  storageName = null, string  regoin = null, string  password = null)
            {
                this.name = name;
                this.sheetname = sheetname;
                this.cellarea = cellarea;
                this.folder = folder;
                this.storageName = storageName;
                this.regoin = regoin;
                this.password = password;
            }
        
        /// <summary>
        /// The name of the workbook file to be search.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Specify the worksheet for the lookup.
        /// </summary>
        public string sheetname { get; set; }


        /// <summary>
        /// Specify the cell area for the lookup
        /// </summary>
        public string cellarea { get; set; }


        /// <summary>
        /// The folder path where the workbook is stored.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// (Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.
        /// </summary>
        public string storageName { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string regoin { get; set; }


        /// <summary>
        /// The password for opening spreadsheet file.
        /// </summary>
        public string password { get; set; }
        

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
                throw new ApiException(400, "Missing required parameter 'name' when calling SearchBrokenLinksInRemote");
            }

            var path = baseUri + "/cells/{name}/searchBrokenLinks";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.sheetname))  path = UrlHelper.AddQueryParameterToUrl(path, "sheetname", this.sheetname);
            if (!string.IsNullOrEmpty(this.cellarea))  path = UrlHelper.AddQueryParameterToUrl(path, "cellarea", this.cellarea);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.regoin))  path = UrlHelper.AddQueryParameterToUrl(path, "regoin", this.regoin);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
