// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsApi.cs">
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

namespace Aspose.Cells.Cloud.SDK.Api
{
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using FileInfo = Aspose.Cells.Cloud.SDK.Model.FileInfo;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System;
    using System.Threading.Tasks;
    /// <summary>
    /// Aspose.Cells Cloud API.
    /// </summary>
    public partial class CellsApi
    {
        //private readonly Invoker.ApiInvoker invoker;
        //private readonly string BaseUri;
        //private readonly string ClientId;
        //private readonly string ClientSecrent;
        //private readonly string Version;        
        //private readonly List<Invoker.IRequestHandler> requestHandlers;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="clientId"></param>
        ///// <param name="clientSecrent"></param>
        ///// <param name="baseUrl"></param>
        ///// <param name="version"></param>
        //public CellsApi(string clientId, string clientSecrent,string baseUrl = "https://api.aspose.cloud", string version ="v3.0")    
        //{
        //    this.Version = version;
        //    this.ClientSecrent = clientSecrent;
        //    this.ClientId = clientId;
        //    this.BaseUri = baseUrl;
        //    this.requestHandlers = new List<Invoker.IRequestHandler>();
        //    this.requestHandlers.Add(new Invoker.ApiExceptionRequestHandler());
        //    this.requestHandlers.Add(new Invoker.JwtTokenRequestHandler(baseUrl, clientId, clientSecrent));
        //    invoker = new Invoker.ApiInvoker(requestHandlers);
        //    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        //}

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoFilterRequest" /></param>
        public   AutoFilterResponse  GetWorksheetAutoFilter(GetWorksheetAutoFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AutoFilterResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetDateFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetDateFilter(PutWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFilter(PutWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetIconFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetIconFilter(PutWorksheetIconFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCustomFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetCustomFilter(PutWorksheetCustomFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetDynamicFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetDynamicFilter(PutWorksheetDynamicFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFilterTop10Request" /></param>
        public   CellsCloudResponse  PutWorksheetFilterTop10(PutWorksheetFilterTop10Request request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetColorFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetColorFilter(PutWorksheetColorFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMatchBlanksRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMatchBlanks(PostWorksheetMatchBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMatchNonBlanksRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMatchNonBlanks(PostWorksheetMatchNonBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetAutoFilterRefreshRequest" /></param>
        public   CellsCloudResponse  PostWorksheetAutoFilterRefresh(PostWorksheetAutoFilterRefreshRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetDateFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetDateFilter(DeleteWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetFilter(DeleteWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoshapesRequest" /></param>
        public   AutoShapesResponse  GetWorksheetAutoshapes(GetWorksheetAutoshapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AutoShapesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoshapeWithFormatRequest" /></param>
        public   Stream  GetWorksheetAutoshapeWithFormat(GetWorksheetAutoshapeWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchConvertRequest" /></param>
        public   Stream  PostBatchConvert(PostBatchConvertRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchProtectRequest" /></param>
        public Stream PostBatchProtect(PostBatchProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchLockRequest" /></param>
        public Stream PostBatchLock(PostBatchLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchUnlockRequest" /></param>
        public Stream PostBatchUnlock(PostBatchUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchSplitRequest" /></param>
        public Stream PostBatchSplit(PostBatchSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearContentsRequest" /></param>
        public   CellsCloudResponse  PostClearContents(PostClearContentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearFormatsRequest" /></param>
        public   CellsCloudResponse  PostClearFormats(PostClearFormatsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetRangeStyleRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetRangeStyle(PostUpdateWorksheetRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMerge(PostWorksheetMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetUnmergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetUnmerge(PostWorksheetUnmergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellsRequest" /></param>
        public   CellsResponse  GetWorksheetCells(GetWorksheetCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellRequest" /></param>
        public   string  GetWorksheetCell(GetWorksheetCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellStyleRequest" /></param>
        public   StyleResponse  GetWorksheetCellStyle(GetWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellSetValueRequest" /></param>
        public   CellResponse  PostWorksheetCellSetValue(PostWorksheetCellSetValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetCellStyleRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetCellStyle(PostUpdateWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetCellRangeValueRequest" /></param>
        public   CellsCloudResponse  PostSetCellRangeValue(PostSetCellRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyCellIntoCellRequest" /></param>
        public   CellsCloudResponse  PostCopyCellIntoCell(PostCopyCellIntoCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellHtmlStringRequest" /></param>
        public   string  GetCellHtmlString(GetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetCellHtmlStringRequest" /></param>
        public   CellsCloudResponse  PostSetCellHtmlString(PostSetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCellCalculateRequest" /></param>
        public   CellsCloudResponse  PostCellCalculate(PostCellCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCellCharactersRequest" /></param>
        public   CellsCloudResponse  PostCellCharacters(PostCellCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetColumnsRequest" /></param>
        public   ColumnsResponse  GetWorksheetColumns(GetWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ColumnsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetWorksheetColumnWidthRequest" /></param>
        public   CellsCloudResponse  PostSetWorksheetColumnWidth(PostSetWorksheetColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetColumnRequest" /></param>
        public   ColumnResponse  GetWorksheetColumn(GetWorksheetColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ColumnResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetColumns(PutInsertWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetColumns(DeleteWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostHideWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostHideWorksheetColumns(PostHideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnhideWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostUnhideWorksheetColumns(PostUnhideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostGroupWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostGroupWorksheetColumns(PostGroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUngroupWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostUngroupWorksheetColumns(PostUngroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheetColumns(PostCopyWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostColumnStyleRequest" /></param>
        public   CellsCloudResponse  PostColumnStyle(PostColumnStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetRowsRequest" /></param>
        public   RowsResponse  GetWorksheetRows(GetWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RowsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetRowRequest" /></param>
        public   RowResponse  GetWorksheetRow(GetWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RowResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRowRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetRow(DeleteWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetRows(DeleteWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetRows(PutInsertWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetRow(PutInsertWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetRow(PostUpdateWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostHideWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostHideWorksheetRows(PostHideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnhideWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostUnhideWorksheetRows(PostUnhideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostGroupWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostGroupWorksheetRows(PostGroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUngroupWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostUngroupWorksheetRows(PostUngroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheetRows(PostCopyWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostRowStyleRequest" /></param>
        public   CellsCloudResponse  PostRowStyle(PostRowStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellsCloudServicesHealthCheckRequest" /></param>
        public   string  GetCellsCloudServicesHealthCheck(GetCellsCloudServicesHealthCheckRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellsCloudServiceStatusRequest" /></param>
        public   string  GetCellsCloudServiceStatus(GetCellsCloudServiceStatusRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaRequest" /></param>
        public   ChartAreaResponse  GetChartArea(GetChartAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ChartAreaResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaFillFormatRequest" /></param>
        public   FillFormatResponse  GetChartAreaFillFormat(GetChartAreaFillFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FillFormatResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaBorderRequest" /></param>
        public   LineResponse  GetChartAreaBorder(GetChartAreaBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    LineResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartsRequest" /></param>
        public   ChartsResponse  GetWorksheetCharts(GetWorksheetChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ChartsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartRequest" /></param>
        public   Stream  GetWorksheetChart(GetWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetAddChartRequest" /></param>
        public   CellsCloudResponse  PutWorksheetAddChart(PutWorksheetAddChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetDeleteChartRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetDeleteChart(DeleteWorksheetDeleteChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChart(PostWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartLegendRequest" /></param>
        public   LegendResponse  GetWorksheetChartLegend(GetWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    LegendResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChartLegend(PostWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  PutWorksheetChartLegend(PutWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetChartLegend(DeleteWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetClearChartsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetClearCharts(DeleteWorksheetClearChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartTitleRequest" /></param>
        public   TitleResponse  GetWorksheetChartTitle(GetWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TitleResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChartTitle(PostWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  PutWorksheetChartTitle(PutWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetChartTitle(DeleteWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSeriesAxisRequest" /></param>
        public   AxisResponse  GetChartSeriesAxis(GetChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartCategoryAxisRequest" /></param>
        public   AxisResponse  GetChartCategoryAxis(GetChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartValueAxisRequest" /></param>
        public   AxisResponse  GetChartValueAxis(GetChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSecondCategoryAxisRequest" /></param>
        public   AxisResponse  GetChartSecondCategoryAxis(GetChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSecondValueAxisRequest" /></param>
        public   AxisResponse  GetChartSecondValueAxis(GetChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSeriesAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSeriesAxis(PostChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartCategoryAxisRequest" /></param>
        public   CellsCloudResponse  PostChartCategoryAxis(PostChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartValueAxisRequest" /></param>
        public   CellsCloudResponse  PostChartValueAxis(PostChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSecondCategoryAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSecondCategoryAxis(PostChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSecondValueAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSecondValueAxis(PostChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetConditionalFormattingsRequest" /></param>
        public   ConditionalFormattingsResponse  GetWorksheetConditionalFormattings(GetWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ConditionalFormattingsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetConditionalFormattingRequest" /></param>
        public   ConditionalFormattingResponse  GetWorksheetConditionalFormatting(GetWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ConditionalFormattingResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetConditionalFormattingRequest" /></param>
        public   CellsCloudResponse  PutWorksheetConditionalFormatting(PutWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatCondition(PutWorksheetFormatConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionAreaRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatConditionArea(PutWorksheetFormatConditionAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionConditionRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatConditionCondition(PutWorksheetFormatConditionConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormattings(DeleteWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormatting(DeleteWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingAreaRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormattingArea(DeleteWorksheetConditionalFormattingAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookRequest" /></param>
        public   Stream  GetWorkbook(GetWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutConvertWorkbookRequest" /></param>
        public   Stream  PutConvertWorkbook(PutConvertWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSaveAsRequest" /></param>
        public   SaveResponse  PostWorkbookSaveAs(PostWorkbookSaveAsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SaveResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPDFRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPDF(PostConvertWorkbookToPDFRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPNGRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPNG(PostConvertWorkbookToPNGRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToDocxRequest" /></param>
        public   FileInfo  PostConvertWorkbookToDocx(PostConvertWorkbookToDocxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPptxRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPptx(PostConvertWorkbookToPptxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToHtmlRequest" /></param>
        public   FileInfo  PostConvertWorkbookToHtml(PostConvertWorkbookToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToMarkdownRequest" /></param>
        public   FileInfo  PostConvertWorkbookToMarkdown(PostConvertWorkbookToMarkdownRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToJsonRequest" /></param>
        public   FileInfo  PostConvertWorkbookToJson(PostConvertWorkbookToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToSQLRequest" /></param>
        public   FileInfo  PostConvertWorkbookToSQL(PostConvertWorkbookToSQLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToCSVRequest" /></param>
        public   FileInfo  PostConvertWorkbookToCSV(PostConvertWorkbookToCSVRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("GetWorkSheetHyperlinks")]
        public HyperlinksResponse GetWorkSheetHyperlinks(GetWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<HyperlinksResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetHyperlinksRequest" /></param>
        public HyperlinksResponse  GetWorksheetHyperlinks(GetWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HyperlinksResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("GetWorkSheetHyperlink")]
        public   HyperlinkResponse  GetWorkSheetHyperlink(GetWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HyperlinkResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetHyperlinkRequest" /></param>
        public   HyperlinkResponse  GetWorksheetHyperlink(GetWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HyperlinkResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("DeleteWorkSheetHyperlink")]
        public CellsCloudResponse DeleteWorkSheetHyperlink(DeleteWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetHyperlink(DeleteWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("PostWorkSheetHyperlink")]
        public CellsCloudResponse PostWorkSheetHyperlink(PostWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }
        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  PostWorksheetHyperlink(PostWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("PutWorkSheetHyperlink")]
        public CellsCloudResponse PutWorkSheetHyperlink(PutWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }
        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  PutWorksheetHyperlink(PutWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("DeleteWorkSheetHyperlinks")]
        public CellsCloudResponse DeleteWorkSheetHyperlinks(DeleteWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetHyperlinksRequest" /></param>
        public CellsCloudResponse  DeleteWorksheetHyperlinks(DeleteWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAssembleRequest" /></param>
        public   FilesResult  PostAssemble(PostAssembleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCompressRequest" /></param>
        public   FilesResult  PostCompress(PostCompressRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportRequest" /></param>
        public   FilesResult  PostExport(PostExportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostMergeRequest" /></param>
        public   FileInfo  PostMerge(PostMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnlockRequest" /></param>
        public   FilesResult  PostUnlock(PostUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostLockRequest" /></param>
        public FilesResult PostLock(PostLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<FilesResult>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// Protect MS Excel and OpenDocument Spreadsheet by making them password protected.
        /// </summary>
        /// <param name="request">Request. <see cref="PostProtectRequest" /></param>
        public FilesResult PostProtect(PostProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<FilesResult>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSplitRequest" /></param>
        public FilesResult  PostSplit(PostSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchRequest" /></param>
        public   IList<TextItem>  PostSearch(PostSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    IList<TextItem>  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostReplaceRequest" /></param>
        public   FilesResult  PostReplace(PostReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostImportRequest" /></param>
        public   FilesResult  PostImport(PostImportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWatermarkRequest" /></param>
        public   FilesResult  PostWatermark(PostWatermarkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearObjectsRequest" /></param>
        public   FilesResult  PostClearObjects(PostClearObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostReverseRequest" /></param>
        public   FilesResult  PostReverse(PostReverseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostRepairRequest" /></param>
        public FilesResult PostRepair(PostRepairRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<FilesResult>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostRotateRequest" /></param>
        public FilesResult  PostRotate(PostRotateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostMetadataRequest" /></param>
        public   FilesResult  PostMetadata(PostMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetMetadataRequest" /></param>
        public   IList<CellsDocumentProperty>  GetMetadata(GetMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    IList<CellsDocumentProperty>  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMetadataRequest" /></param>
        public   FilesResult  DeleteMetadata(DeleteMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetListObjectsRequest" /></param>
        public   ListObjectsResponse  GetWorksheetListObjects(GetWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ListObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetListObjectRequest" /></param>
        public   Stream  GetWorksheetListObject(GetWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  PutWorksheetListObject(PutWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetListObjectsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetListObjects(DeleteWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetListObject(DeleteWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObject(PostWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectConvertToRangeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectConvertToRange(PostWorksheetListObjectConvertToRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectSummarizeWithPivotTableRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectSummarizeWithPivotTable(PostWorksheetListObjectSummarizeWithPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectSortTableRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectSortTable(PostWorksheetListObjectSortTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListColumnRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListColumn(PostWorksheetListColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListColumnsTotalRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListColumnsTotal(PostWorksheetListColumnsTotalRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetOleObjectsRequest" /></param>
        public   OleObjectsResponse  GetWorksheetOleObjects(GetWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    OleObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetOleObjectRequest" /></param>
        public   Stream  GetWorksheetOleObject(GetWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetOleObjectsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetOleObjects(DeleteWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetOleObject(DeleteWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetOleObject(PostUpdateWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  PutWorksheetOleObject(PutWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetVerticalPageBreaksRequest" /></param>
        public   VerticalPageBreaksResponse  GetVerticalPageBreaks(GetVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    VerticalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetHorizontalPageBreaksRequest" /></param>
        public   HorizontalPageBreaksResponse  GetHorizontalPageBreaks(GetHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HorizontalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetVerticalPageBreakRequest" /></param>
        public   VerticalPageBreakResponse  GetVerticalPageBreak(GetVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    VerticalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetHorizontalPageBreakRequest" /></param>
        public   HorizontalPageBreakResponse  GetHorizontalPageBreak(GetHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HorizontalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutVerticalPageBreakRequest" /></param>
        public   CellsCloudResponse  PutVerticalPageBreak(PutVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutHorizontalPageBreakRequest" /></param>
        public   CellsCloudResponse  PutHorizontalPageBreak(PutHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteVerticalPageBreaksRequest" /></param>
        public   CellsCloudResponse  DeleteVerticalPageBreaks(DeleteVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHorizontalPageBreaksRequest" /></param>
        public   CellsCloudResponse  DeleteHorizontalPageBreaks(DeleteHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteVerticalPageBreakRequest" /></param>
        public   CellsCloudResponse  DeleteVerticalPageBreak(DeleteVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHorizontalPageBreakRequest" /></param>
        public   CellsCloudResponse  DeleteHorizontalPageBreak(DeleteHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageSetupRequest" /></param>
        public   PageSetupResponse  GetPageSetup(GetPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSetupResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPageSetupRequest" /></param>
        public   CellsCloudResponse  PostPageSetup(PostPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public   CellsCloudResponse  DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderRequest" /></param>
        public   PageSectionsResponse  GetHeader(GetHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostHeaderRequest" /></param>
        public   CellsCloudResponse  PostHeader(PostHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetFooterRequest" /></param>
        public   PageSectionsResponse  GetFooter(GetFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostFooterRequest" /></param>
        public   CellsCloudResponse  PostFooter(PostFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPicturesRequest" /></param>
        public   PicturesResponse  GetWorksheetPictures(GetWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PicturesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPictureWithFormatRequest" /></param>
        public   Stream  GetWorksheetPictureWithFormat(GetWorksheetPictureWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetAddPictureRequest" /></param>
        public   CellsCloudResponse  PutWorksheetAddPicture(PutWorksheetAddPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("PostWorkSheetPicture")]
        public CellsCloudResponse PostWorkSheetPicture(PostWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }
        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPictureRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPicture(PostWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPictureRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPicture(DeleteWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        [Obsolete("DeleteWorkSheetPictures")]
        public CellsCloudResponse DeleteWorkSheetPictures(DeleteWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<CellsCloudResponse>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPicturesRequest" /></param>
        public CellsCloudResponse  DeleteWorksheetPictures(DeleteWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTablesRequest" /></param>
        public   PivotTablesResponse  GetWorksheetPivotTables(GetWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotTablesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableRequest" /></param>
        public   PivotTableResponse  GetWorksheetPivotTable(GetWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotTableResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetPivotTableFieldRequest" /></param>
        public   PivotFieldResponse  GetPivotTableField(GetPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFieldResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableFiltersRequest" /></param>
        public   PivotFiltersResponse  GetWorksheetPivotTableFilters(GetWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFiltersResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableFilterRequest" /></param>
        public   PivotFilterResponse  GetWorksheetPivotTableFilter(GetWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFilterResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetPivotTableRequest" /></param>
        public   CellsCloudResponse  PutWorksheetPivotTable(PutWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutPivotTableFieldRequest" /></param>
        public   CellsCloudResponse  PutPivotTableField(PutPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetPivotTableFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetPivotTableFilter(PutWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableFieldHideItemRequest" /></param>
        public   CellsCloudResponse  PostPivotTableFieldHideItem(PostPivotTableFieldHideItemRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableFieldMoveToRequest" /></param>
        public   CellsCloudResponse  PostPivotTableFieldMoveTo(PostPivotTableFieldMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableCellStyleRequest" /></param>
        public   CellsCloudResponse  PostPivotTableCellStyle(PostPivotTableCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableStyleRequest" /></param>
        public   CellsCloudResponse  PostPivotTableStyle(PostPivotTableStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableUpdatePivotFieldsRequest" /></param>
        public   CellsCloudResponse  PostPivotTableUpdatePivotFields(PostPivotTableUpdatePivotFieldsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableUpdatePivotFieldRequest" /></param>
        public   CellsCloudResponse  PostPivotTableUpdatePivotField(PostPivotTableUpdatePivotFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPivotTableCalculateRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPivotTableCalculate(PostWorksheetPivotTableCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPivotTableMoveRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPivotTableMove(PostWorksheetPivotTableMoveRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTablesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTables(DeleteWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTable(DeleteWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePivotTableFieldRequest" /></param>
        public   CellsCloudResponse  DeletePivotTableField(DeletePivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableFiltersRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTableFilters(DeleteWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTableFilter(DeleteWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        public   CellsDocumentPropertiesResponse  GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsDocumentPropertiesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        public   CellsDocumentPropertyResponse  GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsDocumentPropertyResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentPropertyRequest" /></param>
        public   CellsCloudResponse  PutDocumentProperty(PutDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertiesRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentProperties(DeleteDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangesRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRanges(PostWorksheetCellsRangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeMerge(PostWorksheetCellsRangeMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeUnMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeUnMerge(PostWorksheetCellsRangeUnMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeStyleRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeStyle(PostWorksheetCellsRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellsRangeValueRequest" /></param>
        public   RangeValueResponse  GetWorksheetCellsRangeValue(GetWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeValueRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeValue(PostWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeMoveToRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeMoveTo(PostWorksheetCellsRangeMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeOutlineBorderRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeOutlineBorder(PostWorksheetCellsRangeOutlineBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeColumnWidthRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeColumnWidth(PostWorksheetCellsRangeColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeRowHeightRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeRowHeight(PostWorksheetCellsRangeRowHeightRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCellsRangeRequest" /></param>
        public   CellsCloudResponse  PutWorksheetCellsRange(PutWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCellsRangeRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetCellsRange(DeleteWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetShapesRequest" /></param>
        public   ShapesResponse  GetWorksheetShapes(GetWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ShapesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetShapeRequest" /></param>
        public   ShapeResponse  GetWorksheetShape(GetWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ShapeResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  PutWorksheetShape(PutWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetShapesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetShapes(DeleteWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetShape(DeleteWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetShape(PostWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetGroupShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetGroupShape(PostWorksheetGroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetUngroupShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetUngroupShape(PostWorksheetUngroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetSparklineGroupsRequest" /></param>
        public   SparklineGroupsResponse  GetWorksheetSparklineGroups(GetWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SparklineGroupsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetSparklineGroupRequest" /></param>
        public   SparklineGroupResponse  GetWorksheetSparklineGroup(GetWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SparklineGroupResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetSparklineGroupsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetSparklineGroups(DeleteWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetSparklineGroup(DeleteWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  PutWorksheetSparklineGroup(PutWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  PostWorksheetSparklineGroup(PostWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostRunTaskRequest" /></param>
        public   Stream  PostRunTask(PostRunTaskRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostDigitalSignatureRequest" /></param>
        public   CellsCloudResponse  PostDigitalSignature(PostDigitalSignatureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostEncryptWorkbookRequest" /></param>
        public   CellsCloudResponse  PostEncryptWorkbook(PostEncryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDecryptWorkbookRequest" /></param>
        public   CellsCloudResponse  DeleteDecryptWorkbook(DeleteDecryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostProtectWorkbookRequest" /></param>
        public   CellsCloudResponse  PostProtectWorkbook(PostProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteUnProtectWorkbookRequest" /></param>
        public   CellsCloudResponse  DeleteUnProtectWorkbook(DeleteUnProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookDefaultStyleRequest" /></param>
        public   StyleResponse  GetWorkbookDefaultStyle(GetWorkbookDefaultStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookTextItemsRequest" /></param>
        public   TextItemsResponse  GetWorkbookTextItems(GetWorkbookTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNamesRequest" /></param>
        public   NamesResponse  GetWorkbookNames(GetWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    NamesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookNameRequest" /></param>
        public   CellsCloudResponse  PutWorkbookName(PutWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNameRequest" /></param>
        public   NameResponse  GetWorkbookName(GetWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    NameResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookNameRequest" /></param>
        public   CellsCloudResponse  PostWorkbookName(PostWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNameValueRequest" /></param>
        public   RangeValueResponse  GetWorkbookNameValue(GetWorkbookNameValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookNamesRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookNames(DeleteWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookNameRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookName(DeleteWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentProtectFromChangesRequest" /></param>
        public   CellsCloudResponse  PutDocumentProtectFromChanges(PutDocumentProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentUnProtectFromChangesRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentUnProtectFromChanges(DeleteDocumentUnProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbooksMergeRequest" /></param>
        public   WorkbookResponse  PostWorkbooksMerge(PostWorkbooksMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbooksTextSearchRequest" /></param>
        public   TextItemsResponse  PostWorkbooksTextSearch(PostWorkbooksTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookTextReplaceRequest" /></param>
        public   WorkbookReplaceResponse  PostWorkbookTextReplace(PostWorkbookTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookGetSmartMarkerResultRequest" /></param>
        public   Stream  PostWorkbookGetSmartMarkerResult(PostWorkbookGetSmartMarkerResultRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookCreateRequest" /></param>
        public   CellsCloudResponse  PutWorkbookCreate(PutWorkbookCreateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSplitRequest" /></param>
        public   SplitResultResponse  PostWorkbookSplit(PostWorkbookSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SplitResultResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostImportDataRequest" /></param>
        public   CellsCloudResponse  PostImportData(PostImportDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookCalculateFormulaRequest" /></param>
        public   CellsCloudResponse  PostWorkbookCalculateFormula(PostWorkbookCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorkbookRowsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorkbookRows(PostAutofitWorkbookRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorkbookColumnsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorkbookColumns(PostAutofitWorkbookColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookSettingsRequest" /></param>
        public   WorkbookSettingsResponse  GetWorkbookSettings(GetWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookSettingsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSettingsRequest" /></param>
        public   CellsCloudResponse  PostWorkbookSettings(PostWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookBackgroundRequest" /></param>
        public   CellsCloudResponse  PutWorkbookBackground(PutWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookBackgroundRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookBackground(DeleteWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookWaterMarkerRequest" /></param>
        public   CellsCloudResponse  PutWorkbookWaterMarker(PutWorkbookWaterMarkerRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageCountRequest" /></param>
        public   int?  GetPageCount(GetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return System.Convert.ToInt32( result); 
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetsRequest" /></param>
        public   WorksheetsResponse  GetWorksheets(GetWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorksheetsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetWithFormatRequest" /></param>
        public   Stream  GetWorksheetWithFormat(GetWorksheetWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangeVisibilityWorksheetRequest" /></param>
        public   CellsCloudResponse  PutChangeVisibilityWorksheet(PutChangeVisibilityWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutActiveWorksheetRequest" /></param>
        public   CellsCloudResponse  PutActiveWorksheet(PutActiveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertNewWorksheetRequest" /></param>
        public   CellsCloudResponse  PutInsertNewWorksheet(PutInsertNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutAddNewWorksheetRequest" /></param>
        public   CellsCloudResponse  PutAddNewWorksheet(PutAddNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheet(DeleteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheets(DeleteWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostMoveWorksheetRequest" /></param>
        public   CellsCloudResponse  PostMoveWorksheet(PostMoveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutProtectWorksheetRequest" /></param>
        public   CellsCloudResponse  PutProtectWorksheet(PutProtectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteUnprotectWorksheetRequest" /></param>
        public   CellsCloudResponse  DeleteUnprotectWorksheet(DeleteUnprotectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetTextItemsRequest" /></param>
        public   TextItemsResponse  GetWorksheetTextItems(GetWorksheetTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCommentsRequest" /></param>
        public   CommentsResponse  GetWorksheetComments(GetWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCommentRequest" /></param>
        public   CommentResponse  GetWorksheetComment(GetWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCommentRequest" /></param>
        public   CommentResponse  PutWorksheetComment(PutWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCommentRequest" /></param>
        public   CellsCloudResponse  PostWorksheetComment(PostWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCommentRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetComment(DeleteWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCommentsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetComments(DeleteWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetMergedCellsRequest" /></param>
        public   MergedCellsResponse  GetWorksheetMergedCells(GetWorksheetMergedCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    MergedCellsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetMergedCellRequest" /></param>
        public   MergedCellResponse  GetWorksheetMergedCell(GetWorksheetMergedCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    MergedCellResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCalculateFormulaRequest" /></param>
        public   SingleValueResponse  GetWorksheetCalculateFormula(GetWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCalculateFormulaRequest" /></param>
        public   SingleValueResponse  PostWorksheetCalculateFormula(PostWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetTextSearchRequest" /></param>
        public   TextItemsResponse  PostWorksheetTextSearch(PostWorksheetTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorsheetTextReplaceRequest" /></param>
        public   WorksheetReplaceResponse  PostWorsheetTextReplace(PostWorsheetTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorksheetReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetRangeSortRequest" /></param>
        public   CellsCloudResponse  PostWorksheetRangeSort(PostWorksheetRangeSortRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetRow(PostAutofitWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetRows(PostAutofitWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetColumns(PostAutofitWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetBackgroundRequest" /></param>
        public   CellsCloudResponse  PutWorksheetBackground(PutWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetBackgroundRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetBackground(DeleteWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFreezePanesRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFreezePanes(PutWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetFreezePanesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetFreezePanes(DeleteWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheet(PostCopyWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostRenameWorksheetRequest" /></param>
        public   CellsCloudResponse  PostRenameWorksheet(PostRenameWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetPropertyRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetProperty(PostUpdateWorksheetPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetNamedRangesRequest" /></param>
        public   RangesResponse  GetNamedRanges(GetNamedRangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangesResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetNamedRangeValueRequest" /></param>
        public   RangeValueResponse  GetNamedRangeValue(GetNamedRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetZoomRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetZoom(PostUpdateWorksheetZoomRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPageCountRequest" /></param>
        public   int?  GetWorksheetPageCount(GetWorksheetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return System.Convert.ToInt32( result); 
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetValidationsRequest" /></param>
        public   ValidationsResponse  GetWorksheetValidations(GetWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ValidationsResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetValidationRequest" /></param>
        public   ValidationResponse  GetWorksheetValidation(GetWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ValidationResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  PutWorksheetValidation(PutWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  PostWorksheetValidation(PostWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetValidation(DeleteWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetValidationsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetValidations(DeleteWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookExportXMLRequest" /></param>
        public Stream PostWorkbookExportXML(PostWorkbookExportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookImportXMLRequest" /></param>
        public Stream PostWorkbookImortXML(PostWorkbookImportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<Stream>(request.CreateHttpRequest(BaseUri + "/" + Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        public   Stream  DownloadFile(DownloadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        public   FilesUploadResult  UploadFile(UploadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesUploadResult  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public  void  CopyFile(CopyFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public  void  MoveFile(MoveFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public  void  DeleteFile(DeleteFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        public   FilesList  GetFilesList(GetFilesListRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesList  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public  void  CreateFolder(CreateFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public  void  CopyFolder(CopyFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public  void  MoveFolder(MoveFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public  void  DeleteFolder(DeleteFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        public   StorageExist  StorageExists(StorageExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StorageExist  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        public   ObjectExist  ObjectExists(ObjectExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ObjectExist  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        public   DiscUsage  GetDiscUsage(GetDiscUsageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    DiscUsage  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        public   FileVersions  GetFileVersions(GetFileVersionsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileVersions  >(request.CreateHttpRequest(BaseUri +"/" +Version, this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }


    }
}
