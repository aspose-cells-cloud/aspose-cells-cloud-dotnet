// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteWorksheetDateFilterRequest.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.DeleteWorksheetDateFilter" /> operation.
    /// </summary>
    public class DeleteWorksheetDateFilterRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorksheetDateFilterRequest"/> class.
        /// </summary>
        public DeleteWorksheetDateFilterRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteWorksheetDateFilterRequest"/> class.
            /// </summary>
            /// <param name="name">The workbook name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="fieldIndex">The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).</param>
            /// <param name="dateTimeGroupingType">Specifies how to group dateTime values.</param>
            /// <param name="year">The year.</param>
            /// <param name="month">The month.</param>
            /// <param name="day">The day.</param>
            /// <param name="hour">The hour.</param>
            /// <param name="minute">The minute.</param>
            /// <param name="second">The second.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public DeleteWorksheetDateFilterRequest(string name, string sheetName, int? fieldIndex, string dateTimeGroupingType, int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, string folder = null, string storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.fieldIndex = fieldIndex;
                this.dateTimeGroupingType = dateTimeGroupingType;
                this.year = year;
                this.month = month;
                this.day = day;
                this.hour = hour;
                this.minute = minute;
                this.second = second;
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
        /// The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).
        /// </summary>
        public int? fieldIndex { get; set; }


        /// <summary>
        /// Specifies how to group dateTime values.
        /// </summary>
        public string dateTimeGroupingType { get; set; }


        /// <summary>
        /// The year.
        /// </summary>
        public int? year { get; set; }


        /// <summary>
        /// The month.
        /// </summary>
        public int? month { get; set; }


        /// <summary>
        /// The day.
        /// </summary>
        public int? day { get; set; }


        /// <summary>
        /// The hour.
        /// </summary>
        public int? hour { get; set; }


        /// <summary>
        /// The minute.
        /// </summary>
        public int? minute { get; set; }


        /// <summary>
        /// The second.
        /// </summary>
        public int? second { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteWorksheetDateFilter");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling DeleteWorksheetDateFilter");
            }

            // verify the required parameter 'fieldIndex' is set
            if ( this.fieldIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'fieldIndex' when calling DeleteWorksheetDateFilter");
            }

            // verify the required parameter 'dateTimeGroupingType' is set
            if (string.IsNullOrEmpty (this.dateTimeGroupingType ))
            {
                throw new ApiException(400, "Missing required parameter 'dateTimeGroupingType' when calling DeleteWorksheetDateFilter");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "fieldIndex", this.fieldIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "dateTimeGroupingType", this.dateTimeGroupingType);
            if(this.year != null)  path = UrlHelper.AddQueryParameterToUrl(path, "year", this.year);
            if(this.month != null)  path = UrlHelper.AddQueryParameterToUrl(path, "month", this.month);
            if(this.day != null)  path = UrlHelper.AddQueryParameterToUrl(path, "day", this.day);
            if(this.hour != null)  path = UrlHelper.AddQueryParameterToUrl(path, "hour", this.hour);
            if(this.minute != null)  path = UrlHelper.AddQueryParameterToUrl(path, "minute", this.minute);
            if(this.second != null)  path = UrlHelper.AddQueryParameterToUrl(path, "second", this.second);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "DELETE", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
