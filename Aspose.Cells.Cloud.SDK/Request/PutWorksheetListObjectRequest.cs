// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetListObjectRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetListObject" /> operation.
    /// </summary>
    public class PutWorksheetListObjectRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetListObjectRequest"/> class.
        /// </summary>
        public PutWorksheetListObjectRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutWorksheetListObjectRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="startRow">The start row of the list range.</param>
            /// <param name="startColumn">The start column of the list range.</param>
            /// <param name="endRow">The start row of the list range.</param>
            /// <param name="endColumn">The start column of the list range.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="hasHeaders">Indicate whether the range has headers.</param>
            /// <param name="displayName">Indicate whether display name.</param>
            /// <param name="showTotals">Indicate whether show totals.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PutWorksheetListObjectRequest(string  name, string  sheetName, int?  startRow = null, int?  startColumn = null, int?  endRow = null, int?  endColumn = null, string  folder = null, bool?  hasHeaders = null, string  displayName = null, bool?  showTotals = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.startRow = startRow;
                this.startColumn = startColumn;
                this.endRow = endRow;
                this.endColumn = endColumn;
                this.folder = folder;
                this.hasHeaders = hasHeaders;
                this.displayName = displayName;
                this.showTotals = showTotals;
                this.storageName = storageName;
            }
        
        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// The start row of the list range.
        /// </summary>
        public int? startRow { get; set; }


        /// <summary>
        /// The start column of the list range.
        /// </summary>
        public int? startColumn { get; set; }


        /// <summary>
        /// The start row of the list range.
        /// </summary>
        public int? endRow { get; set; }


        /// <summary>
        /// The start column of the list range.
        /// </summary>
        public int? endColumn { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// Indicate whether the range has headers.
        /// </summary>
        public bool? hasHeaders { get; set; }


        /// <summary>
        /// Indicate whether display name.
        /// </summary>
        public string displayName { get; set; }


        /// <summary>
        /// Indicate whether show totals.
        /// </summary>
        public bool? showTotals { get; set; }


        /// <summary>
        /// The storage name where the file is situated.
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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetListObject");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetListObject");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/listobjects";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if(this.startRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "startRow", this.startRow);
            if(this.startColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "startColumn", this.startColumn);
            if(this.endRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "endRow", this.endRow);
            if(this.endColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "endColumn", this.endColumn);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if(this.hasHeaders != null)  path = UrlHelper.AddQueryParameterToUrl(path, "hasHeaders", this.hasHeaders);
            if (!string.IsNullOrEmpty(this.displayName))  path = UrlHelper.AddQueryParameterToUrl(path, "displayName", this.displayName);
            if(this.showTotals != null)  path = UrlHelper.AddQueryParameterToUrl(path, "showTotals", this.showTotals);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
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
