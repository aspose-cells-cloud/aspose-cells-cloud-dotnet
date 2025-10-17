// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitTextRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SplitText" /> operation.
    /// </summary>
    public class SplitTextRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTextRequest"/> class.
        /// </summary>
        public SplitTextRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTextRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="splitDelimitersType"></param>
        /// <param name="customDelimiter"></param>
        /// <param name="keepDelimitersInResultingCells"></param>
        /// <param name="keepDelimitersPosition"></param>
        /// <param name="howToSplit"></param>
        /// <param name="worksheet"></param>
        /// <param name="range"></param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="region">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public SplitTextRequest(string spreadsheet,string splitDelimitersType, string customDelimiter, bool? keepDelimitersInResultingCells =false, string keepDelimitersPosition = null, string howToSplit = null, string worksheet = null, string range = null)
        {
            this.Spreadsheet = spreadsheet;
            this.splitDelimitersType = splitDelimitersType;
            this.customDelimiter = customDelimiter;
            this.keepDelimitersInResultingCells = keepDelimitersInResultingCells;
            this.keepDelimitersPosition = keepDelimitersPosition;
            this.HowToSplit = howToSplit;
            this.worksheet = worksheet;
            this.range = range;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.region = region;
            this.password = password;
        }

        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Gets or sets splitDelimitersType.
        /// </summary>
        public string splitDelimitersType { get; set; }


        /// <summary>
        /// Gets or sets customDelimiter.
        /// </summary>
        public string customDelimiter { get; set; }


        /// <summary>
        /// Gets or sets keepDelimitersInResultingCells.
        /// </summary>
        public bool? keepDelimitersInResultingCells { get; set; }


        /// <summary>
        /// Gets or sets keepDelimitersPosition.
        /// </summary>
        public string keepDelimitersPosition { get; set; }


        /// <summary>
        /// Gets or sets HowToSplit.
        /// </summary>
        public string HowToSplit { get; set; }


        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Gets or sets range.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string region { get; set; }


        /// <summary>
        /// The password for opening spreadsheet file.
        /// </summary>
        public string password { get; set; }


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
            // verify the required parameter 'spreadsheet' is set
            // if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            // {
            //     throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling SplitText");
            // }

            // verify the required parameter 'splitDelimitersType' is set
            if (string.IsNullOrEmpty (this.splitDelimitersType ))
            {
                throw new ApiException(400, "Missing required parameter 'splitDelimitersType' when calling SplitText");
            }

            // verify the required parameter 'customDelimiter' is set
            if (string.IsNullOrEmpty (this.customDelimiter ))
            {
                throw new ApiException(400, "Missing required parameter 'customDelimiter' when calling SplitText");
            }

            // verify the required parameter 'keepDelimitersInResultingCells' is set
            // if ( this.keepDelimitersInResultingCells == null)
            // {
            //     throw new ApiException(400, "Missing required parameter 'keepDelimitersInResultingCells' when calling SplitText");
            // }

            // verify the required parameter 'keepDelimitersPosition' is set
            // if (string.IsNullOrEmpty (this.keepDelimitersPosition ))
            // {
            //     throw new ApiException(400, "Missing required parameter 'keepDelimitersPosition' when calling SplitText");
            // }

            // verify the required parameter 'howToSplit' is set
            // if (string.IsNullOrEmpty (this.HowToSplit ))
            // {
            //     throw new ApiException(400, "Missing required parameter 'howToSplit' when calling SplitText");
            // }

            var path = baseUri + "/cells/content/split/text";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "splitDelimitersType", this.splitDelimitersType);
            path = UrlHelper.AddQueryParameterToUrl(path, "customDelimiter", this.customDelimiter);
            path = UrlHelper.AddQueryParameterToUrl(path, "keepDelimitersInResultingCells", this.keepDelimitersInResultingCells);
            path = UrlHelper.AddQueryParameterToUrl(path, "keepDelimitersPosition", this.keepDelimitersPosition);
            path = UrlHelper.AddQueryParameterToUrl(path, "howToSplit", this.HowToSplit);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.range))  path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

             if (!string.IsNullOrEmpty(Spreadsheet ) && System.IO.File.Exists(Spreadsheet )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(Spreadsheet);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(Spreadsheet), fileInfo.Name));
             }



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
