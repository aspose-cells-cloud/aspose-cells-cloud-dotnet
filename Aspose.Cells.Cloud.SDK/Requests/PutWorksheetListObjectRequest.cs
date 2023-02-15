// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetListObjectRequest.cs">
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
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="endRow"></param>
        /// <param name="endColumn"></param>
        /// <param name="folder"></param>
        /// <param name="hasHeaders"></param>
        /// <param name="displayName"></param>
        /// <param name="showTotals"></param>
        /// <param name="storageName"></param>
        public PutWorksheetListObjectRequest(string name, string sheetName, int? startRow = null, int? startColumn = null, int? endRow = null, int? endColumn = null, string folder = null, bool? hasHeaders = null, string displayName = null, bool? showTotals = null, string storageName = null)
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
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets sheetName.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Gets or sets startRow.
        /// </summary>
        public int? startRow { get; set; }

        /// <summary>
        /// Gets or sets startColumn.
        /// </summary>
        public int? startColumn { get; set; }

        /// <summary>
        /// Gets or sets endRow.
        /// </summary>
        public int? endRow { get; set; }

        /// <summary>
        /// Gets or sets endColumn.
        /// </summary>
        public int? endColumn { get; set; }

        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets hasHeaders.
        /// </summary>
        public bool? hasHeaders { get; set; }

        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// Gets or sets showTotals.
        /// </summary>
        public bool? showTotals { get; set; }

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
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
