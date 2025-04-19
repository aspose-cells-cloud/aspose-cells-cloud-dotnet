// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetWorksheetAutoshapeWithFormatRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.GetWorksheetAutoshapeWithFormat" /> operation.
    /// </summary>
    public class GetWorksheetAutoshapeWithFormatRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorksheetAutoshapeWithFormatRequest"/> class.
        /// </summary>
        public GetWorksheetAutoshapeWithFormatRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorksheetAutoshapeWithFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="sheetName">Worksheet name.</param>
        /// <param name="autoshapeNumber">The autoshape number.</param>
        /// <param name="format">Autoshape conversion format.</param>
        /// <param name="folder">The document folder.</param>
        /// <param name="storageName">Storage name.</param>
        public GetWorksheetAutoshapeWithFormatRequest(string name, string sheetName, int? autoshapeNumber, string format = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.autoshapeNumber = autoshapeNumber;
            this.format = format;
            this.folder = folder;
            this.storageName = storageName;
        }

        /// <summary>
        /// The workbook name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Worksheet name.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// The autoshape number.
        /// </summary>
        public int? autoshapeNumber { get; set; }


        /// <summary>
        /// Autoshape conversion format.
        /// </summary>
        public string format { get; set; }


        /// <summary>
        /// The document folder.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// Storage name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetWorksheetAutoshapeWithFormat");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling GetWorksheetAutoshapeWithFormat");
            }

            // verify the required parameter 'autoshapeNumber' is set
            if ( this.autoshapeNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'autoshapeNumber' when calling GetWorksheetAutoshapeWithFormat");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/autoshapes/{autoshapeNumber}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddPathParameter(path, "autoshapeNumber", this.autoshapeNumber);
            if (!string.IsNullOrEmpty(this.format))  path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "GET", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
