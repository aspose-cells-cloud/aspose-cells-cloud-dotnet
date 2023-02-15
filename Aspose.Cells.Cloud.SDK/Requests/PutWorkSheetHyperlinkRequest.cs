// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorkSheetHyperlinkRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorkSheetHyperlink" /> operation.
    /// </summary>
    public class PutWorkSheetHyperlinkRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorkSheetHyperlinkRequest"/> class.
        /// </summary>
        public PutWorkSheetHyperlinkRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorkSheetHyperlinkRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="firstRow"></param>
        /// <param name="firstColumn"></param>
        /// <param name="totalRows"></param>
        /// <param name="totalColumns"></param>
        /// <param name="address"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
        public PutWorkSheetHyperlinkRequest(string name, string sheetName, int? firstRow, int? firstColumn, int? totalRows, int? totalColumns, string address, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.firstRow = firstRow;
            this.firstColumn = firstColumn;
            this.totalRows = totalRows;
            this.totalColumns = totalColumns;
            this.address = address;
            this.folder = folder;
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
        /// Gets or sets firstRow.
        /// </summary>
        public int? firstRow { get; set; }

        /// <summary>
        /// Gets or sets firstColumn.
        /// </summary>
        public int? firstColumn { get; set; }

        /// <summary>
        /// Gets or sets totalRows.
        /// </summary>
        public int? totalRows { get; set; }

        /// <summary>
        /// Gets or sets totalColumns.
        /// </summary>
        public int? totalColumns { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'firstRow' is set
            if ( this.firstRow == null)
            {
                throw new ApiException(400, "Missing required parameter 'firstRow' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'firstColumn' is set
            if ( this.firstColumn == null)
            {
                throw new ApiException(400, "Missing required parameter 'firstColumn' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'totalRows' is set
            if ( this.totalRows == null)
            {
                throw new ApiException(400, "Missing required parameter 'totalRows' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'totalColumns' is set
            if ( this.totalColumns == null)
            {
                throw new ApiException(400, "Missing required parameter 'totalColumns' when calling PutWorkSheetHyperlink");
            }

            // verify the required parameter 'address' is set
            if (string.IsNullOrEmpty (this.address ))
            {
                throw new ApiException(400, "Missing required parameter 'address' when calling PutWorkSheetHyperlink");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/hyperlinks";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "firstRow", this.firstRow);
            path = UrlHelper.AddQueryParameterToUrl(path, "firstColumn", this.firstColumn);
            path = UrlHelper.AddQueryParameterToUrl(path, "totalRows", this.totalRows);
            path = UrlHelper.AddQueryParameterToUrl(path, "totalColumns", this.totalColumns);
            path = UrlHelper.AddQueryParameterToUrl(path, "address", this.address);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
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
