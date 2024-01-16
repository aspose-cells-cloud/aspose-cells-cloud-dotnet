// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetChartRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetChart" /> operation.
    /// </summary>
    public class PutWorksheetChartRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetChartRequest"/> class.
        /// </summary>
        public PutWorksheetChartRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetChartRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="chartType">Chart type, please refer property Type in chart resource.</param>
        /// <param name="upperLeftRow">Upper-left row for the new chart.</param>
        /// <param name="upperLeftColumn">Upper-left column for the new chart.</param>
        /// <param name="lowerRightRow">Lower-left row for the new chart.</param>
        /// <param name="lowerRightColumn">Lower-left column for the new chart.</param>
        /// <param name="area">Specify the values from which to plot the data series.</param>
        /// <param name="isVertical">Specify whether to plot the series from a range of cell values by row or by column. </param>
        /// <param name="categoryData">Get or set the range of category axis values. It can be a range of cells (e.g., "D1:E10").</param>
        /// <param name="isAutoGetSerialName">Specify whether to auto-update the serial name.</param>
        /// <param name="title">Specify the chart title name.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="dataLabels">Represents the specified chart's data label values display behavior. True to display the values, False to hide them.</param>
        /// <param name="dataLabelsPosition">Represents data label position (Center/InsideBase/InsideEnd/OutsideEnd/Above/Below/Left/Right/BestFit/Moved).</param>
        /// <param name="pivotTableSheet">The source is the data of the pivotTable. If PivotSource is not empty, the chart is a PivotChart.</param>
        /// <param name="pivotTableName">The pivot table name.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        public PutWorksheetChartRequest(string name, string sheetName, string chartType, int? upperLeftRow = null, int? upperLeftColumn = null, int? lowerRightRow = null, int? lowerRightColumn = null, string area = null, bool? isVertical = null, string categoryData = null, bool? isAutoGetSerialName = null, string title = null, string folder = null, bool? dataLabels = null, string dataLabelsPosition = null, string pivotTableSheet = null, string pivotTableName = null, string storageName = null)
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
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Chart type, please refer property Type in chart resource.
        /// </summary>
        public string chartType { get; set; }

        /// <summary>
        /// Upper-left row for the new chart.
        /// </summary>
        public int? upperLeftRow { get; set; }

        /// <summary>
        /// Upper-left column for the new chart.
        /// </summary>
        public int? upperLeftColumn { get; set; }

        /// <summary>
        /// Lower-left row for the new chart.
        /// </summary>
        public int? lowerRightRow { get; set; }

        /// <summary>
        /// Lower-left column for the new chart.
        /// </summary>
        public int? lowerRightColumn { get; set; }

        /// <summary>
        /// Specify the values from which to plot the data series.
        /// </summary>
        public string area { get; set; }

        /// <summary>
        /// Specify whether to plot the series from a range of cell values by row or by column. 
        /// </summary>
        public bool? isVertical { get; set; }

        /// <summary>
        /// Get or set the range of category axis values. It can be a range of cells (e.g., "D1:E10").
        /// </summary>
        public string categoryData { get; set; }

        /// <summary>
        /// Specify whether to auto-update the serial name.
        /// </summary>
        public bool? isAutoGetSerialName { get; set; }

        /// <summary>
        /// Specify the chart title name.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Represents the specified chart's data label values display behavior. True to display the values, False to hide them.
        /// </summary>
        public bool? dataLabels { get; set; }

        /// <summary>
        /// Represents data label position (Center/InsideBase/InsideEnd/OutsideEnd/Above/Below/Left/Right/BestFit/Moved).
        /// </summary>
        public string dataLabelsPosition { get; set; }

        /// <summary>
        /// The source is the data of the pivotTable. If PivotSource is not empty, the chart is a PivotChart.
        /// </summary>
        public string pivotTableSheet { get; set; }

        /// <summary>
        /// The pivot table name.
        /// </summary>
        public string pivotTableName { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetChart");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetChart");
            }

            // verify the required parameter 'chartType' is set
            if (string.IsNullOrEmpty (this.chartType ))
            {
                throw new ApiException(400, "Missing required parameter 'chartType' when calling PutWorksheetChart");
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
