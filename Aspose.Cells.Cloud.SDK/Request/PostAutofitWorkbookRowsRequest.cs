// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostAutofitWorkbookRowsRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostAutofitWorkbookRows" /> operation.
    /// </summary>
    public class PostAutofitWorkbookRowsRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAutofitWorkbookRowsRequest"/> class.
        /// </summary>
        public PostAutofitWorkbookRowsRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostAutofitWorkbookRowsRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="startRow">Start row.</param>
            /// <param name="endRow">End row.</param>
            /// <param name="onlyAuto">Only auto.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            /// <param name="firstColumn">First column index.</param>
            /// <param name="lastColumn">Last column index.</param>
            public PostAutofitWorkbookRowsRequest(string  name, int?  startRow = null, int?  endRow = null, bool?  onlyAuto = null, string  folder = null, string  storageName = null, int?  firstColumn = null, int?  lastColumn = null)
            {
                this.name = name;
                this.startRow = startRow;
                this.endRow = endRow;
                this.onlyAuto = onlyAuto;
                this.folder = folder;
                this.storageName = storageName;
                this.firstColumn = firstColumn;
                this.lastColumn = lastColumn;
            }
        
        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Start row.
        /// </summary>
        public int? startRow { get; set; }


        /// <summary>
        /// End row.
        /// </summary>
        public int? endRow { get; set; }


        /// <summary>
        /// Only auto.
        /// </summary>
        public bool? onlyAuto { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }


        /// <summary>
        /// First column index.
        /// </summary>
        public int? firstColumn { get; set; }


        /// <summary>
        /// Last column index.
        /// </summary>
        public int? lastColumn { get; set; }
        

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAutofitWorkbookRows");
            }

            var path = baseUri + "/cells/{name}/autofitrows";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if(this.startRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "startRow", this.startRow);
            if(this.endRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "endRow", this.endRow);
            if(this.onlyAuto != null)  path = UrlHelper.AddQueryParameterToUrl(path, "onlyAuto", this.onlyAuto);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if(this.firstColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "firstColumn", this.firstColumn);
            if(this.lastColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "lastColumn", this.lastColumn);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
