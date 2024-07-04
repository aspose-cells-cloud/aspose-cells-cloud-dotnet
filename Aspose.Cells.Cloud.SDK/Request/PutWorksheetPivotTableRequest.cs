// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetPivotTableRequest.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetPivotTable" /> operation.
    /// </summary>
    public class PutWorksheetPivotTableRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetPivotTableRequest"/> class.
        /// </summary>
        public PutWorksheetPivotTableRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetPivotTableRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="sourceData">The data for the new PivotTable cache.</param>
        /// <param name="destCellName">The cell in the upper-left corner of the destination range for the PivotTable report.</param>
        /// <param name="tableName">The name of the new PivotTable.</param>
        /// <param name="useSameSource">Indicates whether using same data source when another existing PivotTable has used this data source. If the property is true, it will save memory.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        public PutWorksheetPivotTableRequest(string name, string sheetName, string folder = null, string sourceData = null, string destCellName = null, string tableName = null, bool? useSameSource = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.folder = folder;
            this.sourceData = sourceData;
            this.destCellName = destCellName;
            this.tableName = tableName;
            this.useSameSource = useSameSource;
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
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The data for the new PivotTable cache.
        /// </summary>
        public string sourceData { get; set; }

        /// <summary>
        /// The cell in the upper-left corner of the destination range for the PivotTable report.
        /// </summary>
        public string destCellName { get; set; }

        /// <summary>
        /// The name of the new PivotTable.
        /// </summary>
        public string tableName { get; set; }

        /// <summary>
        /// Indicates whether using same data source when another existing PivotTable has used this data source. If the property is true, it will save memory.
        /// </summary>
        public bool? useSameSource { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetPivotTable");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetPivotTable");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/pivottables";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.sourceData))  path = UrlHelper.AddQueryParameterToUrl(path, "sourceData", this.sourceData);
            if (!string.IsNullOrEmpty(this.destCellName))  path = UrlHelper.AddQueryParameterToUrl(path, "destCellName", this.destCellName);
            if (!string.IsNullOrEmpty(this.tableName))  path = UrlHelper.AddQueryParameterToUrl(path, "tableName", this.tableName);
            if(this.useSameSource != null)  path = UrlHelper.AddQueryParameterToUrl(path, "useSameSource", this.useSameSource);
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
