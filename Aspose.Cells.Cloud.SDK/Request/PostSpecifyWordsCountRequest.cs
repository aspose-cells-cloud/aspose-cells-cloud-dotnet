// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSpecifyWordsCountRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostSpecifyWordsCount" /> operation.
    /// </summary>
    public class PostSpecifyWordsCountRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSpecifyWordsCountRequest"/> class.
        /// </summary>
        public PostSpecifyWordsCountRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostSpecifyWordsCountRequest"/> class.
            /// </summary>
            /// <param name="specifyWordsCountOptions"></param>
            public PostSpecifyWordsCountRequest(SpecifyWordsCountOptions  specifyWordsCountOptions)
            {
                this.specifyWordsCountOptions = specifyWordsCountOptions;
            }
        
        /// <summary>
        /// Gets or sets specifyWordsCountOptions.
        /// </summary>
        public SpecifyWordsCountOptions specifyWordsCountOptions { get; set; }
        

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
            // verify the required parameter 'specifyWordsCountOptions' is set
            if ( this.specifyWordsCountOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'specifyWordsCountOptions' when calling PostSpecifyWordsCount");
            }

            var path = baseUri + "/cells/specifywordscount";
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

            localVarPostBody = ( this.specifyWordsCountOptions != null ? JsonConvert.SerializeObject(this.specifyWordsCountOptions) : null);


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
