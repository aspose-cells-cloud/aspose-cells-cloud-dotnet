// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFileRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.CopyFile" /> operation.
    /// </summary>
    public class CopyFileRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        public CopyFileRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="destPath"></param>
        /// <param name="srcStorageName"></param>
        /// <param name="destStorageName"></param>
        /// <param name="versionId"></param>
        public CopyFileRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.srcStorageName = srcStorageName;
            this.destStorageName = destStorageName;
            this.versionId = versionId;
        }

        /// <summary>
        /// Gets or sets srcPath.
        /// </summary>
        public string srcPath { get; set; }

        /// <summary>
        /// Gets or sets destPath.
        /// </summary>
        public string destPath { get; set; }

        /// <summary>
        /// Gets or sets srcStorageName.
        /// </summary>
        public string srcStorageName { get; set; }

        /// <summary>
        /// Gets or sets destStorageName.
        /// </summary>
        public string destStorageName { get; set; }

        /// <summary>
        /// Gets or sets versionId.
        /// </summary>
        public string versionId { get; set; }


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
            // verify the required parameter 'srcPath' is set
            if (string.IsNullOrEmpty (this.srcPath ))
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (string.IsNullOrEmpty (this.destPath ))
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }

            var path = baseUri + "/cells/storage/file/copy/{srcPath}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "srcPath", this.srcPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "destPath", this.destPath);
            if (!string.IsNullOrEmpty(this.srcStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "srcStorageName", this.srcStorageName);
            if (!string.IsNullOrEmpty(this.destStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "destStorageName", this.destStorageName);
            if (!string.IsNullOrEmpty(this.versionId))  path = UrlHelper.AddQueryParameterToUrl(path, "versionId", this.versionId);
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
