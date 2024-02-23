// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutConvertWorkbookRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutConvertWorkbook" /> operation.
    /// </summary>
    public class PutConvertWorkbookRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertWorkbookRequest"/> class.
        /// </summary>
        public PutConvertWorkbookRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertWorkbookRequest"/> class.
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="format">The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).</param>
        /// <param name="password">The password needed to open an Excel file.</param>
        /// <param name="outPath">Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        /// <param name="checkExcelRestriction">Whether check restriction of excel file when user modify cells related objects.</param>
        /// <param name="streamFormat">The format of the input file stream. </param>
        /// <param name="region">The regional settings for workbook.</param>
        /// <param name="pageWideFitOnPerSheet">The page wide fit on worksheet.</param>
        /// <param name="pageTallFitOnPerSheet">The page tall fit on worksheet.</param>
        public PutConvertWorkbookRequest(IDictionary<string, System.IO.Stream> file, string format = null, string password = null, string outPath = null, string storageName = null, bool? checkExcelRestriction = null, string streamFormat = null, string region = null, bool? pageWideFitOnPerSheet = null, bool? pageTallFitOnPerSheet = null)
        {
            this.File = file;
            this.format = format;
            this.password = password;
            this.outPath = outPath;
            this.storageName = storageName;
            this.checkExcelRestriction = checkExcelRestriction;
            this.streamFormat = streamFormat;
            this.region = region;
            this.pageWideFitOnPerSheet = pageWideFitOnPerSheet;
            this.pageTallFitOnPerSheet = pageTallFitOnPerSheet;
        }

        /// <summary>
        /// File to upload
        /// </summary>
        public IDictionary<string, System.IO.Stream> File { get; set; }

        /// <summary>
        /// The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// The password needed to open an Excel file.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.
        /// </summary>
        public string outPath { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.
        /// </summary>
        public bool? checkExcelRestriction { get; set; }

        /// <summary>
        /// The format of the input file stream. 
        /// </summary>
        public string streamFormat { get; set; }

        /// <summary>
        /// The regional settings for workbook.
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// The page wide fit on worksheet.
        /// </summary>
        public bool? pageWideFitOnPerSheet { get; set; }

        /// <summary>
        /// The page tall fit on worksheet.
        /// </summary>
        public bool? pageTallFitOnPerSheet { get; set; }


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
            // verify the required parameter 'file' is set
            if ( this.File == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling PutConvertWorkbook");
            }

            var path = baseUri + "/cells/convert";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (!string.IsNullOrEmpty(this.format))  path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (!string.IsNullOrEmpty(this.streamFormat))  path = UrlHelper.AddQueryParameterToUrl(path, "streamFormat", this.streamFormat);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if(this.pageWideFitOnPerSheet != null)  path = UrlHelper.AddQueryParameterToUrl(path, "pageWideFitOnPerSheet", this.pageWideFitOnPerSheet);
            if(this.pageTallFitOnPerSheet != null)  path = UrlHelper.AddQueryParameterToUrl(path, "pageTallFitOnPerSheet", this.pageTallFitOnPerSheet);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            if(  File !=null ){
                foreach (KeyValuePair<string, System.IO.Stream> keyValueFileParam in File )
                {
                    localVarFileParams.Add(keyValueFileParam.Key, UrlHelper.ToFileInfo(keyValueFileParam.Value, keyValueFileParam.Key));
                }
            }
            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
