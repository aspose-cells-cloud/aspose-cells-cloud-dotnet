// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertChartToImageRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.ConvertChartToImage" /> operation.
    /// </summary>
    public class ConvertChartToImageRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertChartToImageRequest"/> class.
        /// </summary>
        public ConvertChartToImageRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertChartToImageRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="worksheet"></param>
        /// <param name="chartIndex"></param>
        /// <param name="format">(Required) The desired image type (e.g., svg, png, jpg).</param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="fontsLocation">Use Custom fonts.</param>
        /// <param name="regoin">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public ConvertChartToImageRequest(string  spreadsheet, string  worksheet, int?  chartIndex, string  format, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, string  regoin = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.worksheet = worksheet;
            this.chartIndex = chartIndex;
            this.format = format;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.fontsLocation = fontsLocation;
            this.regoin = regoin;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Gets or sets chartIndex.
        /// </summary>
        public int? chartIndex { get; set; }


        /// <summary>
        /// (Required) The desired image type (e.g., svg, png, jpg).
        /// </summary>
        public string format { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// Use Custom fonts.
        /// </summary>
        public string fontsLocation { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string regoin { get; set; }


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
            if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            {
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling ConvertChartToImage");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling ConvertChartToImage");
            }

            // verify the required parameter 'chartIndex' is set
            if ( this.chartIndex == null)
            {
                throw new ApiException(400, "Missing required parameter 'chartIndex' when calling ConvertChartToImage");
            }

            // verify the required parameter 'format' is set
            if (string.IsNullOrEmpty (this.format ))
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling ConvertChartToImage");
            }

            var path = baseUri + "/cells/convert/chart/image";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            path = UrlHelper.AddQueryParameterToUrl(path, "chartIndex", this.chartIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.fontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.fontsLocation);
            if (!string.IsNullOrEmpty(this.regoin))  path = UrlHelper.AddQueryParameterToUrl(path, "regoin", this.regoin);
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
