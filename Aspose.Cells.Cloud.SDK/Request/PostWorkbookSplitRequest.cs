// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookSplitRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookSplit" /> operation.
    /// </summary>
    public class PostWorkbookSplitRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookSplitRequest"/> class.
        /// </summary>
        public PostWorkbookSplitRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookSplitRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="format">Split format.</param>
        /// <param name="outFolder"></param>
        /// <param name="from">Start worksheet index.</param>
        /// <param name="to">End worksheet index.</param>
        /// <param name="horizontalResolution">Image horizontal resolution.</param>
        /// <param name="verticalResolution">Image vertical resolution.</param>
        /// <param name="splitNameRule">rule name : sheetname  newguid </param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        /// <param name="outStorageName"></param>
        public PostWorkbookSplitRequest(string name, string format = null, string outFolder = null, int? from = null, int? to = null, int? horizontalResolution = null, int? verticalResolution = null, string splitNameRule = null, string folder = null, string storageName = null, string outStorageName = null)
        {
            this.name = name;
            this.format = format;
            this.outFolder = outFolder;
            this.from = from;
            this.to = to;
            this.horizontalResolution = horizontalResolution;
            this.verticalResolution = verticalResolution;
            this.splitNameRule = splitNameRule;
            this.folder = folder;
            this.storageName = storageName;
            this.outStorageName = outStorageName;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Split format.
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Gets or sets outFolder.
        /// </summary>
        public string outFolder { get; set; }

        /// <summary>
        /// Start worksheet index.
        /// </summary>
        public int? from { get; set; }

        /// <summary>
        /// End worksheet index.
        /// </summary>
        public int? to { get; set; }

        /// <summary>
        /// Image horizontal resolution.
        /// </summary>
        public int? horizontalResolution { get; set; }

        /// <summary>
        /// Image vertical resolution.
        /// </summary>
        public int? verticalResolution { get; set; }

        /// <summary>
        /// rule name : sheetname  newguid 
        /// </summary>
        public string splitNameRule { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// Gets or sets outStorageName.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookSplit");
            }

            var path = baseUri + "/cells/{name}/split";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.format))  path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.outFolder))  path = UrlHelper.AddQueryParameterToUrl(path, "outFolder", this.outFolder);
            if(this.from != null)  path = UrlHelper.AddQueryParameterToUrl(path, "from", this.from);
            if(this.to != null)  path = UrlHelper.AddQueryParameterToUrl(path, "to", this.to);
            if(this.horizontalResolution != null)  path = UrlHelper.AddQueryParameterToUrl(path, "horizontalResolution", this.horizontalResolution);
            if(this.verticalResolution != null)  path = UrlHelper.AddQueryParameterToUrl(path, "verticalResolution", this.verticalResolution);
            if (!string.IsNullOrEmpty(this.splitNameRule))  path = UrlHelper.AddQueryParameterToUrl(path, "splitNameRule", this.splitNameRule);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
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
