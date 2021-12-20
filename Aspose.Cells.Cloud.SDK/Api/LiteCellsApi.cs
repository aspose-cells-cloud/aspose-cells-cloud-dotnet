/* 
 * <summary>
 *  Copyright (c) 2021 Aspose.Cells Cloud
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

using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aspose.Cells.Cloud.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILiteCellsApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">File to upload</param>
        /// <param name="type"> (optional, default to all)</param>
        /// <returns>FilesResult</returns>
        FilesResult DeleteMetadata(IDictionary<string, System.IO.Stream> files, string type = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">File to upload</param>
        /// <param name="type"> (optional, default to all)</param>
        /// <returns>List&lt;CellsDocumentProperty&gt;</returns>
        List<CellsDocumentProperty> GetMetadata(IDictionary<string, System.IO.Stream> files, string type = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource"></param>
        /// <param name="file">File to upload</param>
        /// <param name="format"> (optional, default to Xlsx)</param>
        /// <returns>FilesResult</returns>
        FilesResult PostAssemble( IDictionary<string, System.IO.Stream> files, string datasource, string format = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objecttype"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostClearObjects(IDictionary<string, System.IO.Stream> files, string objecttype);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="format"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostExport(IDictionary<string, System.IO.Stream> files,  string objectType, string format);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"></param> 
        /// <param name="importOption"></param> 
        /// <returns>FilesResult</returns>
        FilesResult PostImport(IDictionary<string, System.IO.Stream> file, ImportOption importOption = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <param name="format"> (optional, default to xlsx)</param>
        /// <param name="mergeToOneSheet"> (optional, default to false)</param>
        /// <returns>FileInfo</returns>
        FileInfo PostMerge(IDictionary<string, System.IO.Stream> files, string format = null, bool? mergeToOneSheet = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostMetadata(IDictionary<string, System.IO.Stream> files, IList<CellsDocumentProperty> cellsDocumentProperties);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostProtect(IDictionary<string, System.IO.Stream> files, string password);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="file">File to upload</param>
        /// <param name="password"> (optional)</param>
        /// <param name="sheetname"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        IList<Model.TextItem> PostSearch(IDictionary<string, System.IO.Stream> files, string text, string password = null, string sheetname = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format"></param>
        /// <param name="file">File to upload</param>
        /// <param name="password"> (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>FilesResult</returns>
        FilesResult PostSplit( IDictionary<string, System.IO.Stream> files, string format, string password = null, int? from = null, int? to = null);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostUnlock( IDictionary<string, System.IO.Stream> files,string password);


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostWatermark(IDictionary<string, System.IO.Stream> files, string text, string color);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="compressLevel"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostCompress(IDictionary<string, System.IO.Stream> files, int? compressLevel);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="newtext"></param>
        /// <param name="password"></param>
        /// <param name="text"></param>
        /// <param name="sheetname">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostReplace(IDictionary<string, System.IO.Stream> files, string text, string newtext, string password = null, string sheetname = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotateType"></param>
        /// <param name="format">File to upload</param>
        /// <returns>FilesResult</returns>
        FilesResult PostReverse(IDictionary<string, System.IO.Stream> files, string rotateType, string format = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LiteCellsApi : ILiteCellsApi
    {
        private Aspose.Cells.Cloud.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
        private const string _grantType = "client_credentials";
        private string _clientId;
        private string _clientSecret;
        private string _OAuthPattern;
        private string _version;
        private string _basePath;
        private DateTime _getAccessTokenTime;
        private bool _needAuth = true;

        private string versionURI
        {
            get
            {
                return _basePath.EndsWith("/") ? _basePath + _version : _basePath + "/" + _version;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="appSID"></param>
        /// <param name="appKey"></param>
        /// <param name="version"></param>
        public LiteCellsApi(String clientId, String clientSecret, String version = "v3.0", String basePath = "https://api.aspose.cloud")
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _version = version;
            _basePath = basePath;
            switch (_version)
            {
                case "v3.0":
                    _OAuthPattern = "/connect/token";
                    break;
                case "v1.1":
                    _OAuthPattern = "/oauth2/token";
                    break;
                default:
                    throw new InvalidOperationException(String.Format("Version {0} is unsupported.", version));
            }

            if (string.IsNullOrEmpty(_clientId) && string.IsNullOrEmpty(_clientSecret))
            {
                this.Configuration = new Configuration(new ApiClient(versionURI), null);
                _needAuth = false;
            }
            else
            {
                UpdateAccessToken(getAccessToken());
            }

            ExceptionFactory = Aspose.Cells.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void checkAccessToken()
        {
            if (_needAuth)
            {
                if (DateTime.Now > _getAccessTokenTime.AddMinutes(23.5 * 60))
                {
                    UpdateAccessToken(getAccessToken());
                }
            }
        }

        private string getAccessToken()
        {
            ApiClient apiClient = new ApiClient(_basePath);
            string accessToken = apiClient.GetAccessToken("client_credentials", _clientId, _clientSecret, _OAuthPattern);
            _getAccessTokenTime = DateTime.Now;
            if (String.IsNullOrEmpty(accessToken))
            {
                throw new ApiException(400, "Get access token  fails.");
            }
            return accessToken;
        }

        private void UpdateAccessToken(string accessToken)
        {
            Configuration = new Configuration();
            Dictionary<string, string> headerParameters = new Dictionary<string, string>();
            headerParameters.Add("Authorization", "Bearer " + accessToken);
            this.Configuration = new Configuration(new ApiClient(versionURI), headerParameters);
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        private String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        private Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Aspose.Cells.Cloud.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <param name="type"> (optional, default to all)</param>
        /// <returns>FilesResult</returns>
        public FilesResult DeleteMetadata(IDictionary<string, System.IO.Stream> files, string type = null)
        {
            checkAccessToken();
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->DeleteMetadata");

            var localVarPath = "/cells/metadata/delete";
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

            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteMetadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <param name="type"> (optional, default to all)</param>
        /// <returns>List&lt;CellsDocumentProperty&gt;</returns>
        public List<CellsDocumentProperty> GetMetadata(IDictionary<string, System.IO.Stream> files, string type = null)
        {
            checkAccessToken();
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->GetMetadata");

            var localVarPath = "/cells/metadata/get";
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

            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMetadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<List<CellsDocumentProperty>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CellsDocumentProperty>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CellsDocumentProperty>)))).Data;
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource"></param>
        /// <param name="file">File to upload</param>
        /// <param name="format"> (optional, default to Xlsx)</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostAssemble( IDictionary<string, System.IO.Stream> files, string datasource, string format = null)
        {
            checkAccessToken();
            // verify the required parameter 'datasource' is set
            if (datasource == null)
                throw new ApiException(400, "Missing required parameter 'datasource' when calling LiteCellsApi->PostAssemble");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostAssemble");

            var localVarPath = "/cells/assemble";
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

            if (datasource != null) localVarQueryParams.Add("datasource", Configuration.ApiClient.ParameterToString(datasource)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAssemble", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objecttype"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostClearObjects( IDictionary<string, System.IO.Stream> files, string objecttype)
        {
            checkAccessToken();
            // verify the required parameter 'objecttype' is set
            if (objecttype == null)
                throw new ApiException(400, "Missing required parameter 'objecttype' when calling LiteCellsApi->PostClearObjects");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostClearObjects");

            var localVarPath = "/cells/clearobjects";
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

            if (objecttype != null) localVarQueryParams.Add("objecttype", Configuration.ApiClient.ParameterToString(objecttype)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostClearObjects", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="format"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostExport( IDictionary<string, System.IO.Stream> files, string objectType, string format)
        {
            checkAccessToken();
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling LiteCellsApi->PostExport");
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling LiteCellsApi->PostExport");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostExport");

            var localVarPath = "/cells/export";
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

            if (objectType != null) localVarQueryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostExport", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"></param> 
        /// <param name="importOption"></param> 
        /// <returns>FilesResult</returns>
        public FilesResult PostImport(IDictionary<string, System.IO.Stream> file, ImportOption importOption = null)
        {
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling CellsApi->PostImport");
            if (importOption == null)
                throw new ApiException(400, "Missing required parameter 'importOption' when calling CellsApi->PostImport");
            var localVarPath = "/cells/import";

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

            foreach (KeyValuePair<string, System.IO.Stream> keyValuePair in file)
            {
                localVarFileParams.Add(keyValuePair.Key, Configuration.ApiClient.ParameterToFile(keyValuePair.Key, keyValuePair.Value));
            }
            localVarFileParams.Add("importOption", Configuration.ApiClient.ParameterToFile("importOption", Configuration.ApiClient.Serialize(importOption)));

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostImport", localVarResponse);
                if (exception != null) throw exception;
            }
            return new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult))).Data;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <param name="format"> (optional, default to xlsx)</param>
        /// <param name="mergeToOneSheet"> (optional, default to false)</param>
        /// <returns>FileInfo</returns>
        public FileInfo PostMerge(IDictionary<string, System.IO.Stream> files, string format = null, bool? mergeToOneSheet = null)
        {
            checkAccessToken();
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostMerge");

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
            if (mergeToOneSheet != null) localVarQueryParams.Add("mergeToOneSheet", Configuration.ApiClient.ParameterToString(mergeToOneSheet)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
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

            return (new ApiResponse<FileInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FileInfo)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileInfo)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostMetadata(IDictionary<string, System.IO.Stream> files, IList<CellsDocumentProperty> cellsDocumentProperties)
        {
            checkAccessToken();
            // verify the required parameter 'file' is set
            if (cellsDocumentProperties == null || cellsDocumentProperties.Count == 0)
                throw new ApiException(400, "Missing required parameter 'cellsDocumentProperties' when calling LiteCellsApi->PostMetadata");
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostMetadata");

            var localVarPath = "/cells/metadata/update";
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
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
           
            //localVarPostBody = Configuration.ApiClient.Serialize(cellsDocumentProperties);
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }
            localVarFileParams.Add("DocumentProperties", Configuration.ApiClient.ParameterToFile("DocumentProperties", Configuration.ApiClient.Serialize(cellsDocumentProperties)));
            
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostMetadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostProtect( IDictionary<string, System.IO.Stream> files, string password)
        {
            checkAccessToken();
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling LiteCellsApi->PostProtect");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostProtect");

            var localVarPath = "/cells/protect";
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

            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostProtect", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="file">File to upload</param>
        /// <param name="password"> (optional)</param>
        /// <param name="sheetname"> (optional)</param>
        /// <param name="path"> (optional)</param>
        /// <param name="storageName"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public IList<Model.TextItem> PostSearch(IDictionary<string, System.IO.Stream> files, string text,  string password = null, string sheetname = null)
        {
            checkAccessToken();
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling LiteCellsApi->PostSearch");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostSearch");

            var localVarPath = "/cells/search";
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

            if (text != null) localVarQueryParams.Add("text", Configuration.ApiClient.ParameterToString(text)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (sheetname != null) localVarQueryParams.Add("sheetname", Configuration.ApiClient.ParameterToString(sheetname)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<IList<Model.TextItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IList<Model.TextItem>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(IList<Model.TextItem>)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format"></param>
        /// <param name="file">File to upload</param>
        /// <param name="password"> (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostSplit( IDictionary<string, System.IO.Stream> files, string format, string password = null, int? from = null, int? to = null)
        {
            checkAccessToken();
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling LiteCellsApi->PostSplit");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostSplit");

            var localVarPath = "/cells/split";
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
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSplit", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostUnlock( IDictionary<string, System.IO.Stream> files, string password)
        {
            checkAccessToken();
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling LiteCellsApi->PostUnlock");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostUnlock");

            var localVarPath = "/cells/unlock";
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

            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostUnlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostWatermark( IDictionary<string, System.IO.Stream> files, string text, string color)
        {
            checkAccessToken();
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling LiteCellsApi->PostWatermark");
            // verify the required parameter 'color' is set
            if (color == null)
                throw new ApiException(400, "Missing required parameter 'color' when calling LiteCellsApi->PostWatermark");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostWatermark");

            var localVarPath = "/cells/watermark";
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

            if (text != null) localVarQueryParams.Add("text", Configuration.ApiClient.ParameterToString(text)); // query parameter
            if (color != null) localVarQueryParams.Add("color", Configuration.ApiClient.ParameterToString(color)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostWatermark", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="compressLevel"></param>
        /// <param name="file">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostCompress(IDictionary<string, System.IO.Stream> files, int? compressLevel)
        {
            checkAccessToken();
            // verify the required parameter 'text' is set
            if (compressLevel == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling LiteCellsApi->PostCompress");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostCompress");

            var localVarPath = "/cells/compress";
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

            if (compressLevel != null) localVarQueryParams.Add("compressLevel", Configuration.ApiClient.ParameterToString(compressLevel)); // query parameter
            
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostCompress", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text"></param>
        /// <param name="newtext"></param>
        /// <param name="password"></param>
        /// <param name="text"></param>
        /// <param name="sheetname">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostReplace(IDictionary<string, System.IO.Stream> files, string text, string newtext, string password = null, string sheetname = null)
        {
            checkAccessToken();
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling LiteCellsApi->PostReplace");
            // verify the required parameter 'color' is set
            if (newtext == null)
                throw new ApiException(400, "Missing required parameter 'newtext' when calling LiteCellsApi->PostReplace");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostReplace");

            var localVarPath = "/cells/replace";
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

            if (text != null) localVarQueryParams.Add("text", Configuration.ApiClient.ParameterToString(text)); // query parameter
            if (newtext != null) localVarQueryParams.Add("newtext", Configuration.ApiClient.ParameterToString(newtext)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (sheetname != null) localVarQueryParams.Add("sheetname", Configuration.ApiClient.ParameterToString(sheetname)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotateType"></param>
        /// <param name="format">File to upload</param>
        /// <returns>FilesResult</returns>
        public FilesResult PostReverse(IDictionary<string, System.IO.Stream> files, string rotateType, string format=null )
        {
            checkAccessToken();
            // verify the required parameter 'rotateType' is set
            if (rotateType == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling LiteCellsApi->PostReplace");
            // verify the required parameter 'file' is set
            if (files == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling LiteCellsApi->PostReplace");

            var localVarPath = "/cells/replace";
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

            if (rotateType != null) localVarQueryParams.Add("rotateType", Configuration.ApiClient.ParameterToString(rotateType)); // query parameter
            if (format != null) localVarQueryParams.Add("newtext", Configuration.ApiClient.ParameterToString(format)); // query parameter
            foreach (KeyValuePair<string, System.IO.Stream> file in files)
            {
                localVarFileParams.Add(file.Key, Configuration.ApiClient.ParameterToFile(file.Key, file.Value));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return (new ApiResponse<FilesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilesResult)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilesResult)))).Data;
        }
    }
}
