// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorksheetMergeRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorksheetMerge" /> operation.
    /// </summary>
    public class PostWorksheetMergeRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorksheetMergeRequest"/> class.
        /// </summary>
        public PostWorksheetMergeRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorksheetMergeRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="startRow">The start row.</param>
        /// <param name="startColumn">The start column.</param>
        /// <param name="totalRows">The total rows</param>
        /// <param name="totalColumns">The total columns.</param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="storageName">Storage name.</param>
        public PostWorksheetMergeRequest(string name, string sheetName, int? startRow, int? startColumn, int? totalRows, int? totalColumns, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.startRow = startRow;
            this.startColumn = startColumn;
            this.totalRows = totalRows;
            this.totalColumns = totalColumns;
            this.folder = folder;
            this.storageName = storageName;
        }

        /// <summary>
        /// The workbook name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// The start row.
        /// </summary>
        public int? startRow { get; set; }

        /// <summary>
        /// The start column.
        /// </summary>
        public int? startColumn { get; set; }

        /// <summary>
        /// The total rows
        /// </summary>
        public int? totalRows { get; set; }

        /// <summary>
        /// The total columns.
        /// </summary>
        public int? totalColumns { get; set; }

        /// <summary>
        /// Original workbook folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorksheetMerge");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostWorksheetMerge");
            }

            // verify the required parameter 'startRow' is set
            if ( this.startRow == null)
            {
                throw new ApiException(400, "Missing required parameter 'startRow' when calling PostWorksheetMerge");
            }

            // verify the required parameter 'startColumn' is set
            if ( this.startColumn == null)
            {
                throw new ApiException(400, "Missing required parameter 'startColumn' when calling PostWorksheetMerge");
            }

            // verify the required parameter 'totalRows' is set
            if ( this.totalRows == null)
            {
                throw new ApiException(400, "Missing required parameter 'totalRows' when calling PostWorksheetMerge");
            }

            // verify the required parameter 'totalColumns' is set
            if ( this.totalColumns == null)
            {
                throw new ApiException(400, "Missing required parameter 'totalColumns' when calling PostWorksheetMerge");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/cells/merge";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "startRow", this.startRow);
            path = UrlHelper.AddQueryParameterToUrl(path, "startColumn", this.startColumn);
            path = UrlHelper.AddQueryParameterToUrl(path, "totalRows", this.totalRows);
            path = UrlHelper.AddQueryParameterToUrl(path, "totalColumns", this.totalColumns);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
