/* 
 * <summary>
 *  Copyright (c) 2022 Aspose.Cells Cloud
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 * 
 *  The above copyright notice and this permission notice shall be included in all 
 *  copies or substantial portions of the Software.
 * 
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.
 * </summary>
 */
namespace Aspose.Cells.Cloud.SDK.Api
{
    using Aspose.Cells.Cloud.SDK.Internal.Extensions;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.IO;
    /// <summary>
    /// 
    /// </summary>
    public partial class CellsApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="conversionRequest"></param>
        public void Convert(Requests.ConversionRequest conversionRequest)
        {
            var format = "xlsx";
            var password = string.Empty;
            var outPath = string.Empty;
            var storageName = string.Empty;
            if (!File.Exists(conversionRequest.InputPath))
            {
                throw new ApplicationException("Input file no exists.");
            }
            if (string.IsNullOrEmpty(conversionRequest.OutputPath))
            {
                throw new ApplicationException("OutputPath is Empty.");
            }
            format = conversionRequest.OutputPath.GetFileFormat();
            if (conversionRequest.SaveToCloud.HasValue && conversionRequest.SaveToCloud.Value)
            {
                outPath = conversionRequest.OutputPath;
                storageName = conversionRequest.StorageName;
               
                this.CellsWorkbookPutConvertWorkbook(File.OpenRead(conversionRequest.InputPath), format, password, outPath, storageName);
            }
            else
            {
                using (Stream responseStream = this.CellsWorkbookPutConvertWorkbook(File.OpenRead(conversionRequest.InputPath), format, password))
                {
                    Stream outStream = File.Create(conversionRequest.OutputPath);
                    responseStream.CopyTo(outStream);
                    outStream.Flush();
                    outStream.Close();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mergeRequest"></param>
        public void Merge(Requests.MergeRequest mergeRequest)
        {
            if (mergeRequest.InputFiles == null || mergeRequest.InputFiles.Length ==0)
            {
                throw new ApplicationException("Input file no exists.");
            }
            foreach( string filename in mergeRequest.InputFiles)
            {
                if (!File.Exists(filename))
                {
                    throw new ApplicationException("Input file no exists.");
                }
            }
            
            if (string.IsNullOrEmpty(mergeRequest.OutputPath))
            {
                throw new ApplicationException("OutputPath is Empty.");
            }
            checkAccessToken();

            var format = "xlsx";
            var password = string.Empty;
            var outPath = string.Empty;
            var storageName = string.Empty;

            format = mergeRequest.OutputPath.GetFileFormat();

            var localVarPath = "/cells/merge";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (mergeRequest.mergeToOneSheet.HasValue) localVarQueryParams.Add("mergeToOneSheet", Configuration.ApiClient.ParameterToString(mergeRequest.mergeToOneSheet.Value)); // query parameter

            foreach (string filename in mergeRequest.InputFiles)
            {
                localVarFileParams.Add(filename, Configuration.ApiClient.ParameterToFile(filename,File.OpenRead(filename)));
            }
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostMerge", localVarResponse);
                if (exception != null) throw exception;
            }

            
            Model.FileInfo fileInfo = (Model.FileInfo)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model.FileInfo));
            if( mergeRequest.SaveToCloud.HasValue && mergeRequest.SaveToCloud.Value)
            {
                this.UploadFile(mergeRequest.OutputPath, fileInfo.FileContent.Base64StringToStream(), mergeRequest.StorageName);
            }
            else
            {
                using( Stream fileHalder = File.Create(mergeRequest.OutputPath))
                {
                    fileInfo.FileContent.Base64StringToStream().CopyTo(fileHalder);
                }
            }
        }
    }
}
