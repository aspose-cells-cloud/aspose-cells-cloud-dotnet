// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetOleObjectRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetOleObject" /> operation.
    /// </summary>
    public class PutWorksheetOleObjectRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetOleObjectRequest"/> class.
        /// </summary>
        public PutWorksheetOleObjectRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetOleObjectRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="sheetName">The worsheet name.</param>
        /// <param name="upperLeftRow">Upper left row index</param>
        /// <param name="upperLeftColumn">Upper left column index</param>
        /// <param name="height">Height of oleObject, in unit of pixel</param>
        /// <param name="width">Width of oleObject, in unit of pixel</param>
        /// <param name="oleFile">OLE filename path(full file name).</param>
        /// <param name="imageFile">Image filename path(full file name).</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        public PutWorksheetOleObjectRequest(string name, string sheetName, int? upperLeftRow = null, int? upperLeftColumn = null, int? height = null, int? width = null, string oleFile = null, string imageFile = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.upperLeftRow = upperLeftRow;
            this.upperLeftColumn = upperLeftColumn;
            this.height = height;
            this.width = width;
            this.oleFile = oleFile;
            this.imageFile = imageFile;
            this.folder = folder;
            this.storageName = storageName;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The worsheet name.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Upper left row index
        /// </summary>
        public int? upperLeftRow { get; set; }

        /// <summary>
        /// Upper left column index
        /// </summary>
        public int? upperLeftColumn { get; set; }

        /// <summary>
        /// Height of oleObject, in unit of pixel
        /// </summary>
        public int? height { get; set; }

        /// <summary>
        /// Width of oleObject, in unit of pixel
        /// </summary>
        public int? width { get; set; }

        /// <summary>
        /// OLE filename path(full file name).
        /// </summary>
        public string oleFile { get; set; }

        /// <summary>
        /// Image filename path(full file name).
        /// </summary>
        public string imageFile { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetOleObject");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetOleObject");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/oleobjects";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if(this.upperLeftRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftRow", this.upperLeftRow);
            if(this.upperLeftColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftColumn", this.upperLeftColumn);
            if(this.height != null)  path = UrlHelper.AddQueryParameterToUrl(path, "height", this.height);
            if(this.width != null)  path = UrlHelper.AddQueryParameterToUrl(path, "width", this.width);
            if (!string.IsNullOrEmpty(this.oleFile))  path = UrlHelper.AddQueryParameterToUrl(path, "oleFile", this.oleFile);
            if (!string.IsNullOrEmpty(this.imageFile))  path = UrlHelper.AddQueryParameterToUrl(path, "imageFile", this.imageFile);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
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
