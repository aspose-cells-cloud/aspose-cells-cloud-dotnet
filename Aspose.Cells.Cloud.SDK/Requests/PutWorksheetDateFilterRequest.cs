// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetDateFilterRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetDateFilter" /> operation.
    /// </summary>
    public class PutWorksheetDateFilterRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetDateFilterRequest"/> class.
        /// </summary>
        public PutWorksheetDateFilterRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetDateFilterRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="range"></param>
        /// <param name="fieldIndex"></param>
        /// <param name="dateTimeGroupingType"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="matchBlanks"></param>
        /// <param name="refresh"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
        public PutWorksheetDateFilterRequest(string name, string sheetName, string range, int? fieldIndex, string dateTimeGroupingType, int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, bool? matchBlanks = null, bool? refresh = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.range = range;
            this.fieldIndex = fieldIndex;
            this.dateTimeGroupingType = dateTimeGroupingType;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.matchBlanks = matchBlanks;
            this.refresh = refresh;
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
        /// Gets or sets range.
        /// </summary>
        public string range { get; set; }

        /// <summary>
        /// Gets or sets fieldIndex.
        /// </summary>
        public int? fieldIndex { get; set; }

        /// <summary>
        /// Gets or sets dateTimeGroupingType.
        /// </summary>
        public string dateTimeGroupingType { get; set; }

        /// <summary>
        /// Gets or sets year.
        /// </summary>
        public int? year { get; set; }

        /// <summary>
        /// Gets or sets month.
        /// </summary>
        public int? month { get; set; }

        /// <summary>
        /// Gets or sets day.
        /// </summary>
        public int? day { get; set; }

        /// <summary>
        /// Gets or sets hour.
        /// </summary>
        public int? hour { get; set; }

        /// <summary>
        /// Gets or sets minute.
        /// </summary>
        public int? minute { get; set; }

        /// <summary>
        /// Gets or sets second.
        /// </summary>
        public int? second { get; set; }

        /// <summary>
        /// Gets or sets matchBlanks.
        /// </summary>
        public bool? matchBlanks { get; set; }

        /// <summary>
        /// Gets or sets refresh.
        /// </summary>
        public bool? refresh { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetDateFilter");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetDateFilter");
            }

            // verify the required parameter 'range' is set
            if (string.IsNullOrEmpty (this.range ))
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling PutWorksheetDateFilter");
            }

            // verify the required parameter 'fieldIndex' is set
            if ( this.fieldIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'fieldIndex' when calling PutWorksheetDateFilter");
            }

            // verify the required parameter 'dateTimeGroupingType' is set
            if (string.IsNullOrEmpty (this.dateTimeGroupingType ))
            {
                throw new ApiException(400, "Missing required parameter 'dateTimeGroupingType' when calling PutWorksheetDateFilter");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            path = UrlHelper.AddQueryParameterToUrl(path, "fieldIndex", this.fieldIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "dateTimeGroupingType", this.dateTimeGroupingType);
            if(this.year != null)  path = UrlHelper.AddQueryParameterToUrl(path, "year", this.year);
            if(this.month != null)  path = UrlHelper.AddQueryParameterToUrl(path, "month", this.month);
            if(this.day != null)  path = UrlHelper.AddQueryParameterToUrl(path, "day", this.day);
            if(this.hour != null)  path = UrlHelper.AddQueryParameterToUrl(path, "hour", this.hour);
            if(this.minute != null)  path = UrlHelper.AddQueryParameterToUrl(path, "minute", this.minute);
            if(this.second != null)  path = UrlHelper.AddQueryParameterToUrl(path, "second", this.second);
            if(this.matchBlanks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "matchBlanks", this.matchBlanks);
            if(this.refresh != null)  path = UrlHelper.AddQueryParameterToUrl(path, "refresh", this.refresh);
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
