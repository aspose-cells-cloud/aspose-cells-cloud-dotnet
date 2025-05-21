// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetSparklineGroupRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetSparklineGroup" /> operation.
    /// </summary>
    public class PutWorksheetSparklineGroupRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetSparklineGroupRequest"/> class.
        /// </summary>
        public PutWorksheetSparklineGroupRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutWorksheetSparklineGroupRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="type">Represents the sparkline types(Line/Column/Stacked).</param>
            /// <param name="dataRange">Specifies the data range of the sparkline group.</param>
            /// <param name="isVertical">Specifies whether to plot the sparklines from the data range by row or by column.</param>
            /// <param name="locationRange">Specifies where the sparklines to be placed.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PutWorksheetSparklineGroupRequest(string name, string sheetName, string type, string dataRange, bool? isVertical, string locationRange, string folder = null, string storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.type = type;
                this.dataRange = dataRange;
                this.isVertical = isVertical;
                this.locationRange = locationRange;
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
        /// Represents the sparkline types(Line/Column/Stacked).
        /// </summary>
        public string type { get; set; }


        /// <summary>
        /// Specifies the data range of the sparkline group.
        /// </summary>
        public string dataRange { get; set; }


        /// <summary>
        /// Specifies whether to plot the sparklines from the data range by row or by column.
        /// </summary>
        public bool? isVertical { get; set; }


        /// <summary>
        /// Specifies where the sparklines to be placed.
        /// </summary>
        public string locationRange { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetSparklineGroup");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetSparklineGroup");
            }

            // verify the required parameter 'type' is set
            if (string.IsNullOrEmpty (this.type ))
            {
                throw new ApiException(400, "Missing required parameter 'type' when calling PutWorksheetSparklineGroup");
            }

            // verify the required parameter 'dataRange' is set
            if (string.IsNullOrEmpty (this.dataRange ))
            {
                throw new ApiException(400, "Missing required parameter 'dataRange' when calling PutWorksheetSparklineGroup");
            }

            // verify the required parameter 'isVertical' is set
            if ( this.isVertical == null)
            {
                throw new ApiException(400, "Missing required parameter 'isVertical' when calling PutWorksheetSparklineGroup");
            }

            // verify the required parameter 'locationRange' is set
            if (string.IsNullOrEmpty (this.locationRange ))
            {
                throw new ApiException(400, "Missing required parameter 'locationRange' when calling PutWorksheetSparklineGroup");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/sparklineGroups";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "type", this.type);
            path = UrlHelper.AddQueryParameterToUrl(path, "dataRange", this.dataRange);
            path = UrlHelper.AddQueryParameterToUrl(path, "isVertical", this.isVertical);
            path = UrlHelper.AddQueryParameterToUrl(path, "locationRange", this.locationRange);
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
