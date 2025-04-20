// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CheckWrokbookExternalReferenceRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.CheckWrokbookExternalReference" /> operation.
    /// </summary>
    public class CheckWrokbookExternalReferenceRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWrokbookExternalReferenceRequest"/> class.
        /// </summary>
        public CheckWrokbookExternalReferenceRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWrokbookExternalReferenceRequest"/> class.
        /// </summary>
        /// <param name="checkExternalReferenceOptions"></param>
        public CheckWrokbookExternalReferenceRequest(CheckExternalReferenceOptions checkExternalReferenceOptions)
        {
            this.checkExternalReferenceOptions = checkExternalReferenceOptions;
        }

        /// <summary>
        /// Gets or sets checkExternalReferenceOptions.
        /// </summary>
        public CheckExternalReferenceOptions checkExternalReferenceOptions { get; set; }



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
            // verify the required parameter 'checkExternalReferenceOptions' is set
            if ( this.checkExternalReferenceOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'checkExternalReferenceOptions' when calling CheckWrokbookExternalReference");
            }

            var path = baseUri + "/cells/checkexternalreference";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.checkExternalReferenceOptions != null ? JsonConvert.SerializeObject(this.checkExternalReferenceOptions) : null);
            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
