// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteWorksheetFreezePanesRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.DeleteWorksheetFreezePanes" /> operation.
    /// </summary>
    public class DeleteWorksheetFreezePanesRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorksheetFreezePanesRequest"/> class.
        /// </summary>
        public DeleteWorksheetFreezePanesRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorksheetFreezePanesRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="row">Row index.</param>
        /// <param name="column">Column index.</param>
        /// <param name="freezedRows">Number of visible rows in top pane, no more than row index.</param>
        /// <param name="freezedColumns">Number of visible columns in left pane, no more than column index.</param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="storageName">Storage name.</param>
        public DeleteWorksheetFreezePanesRequest(string name, string sheetName, int? row, int? column, int? freezedRows, int? freezedColumns, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.row = row;
            this.column = column;
            this.freezedRows = freezedRows;
            this.freezedColumns = freezedColumns;
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
        /// Row index.
        /// </summary>
        public int? row { get; set; }

        /// <summary>
        /// Column index.
        /// </summary>
        public int? column { get; set; }

        /// <summary>
        /// Number of visible rows in top pane, no more than row index.
        /// </summary>
        public int? freezedRows { get; set; }

        /// <summary>
        /// Number of visible columns in left pane, no more than column index.
        /// </summary>
        public int? freezedColumns { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteWorksheetFreezePanes");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling DeleteWorksheetFreezePanes");
            }

            // verify the required parameter 'row' is set
            if ( this.row == null)
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling DeleteWorksheetFreezePanes");
            }

            // verify the required parameter 'column' is set
            if ( this.column == null)
            {
                throw new ApiException(400, "Missing required parameter 'column' when calling DeleteWorksheetFreezePanes");
            }

            // verify the required parameter 'freezedRows' is set
            if ( this.freezedRows == null)
            {
                throw new ApiException(400, "Missing required parameter 'freezedRows' when calling DeleteWorksheetFreezePanes");
            }

            // verify the required parameter 'freezedColumns' is set
            if ( this.freezedColumns == null)
            {
                throw new ApiException(400, "Missing required parameter 'freezedColumns' when calling DeleteWorksheetFreezePanes");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/freezepanes";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "row", this.row);
            path = UrlHelper.AddQueryParameterToUrl(path, "column", this.column);
            path = UrlHelper.AddQueryParameterToUrl(path, "freezedRows", this.freezedRows);
            path = UrlHelper.AddQueryParameterToUrl(path, "freezedColumns", this.freezedColumns);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "DELETE", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
