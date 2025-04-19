// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookSaveAsRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookSaveAs" /> operation.
    /// </summary>
    public class PostWorkbookSaveAsRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookSaveAsRequest"/> class.
        /// </summary>
        public PostWorkbookSaveAsRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookSaveAsRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="newfilename">newfilename to save the result.The `newfilename` should encompass both the filename and extension.</param>
        /// <param name="saveOptions"></param>
        /// <param name="isAutoFitRows">Indicates if Autofit rows in workbook.</param>
        /// <param name="isAutoFitColumns">Indicates if Autofit columns in workbook.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        /// <param name="outStorageName">The storage name where the output file is situated.</param>
        /// <param name="checkExcelRestriction">Whether check restriction of excel file when user modify cells related objects.</param>
        /// <param name="region">The regional settings for workbook.</param>
        /// <param name="pageWideFitOnPerSheet">The page wide fit on worksheet.</param>
        /// <param name="pageTallFitOnPerSheet">The page tall fit on worksheet.</param>
        /// <param name="fontsLocation">Use Custom fonts.</param>
        public PostWorkbookSaveAsRequest(string name, string newfilename, SaveOptions saveOptions = null, bool? isAutoFitRows = null, bool? isAutoFitColumns = null, string folder = null, string storageName = null, string outStorageName = null, bool? checkExcelRestriction = null, string region = null, bool? pageWideFitOnPerSheet = null, bool? pageTallFitOnPerSheet = null, string fontsLocation = null)
        {
            this.name = name;
            this.newfilename = newfilename;
            this.saveOptions = saveOptions;
            this.isAutoFitRows = isAutoFitRows;
            this.isAutoFitColumns = isAutoFitColumns;
            this.folder = folder;
            this.storageName = storageName;
            this.outStorageName = outStorageName;
            this.checkExcelRestriction = checkExcelRestriction;
            this.region = region;
            this.pageWideFitOnPerSheet = pageWideFitOnPerSheet;
            this.pageTallFitOnPerSheet = pageTallFitOnPerSheet;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The workbook name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// newfilename to save the result.The `newfilename` should encompass both the filename and extension.
        /// </summary>
        public string newfilename { get; set; }


        /// <summary>
        /// Gets or sets saveOptions.
        /// </summary>
        public SaveOptions saveOptions { get; set; }


        /// <summary>
        /// Indicates if Autofit rows in workbook.
        /// </summary>
        public bool? isAutoFitRows { get; set; }


        /// <summary>
        /// Indicates if Autofit columns in workbook.
        /// </summary>
        public bool? isAutoFitColumns { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }


        /// <summary>
        /// The storage name where the output file is situated.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.
        /// </summary>
        public bool? checkExcelRestriction { get; set; }


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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookSaveAs");
            }

            // verify the required parameter 'newfilename' is set
            if (string.IsNullOrEmpty (this.newfilename ))
            {
                throw new ApiException(400, "Missing required parameter 'newfilename' when calling PostWorkbookSaveAs");
            }

            var path = baseUri + "/cells/{name}/SaveAs";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddQueryParameterToUrl(path, "newfilename", this.newfilename);
            if(this.isAutoFitRows != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isAutoFitRows", this.isAutoFitRows);
            if(this.isAutoFitColumns != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isAutoFitColumns", this.isAutoFitColumns);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if(this.pageWideFitOnPerSheet != null)  path = UrlHelper.AddQueryParameterToUrl(path, "pageWideFitOnPerSheet", this.pageWideFitOnPerSheet);
            if(this.pageTallFitOnPerSheet != null)  path = UrlHelper.AddQueryParameterToUrl(path, "pageTallFitOnPerSheet", this.pageTallFitOnPerSheet);
            if (!string.IsNullOrEmpty(this.FontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.saveOptions != null ? JsonConvert.SerializeObject(this.saveOptions) : null);
            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
