// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostCopyWorksheetRowsRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostCopyWorksheetRows" /> operation.
    /// </summary>
    public class PostCopyWorksheetRowsRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyWorksheetRowsRequest"/> class.
        /// </summary>
        public PostCopyWorksheetRowsRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostCopyWorksheetRowsRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="sourceRowIndex">Source row index</param>
            /// <param name="destinationRowIndex">Destination row index</param>
            /// <param name="rowNumber">The copied row number</param>
            /// <param name="worksheet">The worksheet name.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PostCopyWorksheetRowsRequest(string  name, string  sheetName, int?  sourceRowIndex, int?  destinationRowIndex, int?  rowNumber, string  worksheet = null, string  folder = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.sourceRowIndex = sourceRowIndex;
                this.destinationRowIndex = destinationRowIndex;
                this.rowNumber = rowNumber;
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
        /// Source row index
        /// </summary>
        public int? sourceRowIndex { get; set; }


        /// <summary>
        /// Destination row index
        /// </summary>
        public int? destinationRowIndex { get; set; }


        /// <summary>
        /// The copied row number
        /// </summary>
        public int? rowNumber { get; set; }


        /// <summary>
        /// The worksheet name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyWorksheetRows");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostCopyWorksheetRows");
            }

            // verify the required parameter 'sourceRowIndex' is set
            if ( this.sourceRowIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceRowIndex' when calling PostCopyWorksheetRows");
            }

            // verify the required parameter 'destinationRowIndex' is set
            if ( this.destinationRowIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'destinationRowIndex' when calling PostCopyWorksheetRows");
            }

            // verify the required parameter 'rowNumber' is set
            if ( this.rowNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'rowNumber' when calling PostCopyWorksheetRows");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/cells/rows/copy";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "sourceRowIndex", this.sourceRowIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "destinationRowIndex", this.destinationRowIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "rowNumber", this.rowNumber);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
