// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostCopyWorksheetColumnsRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostCopyWorksheetColumns" /> operation.
    /// </summary>
    public class PostCopyWorksheetColumnsRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyWorksheetColumnsRequest"/> class.
        /// </summary>
        public PostCopyWorksheetColumnsRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyWorksheetColumnsRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="sourceColumnIndex">Source column index</param>
        /// <param name="destinationColumnIndex">Destination column index</param>
        /// <param name="columnNumber">The copied column number</param>
        /// <param name="worksheet">The destination worksheet name.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        public PostCopyWorksheetColumnsRequest(string name, string sheetName, int? sourceColumnIndex, int? destinationColumnIndex, int? columnNumber, string worksheet = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.sourceColumnIndex = sourceColumnIndex;
            this.destinationColumnIndex = destinationColumnIndex;
            this.columnNumber = columnNumber;
            this.worksheet = worksheet;
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
        /// Source column index
        /// </summary>
        public int? sourceColumnIndex { get; set; }

        /// <summary>
        /// Destination column index
        /// </summary>
        public int? destinationColumnIndex { get; set; }

        /// <summary>
        /// The copied column number
        /// </summary>
        public int? columnNumber { get; set; }

        /// <summary>
        /// The destination worksheet name.
        /// </summary>
        public string worksheet { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyWorksheetColumns");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostCopyWorksheetColumns");
            }

            // verify the required parameter 'sourceColumnIndex' is set
            if ( this.sourceColumnIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceColumnIndex' when calling PostCopyWorksheetColumns");
            }

            // verify the required parameter 'destinationColumnIndex' is set
            if ( this.destinationColumnIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'destinationColumnIndex' when calling PostCopyWorksheetColumns");
            }

            // verify the required parameter 'columnNumber' is set
            if ( this.columnNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'columnNumber' when calling PostCopyWorksheetColumns");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/cells/columns/copy";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "sourceColumnIndex", this.sourceColumnIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "destinationColumnIndex", this.destinationColumnIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "columnNumber", this.columnNumber);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
