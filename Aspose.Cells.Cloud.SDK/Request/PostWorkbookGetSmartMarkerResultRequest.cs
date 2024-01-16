// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookGetSmartMarkerResultRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookGetSmartMarkerResult" /> operation.
    /// </summary>
    public class PostWorkbookGetSmartMarkerResultRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookGetSmartMarkerResultRequest"/> class.
        /// </summary>
        public PostWorkbookGetSmartMarkerResultRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookGetSmartMarkerResultRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="xmlFile">The xml file full path, if empty the data is read from request body.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="outPath">The path to save result</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        /// <param name="outStorageName">The storage name where the result file is situated.</param>
        public PostWorkbookGetSmartMarkerResultRequest(string name, string xmlFile = null, string folder = null, string outPath = null, string storageName = null, string outStorageName = null)
        {
            this.name = name;
            this.xmlFile = xmlFile;
            this.folder = folder;
            this.outPath = outPath;
            this.storageName = storageName;
            this.outStorageName = outStorageName;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The xml file full path, if empty the data is read from request body.
        /// </summary>
        public string xmlFile { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The path to save result
        /// </summary>
        public string outPath { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// The storage name where the result file is situated.
        /// </summary>
        public string outStorageName { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookGetSmartMarkerResult");
            }

            var path = baseUri + "/cells/{name}/smartmarker";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.xmlFile))  path = UrlHelper.AddQueryParameterToUrl(path, "xmlFile", this.xmlFile);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
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
