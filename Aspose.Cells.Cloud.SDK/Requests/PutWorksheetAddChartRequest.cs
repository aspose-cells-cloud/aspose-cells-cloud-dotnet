// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetAddChartRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetAddChart" /> operation.
    /// </summary>
    public class PutWorksheetAddChartRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetAddChartRequest"/> class.
        /// </summary>
        public PutWorksheetAddChartRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetAddChartRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="chartType"></param>
        /// <param name="upperLeftRow"></param>
        /// <param name="upperLeftColumn"></param>
        /// <param name="lowerRightRow"></param>
        /// <param name="lowerRightColumn"></param>
        /// <param name="area"></param>
        /// <param name="isVertical"></param>
        /// <param name="categoryData"></param>
        /// <param name="isAutoGetSerialName"></param>
        /// <param name="title"></param>
        /// <param name="folder"></param>
        /// <param name="dataLabels"></param>
        /// <param name="dataLabelsPosition"></param>
        /// <param name="pivotTableSheet"></param>
        /// <param name="pivotTableName"></param>
        /// <param name="storageName"></param>
        public PutWorksheetAddChartRequest(string name, string sheetName, string chartType, int? upperLeftRow = null, int? upperLeftColumn = null, int? lowerRightRow = null, int? lowerRightColumn = null, string area = null, bool? isVertical = null, string categoryData = null, bool? isAutoGetSerialName = null, string title = null, string folder = null, bool? dataLabels = null, string dataLabelsPosition = null, string pivotTableSheet = null, string pivotTableName = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.chartType = chartType;
            this.upperLeftRow = upperLeftRow;
            this.upperLeftColumn = upperLeftColumn;
            this.lowerRightRow = lowerRightRow;
            this.lowerRightColumn = lowerRightColumn;
            this.area = area;
            this.isVertical = isVertical;
            this.categoryData = categoryData;
            this.isAutoGetSerialName = isAutoGetSerialName;
            this.title = title;
            this.folder = folder;
            this.dataLabels = dataLabels;
            this.dataLabelsPosition = dataLabelsPosition;
            this.pivotTableSheet = pivotTableSheet;
            this.pivotTableName = pivotTableName;
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
        /// Gets or sets chartType.
        /// </summary>
        public string chartType { get; set; }

        /// <summary>
        /// Gets or sets upperLeftRow.
        /// </summary>
        public int? upperLeftRow { get; set; }

        /// <summary>
        /// Gets or sets upperLeftColumn.
        /// </summary>
        public int? upperLeftColumn { get; set; }

        /// <summary>
        /// Gets or sets lowerRightRow.
        /// </summary>
        public int? lowerRightRow { get; set; }

        /// <summary>
        /// Gets or sets lowerRightColumn.
        /// </summary>
        public int? lowerRightColumn { get; set; }

        /// <summary>
        /// Gets or sets area.
        /// </summary>
        public string area { get; set; }

        /// <summary>
        /// Gets or sets isVertical.
        /// </summary>
        public bool? isVertical { get; set; }

        /// <summary>
        /// Gets or sets categoryData.
        /// </summary>
        public string categoryData { get; set; }

        /// <summary>
        /// Gets or sets isAutoGetSerialName.
        /// </summary>
        public bool? isAutoGetSerialName { get; set; }

        /// <summary>
        /// Gets or sets title.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets dataLabels.
        /// </summary>
        public bool? dataLabels { get; set; }

        /// <summary>
        /// Gets or sets dataLabelsPosition.
        /// </summary>
        public string dataLabelsPosition { get; set; }

        /// <summary>
        /// Gets or sets pivotTableSheet.
        /// </summary>
        public string pivotTableSheet { get; set; }

        /// <summary>
        /// Gets or sets pivotTableName.
        /// </summary>
        public string pivotTableName { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetAddChart");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetAddChart");
            }

            // verify the required parameter 'chartType' is set
            if (string.IsNullOrEmpty (this.chartType ))
            {
                throw new ApiException(400, "Missing required parameter 'chartType' when calling PutWorksheetAddChart");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/charts";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "chartType", this.chartType);
            if(this.upperLeftRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftRow", this.upperLeftRow);
            if(this.upperLeftColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftColumn", this.upperLeftColumn);
            if(this.lowerRightRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "lowerRightRow", this.lowerRightRow);
            if(this.lowerRightColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "lowerRightColumn", this.lowerRightColumn);
            if (!string.IsNullOrEmpty(this.area))  path = UrlHelper.AddQueryParameterToUrl(path, "area", this.area);
            if(this.isVertical != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isVertical", this.isVertical);
            if (!string.IsNullOrEmpty(this.categoryData))  path = UrlHelper.AddQueryParameterToUrl(path, "categoryData", this.categoryData);
            if(this.isAutoGetSerialName != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isAutoGetSerialName", this.isAutoGetSerialName);
            if (!string.IsNullOrEmpty(this.title))  path = UrlHelper.AddQueryParameterToUrl(path, "title", this.title);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if(this.dataLabels != null)  path = UrlHelper.AddQueryParameterToUrl(path, "dataLabels", this.dataLabels);
            if (!string.IsNullOrEmpty(this.dataLabelsPosition))  path = UrlHelper.AddQueryParameterToUrl(path, "dataLabelsPosition", this.dataLabelsPosition);
            if (!string.IsNullOrEmpty(this.pivotTableSheet))  path = UrlHelper.AddQueryParameterToUrl(path, "pivotTableSheet", this.pivotTableSheet);
            if (!string.IsNullOrEmpty(this.pivotTableName))  path = UrlHelper.AddQueryParameterToUrl(path, "pivotTableName", this.pivotTableName);
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
