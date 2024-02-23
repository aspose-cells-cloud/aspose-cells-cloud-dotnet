// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsApiExtension.cs.cs">
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

namespace Aspose.Cells.Cloud.SDK.Api
{
    using Aspose.Cells.Cloud.SDK.Extensions;    
    using System;
    using System.Collections.Generic;
    using System.IO;
    ///<summary>
    /// 
    ///</summary>
    public static class CellsApiExtension
    {
        ///<summary>
        /// 
        ///</summary>
        ///<param name="conversionRequest"></param>
        public static void Convert(this CellsApi cellsApi, Request.ConversionRequest conversionRequest)
        {
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
            Request.PutConvertWorkbookRequest putConvertWorkbookRequest = new Request.PutConvertWorkbookRequest();
            putConvertWorkbookRequest.File = new Dictionary<string, Stream>();
            putConvertWorkbookRequest.File.Add( (new System.IO.FileInfo(conversionRequest.InputPath)).Name, File.OpenRead(conversionRequest.InputPath) );
            putConvertWorkbookRequest.format = conversionRequest.OutputPath.GetFileFormat();
            putConvertWorkbookRequest.password = conversionRequest.password;
            putConvertWorkbookRequest.outPath = conversionRequest.OutputPath;
            putConvertWorkbookRequest.storageName = conversionRequest.StorageName;
            putConvertWorkbookRequest.streamFormat = conversionRequest.InputPath.GetFileFormat();

            using (Stream responseStream = cellsApi.PutConvertWorkbook(putConvertWorkbookRequest))
            {
                if (conversionRequest.SaveToCloud.HasValue && conversionRequest.SaveToCloud.Value)
                {
                    responseStream.Close();
                }
                else
                {
                    Stream outStream = File.Create(conversionRequest.OutputPath);
                    responseStream.CopyTo(outStream);
                    outStream.Flush();
                    outStream.Close();
                }                
            }
        }

        ///<summary>
        /// 
        ///</summary>
        ///<param name="mergeRequest"></param>
        public static void Merge(this CellsApi cellsApi,  Request.MergeRequest mergeRequest)
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

            Request.PostMergeRequest request = new Request.PostMergeRequest();
            request.File = new Dictionary<string, Stream>();
            foreach (string filename in mergeRequest.InputFiles)
            {
                request.File.Add((new System.IO.FileInfo(filename)).Name, File.OpenRead(filename));
            }

            request.outFormat = mergeRequest.OutputPath.GetFileFormat();
            request.mergeToOneSheet = mergeRequest.mergeToOneSheet;

            Model.FileInfo fileInfo = cellsApi.PostMerge(request);
            Stream resultStream = fileInfo.FileContent.Base64StringToStream();
            if (mergeRequest.SaveToCloud.HasValue && mergeRequest.SaveToCloud.Value)
            {
                Request.UploadFileRequest uploadFileRequest = new Request.UploadFileRequest();
                uploadFileRequest.path = mergeRequest.OutputPath;
                uploadFileRequest.storageName = mergeRequest.StorageName;
                uploadFileRequest.UploadFiles = new Dictionary<string, Stream> { { (new System.IO.FileInfo(fileInfo.Filename)).Name, resultStream } };
                cellsApi.UploadFile(uploadFileRequest);
            }
            else
            {
                Stream outStream = File.Create(mergeRequest.OutputPath);
                resultStream.CopyTo(outStream);
                outStream.Flush();
                outStream.Close();
                resultStream.Close();
            }
        }
        public static void Unlock(this CellsApi cellsApi, Request.UnlockRequest unlockRequest)
        {
            if (unlockRequest.InputPath == null )
            {
                throw new ApplicationException("Input file no exists.");
            }
            if (!File.Exists(unlockRequest.InputPath))
            {
                throw new ApplicationException("Input file no exists.");
            }
            if (string.IsNullOrEmpty(unlockRequest.OutputPath))
            {
                throw new ApplicationException("OutputPath is Empty.");
            }
            Request.PostUnlockRequest request = new Request.PostUnlockRequest();
            request.File = new Dictionary<string, Stream>();
            request.File.Add((new System.IO.FileInfo(unlockRequest.InputPath)).Name, File.OpenRead(unlockRequest.InputPath));

            request.password = unlockRequest.Password;

            Model.FilesResult filesResult = cellsApi.PostUnlock(request);
            foreach( Model.FileInfo fileInfo in filesResult.Files)
            {
                Stream resultStream = fileInfo.FileContent.Base64StringToStream();
                if (unlockRequest.SaveToCloud.HasValue && unlockRequest.SaveToCloud.Value)
                {
                    Request.UploadFileRequest uploadFileRequest = new Request.UploadFileRequest();
                    uploadFileRequest.path = unlockRequest.OutputPath;
                    uploadFileRequest.storageName = unlockRequest.StorageName;
                    uploadFileRequest.UploadFiles = new Dictionary<string, Stream> { { (new System.IO.FileInfo(fileInfo.Filename)).Name, resultStream } };
                    cellsApi.UploadFile(uploadFileRequest);
                }
                else
                {
                    Stream outStream = File.Create(unlockRequest.OutputPath);
                    resultStream.CopyTo(outStream);
                    outStream.Flush();
                    outStream.Close();
                    resultStream.Close();
                }
            }

        }
        public static void Protect(this CellsApi cellsApi , Request.ProtectRequest protectRequest)
        {
            if (protectRequest.InputPath == null)
            {
                throw new ApplicationException("Input file no exists.");
            }
            if (!File.Exists(protectRequest.InputPath))
            {
                throw new ApplicationException("Input file no exists.");
            }
            if (string.IsNullOrEmpty(protectRequest.OutputPath))
            {
                throw new ApplicationException("OutputPath is Empty.");
            }

            Request.PostProtectRequest request = new Request.PostProtectRequest();
            request.File = new Dictionary<string, Stream>();
            request.File.Add((new System.IO.FileInfo(protectRequest.InputPath)).Name, File.OpenRead(protectRequest.InputPath));

            request.password = protectRequest.Password;

            Model.FilesResult filesResult = cellsApi.PostProtect(request);
            foreach (Model.FileInfo fileInfo in filesResult.Files)
            {
                Stream resultStream = fileInfo.FileContent.Base64StringToStream();
                if (protectRequest.SaveToCloud.HasValue && protectRequest.SaveToCloud.Value)
                {
                    Request.UploadFileRequest uploadFileRequest = new Request.UploadFileRequest();
                    uploadFileRequest.path = protectRequest.OutputPath;
                    uploadFileRequest.storageName = protectRequest.StorageName;
                    uploadFileRequest.UploadFiles = new Dictionary<string, Stream> { { (new System.IO.FileInfo(fileInfo.Filename)).Name, resultStream } };
                    cellsApi.UploadFile(uploadFileRequest);
                }
                else
                {
                    Stream outStream = File.Create(protectRequest.OutputPath);
                    resultStream.CopyTo(outStream);
                    outStream.Flush();
                    outStream.Close();
                    resultStream.Close();
                }
            }
        }
    }
}