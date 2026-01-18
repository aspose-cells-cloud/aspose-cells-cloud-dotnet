// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetFilterTop10Request.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetFilterTop10" /> operation.
    /// </summary>
    public class PutWorksheetFilterTop10Request : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetFilterTop10Request"/> class.
        /// </summary>
        public PutWorksheetFilterTop10Request()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutWorksheetFilterTop10Request"/> class.
            /// </summary>
            /// <param name="name">The workbook name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="range">Represents the range to which the specified AutoFilter applies.</param>
            /// <param name="fieldIndex">The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).</param>
            /// <param name="isTop">Indicates whether filter from top or bottom</param>
            /// <param name="isPercent">Indicates whether the items is percent or count</param>
            /// <param name="itemCount">The item count</param>
            /// <param name="matchBlanks">Match all blank cell in the list.</param>
            /// <param name="refresh">Refresh auto filters to hide or unhide the rows.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PutWorksheetFilterTop10Request(string  name, string  sheetName, string  range, int?  fieldIndex, bool?  isTop, bool?  isPercent, int?  itemCount, bool?  matchBlanks = null, bool?  refresh = null, string  folder = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.range = range;
                this.fieldIndex = fieldIndex;
                this.isTop = isTop;
                this.isPercent = isPercent;
                this.itemCount = itemCount;
                this.matchBlanks = matchBlanks;
                this.refresh = refresh;
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
        /// Represents the range to which the specified AutoFilter applies.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).
        /// </summary>
        public int? fieldIndex { get; set; }


        /// <summary>
        /// Indicates whether filter from top or bottom
        /// </summary>
        public bool? isTop { get; set; }


        /// <summary>
        /// Indicates whether the items is percent or count
        /// </summary>
        public bool? isPercent { get; set; }


        /// <summary>
        /// The item count
        /// </summary>
        public int? itemCount { get; set; }


        /// <summary>
        /// Match all blank cell in the list.
        /// </summary>
        public bool? matchBlanks { get; set; }


        /// <summary>
        /// Refresh auto filters to hide or unhide the rows.
        /// </summary>
        public bool? refresh { get; set; }


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
        public IDictionary<string, string> extendQueryParameterMap = new Dictionary<string, string>{};

        public void AddExtendQueryParameter(string name ,string value)
        {
            extendQueryParameterMap.Add(name,value);
        }
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'range' is set
            if (string.IsNullOrEmpty (this.range ))
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'fieldIndex' is set
            if ( this.fieldIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'fieldIndex' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'isTop' is set
            if ( this.isTop == null)
            {
                throw new ApiException(400, "Missing required parameter 'isTop' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'isPercent' is set
            if ( this.isPercent == null)
            {
                throw new ApiException(400, "Missing required parameter 'isPercent' when calling PutWorksheetFilterTop10");
            }

            // verify the required parameter 'itemCount' is set
            if ( this.itemCount == null)
            {
                throw new ApiException(400, "Missing required parameter 'itemCount' when calling PutWorksheetFilterTop10");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/autoFilter/filterTop10";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            path = UrlHelper.AddQueryParameterToUrl(path, "fieldIndex", this.fieldIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "isTop", this.isTop);
            path = UrlHelper.AddQueryParameterToUrl(path, "isPercent", this.isPercent);
            path = UrlHelper.AddQueryParameterToUrl(path, "itemCount", this.itemCount);
            if(this.matchBlanks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "matchBlanks", this.matchBlanks);
            if(this.refresh != null)  path = UrlHelper.AddQueryParameterToUrl(path, "refresh", this.refresh);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
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
