// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostConvertWorksheetToImageRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostConvertWorksheetToImage" /> operation.
    /// </summary>
    public class PostConvertWorksheetToImageRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConvertWorksheetToImageRequest"/> class.
        /// </summary>
        public PostConvertWorksheetToImageRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostConvertWorksheetToImageRequest"/> class.
            /// </summary>
            /// <param name="convertWorksheetOptions"></param>
            /// <param name="fontsLocation">Use Custom fonts.</param>
            public PostConvertWorksheetToImageRequest(ConvertWorksheetOptions  convertWorksheetOptions, string  fontsLocation = null)
            {
                this.convertWorksheetOptions = convertWorksheetOptions;
                this.FontsLocation = fontsLocation;
            }
        
        /// <summary>
        /// Gets or sets convertWorksheetOptions.
        /// </summary>
        public ConvertWorksheetOptions convertWorksheetOptions { get; set; }


        /// <summary>
        /// Use Custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }
        

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
            // verify the required parameter 'convertWorksheetOptions' is set
            if ( this.convertWorksheetOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'convertWorksheetOptions' when calling PostConvertWorksheetToImage");
            }

            var path = baseUri + "/cells/convertWorksheetToImage";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (!string.IsNullOrEmpty(this.FontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.convertWorksheetOptions != null ? JsonConvert.SerializeObject(this.convertWorksheetOptions) : null);


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
