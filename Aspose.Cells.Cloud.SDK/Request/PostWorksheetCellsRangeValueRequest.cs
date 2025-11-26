// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorksheetCellsRangeValueRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorksheetCellsRangeValue" /> operation.
    /// </summary>
    public class PostWorksheetCellsRangeValueRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorksheetCellsRangeValueRequest"/> class.
        /// </summary>
        public PostWorksheetCellsRangeValueRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostWorksheetCellsRangeValueRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="range">The range in worksheet. </param>
            /// <param name="value">Input value.</param>
            /// <param name="isConverted">True: converted to other data type if appropriate.</param>
            /// <param name="setStyle">True: set the number format to cell's style when converting to other data type.</param>
            /// <param name="folder">Original workbook folder.</param>
            /// <param name="storageName">Storage name.</param>
            public PostWorksheetCellsRangeValueRequest(string  name, string  sheetName, Range  range, string  value, bool?  isConverted = null, bool?  setStyle = null, string  folder = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.range = range;
                this.Value = value;
                this.isConverted = isConverted;
                this.setStyle = setStyle;
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
        /// The range in worksheet. 
        /// </summary>
        public Range range { get; set; }


        /// <summary>
        /// Input value.
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// True: converted to other data type if appropriate.
        /// </summary>
        public bool? isConverted { get; set; }


        /// <summary>
        /// True: set the number format to cell's style when converting to other data type.
        /// </summary>
        public bool? setStyle { get; set; }


        /// <summary>
        /// Original workbook folder.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// Storage name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorksheetCellsRangeValue");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostWorksheetCellsRangeValue");
            }

            // verify the required parameter 'range' is set
            if ( this.range == null)
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling PostWorksheetCellsRangeValue");
            }

            // verify the required parameter 'value' is set
            if (string.IsNullOrEmpty (this.Value ))
            {
                throw new ApiException(400, "Missing required parameter 'value' when calling PostWorksheetCellsRangeValue");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/ranges/value";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "value", this.Value);
            if(this.isConverted != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isConverted", this.isConverted);
            if(this.setStyle != null)  path = UrlHelper.AddQueryParameterToUrl(path, "setStyle", this.setStyle);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.range != null ? JsonConvert.SerializeObject(this.range) : null);


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
