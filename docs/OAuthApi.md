# Aspose.Cells.Cloud.SDK.Api.OAuthApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OAuthPost**](OAuthApi.md#oauthpost) | **POST** /oauth2/token | Get Access token


<a name="oauthpost"></a>
# **OAuthPost**
> AccessTokenResponse OAuthPost (string grantType, string clientId, string clientSecret)

Get Access token

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class OAuthPostExample
    {
        public void main()
        {
            var apiInstance = new OAuthApi();
            var grantType = grantType_example;  // string | Grant Type
            var clientId = clientId_example;  // string | App SID
            var clientSecret = clientSecret_example;  // string | App Key

            try
            {
                // Get Access token
                AccessTokenResponse result = apiInstance.OAuthPost(grantType, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| Grant Type | 
 **clientId** | **string**| App SID | 
 **clientSecret** | **string**| App Key | 

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

