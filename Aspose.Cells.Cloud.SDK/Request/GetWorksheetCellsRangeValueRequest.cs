// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetWorksheetCellsRangeValueRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.GetWorksheetCellsRangeValue" /> operation.
    /// </summary>
    public class GetWorksheetCellsRangeValueRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorksheetCellsRangeValueRequest"/> class.
        /// </summary>
        public GetWorksheetCellsRangeValueRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorksheetCellsRangeValueRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="namerange">range name.</param>
        /// <param name="firstRow">Gets the index of the first row of the range.</param>
        /// <param name="firstColumn">Gets the index of the first columnn of the range.</param>
        /// <param name="rowCount">Gets the count of rows in the range.</param>
        /// <param name="columnCount">Gets the count of columns in the range.</param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="storageName">Storage name.</param>
        public GetWorksheetCellsRangeValueRequest(string name, string sheetName, string namerange = null, int? firstRow = null, int? firstColumn = null, int? rowCount = null, int? columnCount = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.namerange = namerange;
            this.firstRow = firstRow;
            this.firstColumn = firstColumn;
            this.rowCount = rowCount;
            this.columnCount = columnCount;
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
        /// range name.
        /// </summary>
        public string namerange { get; set; }

        /// <summary>
        /// Gets the index of the first row of the range.
        /// </summary>
        public int? firstRow { get; set; }

        /// <summary>
        /// Gets the index of the first columnn of the range.
        /// </summary>
        public int? firstColumn { get; set; }

        /// <summary>
        /// Gets the count of rows in the range.
        /// </summary>
        public int? rowCount { get; set; }

        /// <summary>
        /// Gets the count of columns in the range.
        /// </summary>
        public int? columnCount { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetWorksheetCellsRangeValue");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling GetWorksheetCellsRangeValue");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/ranges/value";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.namerange))  path = UrlHelper.AddQueryParameterToUrl(path, "namerange", this.namerange);
            if(this.firstRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "firstRow", this.firstRow);
            if(this.firstColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "firstColumn", this.firstColumn);
            if(this.rowCount != null)  path = UrlHelper.AddQueryParameterToUrl(path, "rowCount", this.rowCount);
            if(this.columnCount != null)  path = UrlHelper.AddQueryParameterToUrl(path, "columnCount", this.columnCount);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "GET", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
