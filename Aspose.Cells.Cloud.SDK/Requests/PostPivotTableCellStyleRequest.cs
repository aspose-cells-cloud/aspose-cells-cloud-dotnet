// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostPivotTableCellStyleRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostPivotTableCellStyle" /> operation.
    /// </summary>
    public class PostPivotTableCellStyleRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPivotTableCellStyleRequest"/> class.
        /// </summary>
        public PostPivotTableCellStyleRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPivotTableCellStyleRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="pivotTableIndex"></param>
        /// <param name="column"></param>
        /// <param name="row"></param>
        /// <param name="style"></param>
        /// <param name="needReCalculate"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
        public PostPivotTableCellStyleRequest(string name, string sheetName, int? pivotTableIndex, int? column, int? row, Style style, bool? needReCalculate = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.pivotTableIndex = pivotTableIndex;
            this.column = column;
            this.row = row;
            this.style = style;
            this.needReCalculate = needReCalculate;
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
        /// Gets or sets pivotTableIndex.
        /// </summary>
        public int? pivotTableIndex { get; set; }

        /// <summary>
        /// Gets or sets column.
        /// </summary>
        public int? column { get; set; }

        /// <summary>
        /// Gets or sets row.
        /// </summary>
        public int? row { get; set; }

        /// <summary>
        /// Gets or sets style.
        /// </summary>
        public Style style { get; set; }

        /// <summary>
        /// Gets or sets needReCalculate.
        /// </summary>
        public bool? needReCalculate { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostPivotTableCellStyle");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostPivotTableCellStyle");
            }

            // verify the required parameter 'pivotTableIndex' is set
            if ( this.pivotTableIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'pivotTableIndex' when calling PostPivotTableCellStyle");
            }

            // verify the required parameter 'column' is set
            if ( this.column == null)
            {
                throw new ApiException(400, "Missing required parameter 'column' when calling PostPivotTableCellStyle");
            }

            // verify the required parameter 'row' is set
            if ( this.row == null)
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling PostPivotTableCellStyle");
            }

            // verify the required parameter 'style' is set
            if ( this.style == null)
            {
                throw new ApiException(400, "Missing required parameter 'style' when calling PostPivotTableCellStyle");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Format";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddPathParameter(path, "pivotTableIndex", this.pivotTableIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "column", this.column);
            path = UrlHelper.AddQueryParameterToUrl(path, "row", this.row);
            if(this.needReCalculate != null)  path = UrlHelper.AddQueryParameterToUrl(path, "needReCalculate", this.needReCalculate);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.style != null ? JsonConvert.SerializeObject(this.style) : null);
            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
