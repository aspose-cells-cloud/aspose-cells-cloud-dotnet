// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetIconFilterRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetIconFilter" /> operation.
    /// </summary>
    public class PutWorksheetIconFilterRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetIconFilterRequest"/> class.
        /// </summary>
        public PutWorksheetIconFilterRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutWorksheetIconFilterRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="range">Represents the range to which the specified AutoFilter applies.</param>
            /// <param name="fieldIndex">The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).</param>
            /// <param name="iconSetType">The icon set type.</param>
            /// <param name="iconId">The icon id.</param>
            /// <param name="matchBlanks">Match all blank cell in the list.</param>
            /// <param name="refresh">Refresh auto filters to hide or unhide the rows.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PutWorksheetIconFilterRequest(string name, string sheetName, string range, int? fieldIndex, string iconSetType, int? iconId, bool? matchBlanks = null, bool? refresh = null, string folder = null, string storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.range = range;
                this.fieldIndex = fieldIndex;
                this.iconSetType = iconSetType;
                this.iconId = iconId;
                this.matchBlanks = matchBlanks;
                this.refresh = refresh;
                this.folder = folder;
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
        /// Represents the range to which the specified AutoFilter applies.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).
        /// </summary>
        public int? fieldIndex { get; set; }


        /// <summary>
        /// The icon set type.
        /// </summary>
        public string iconSetType { get; set; }


        /// <summary>
        /// The icon id.
        /// </summary>
        public int? iconId { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetIconFilter");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetIconFilter");
            }

            // verify the required parameter 'range' is set
            if (string.IsNullOrEmpty (this.range ))
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling PutWorksheetIconFilter");
            }

            // verify the required parameter 'fieldIndex' is set
            if ( this.fieldIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'fieldIndex' when calling PutWorksheetIconFilter");
            }

            // verify the required parameter 'iconSetType' is set
            if (string.IsNullOrEmpty (this.iconSetType ))
            {
                throw new ApiException(400, "Missing required parameter 'iconSetType' when calling PutWorksheetIconFilter");
            }

            // verify the required parameter 'iconId' is set
            if ( this.iconId == null)
            {
                throw new ApiException(400, "Missing required parameter 'iconId' when calling PutWorksheetIconFilter");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/autoFilter/iconFilter";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            path = UrlHelper.AddQueryParameterToUrl(path, "fieldIndex", this.fieldIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "iconSetType", this.iconSetType);
            path = UrlHelper.AddQueryParameterToUrl(path, "iconId", this.iconId);
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
