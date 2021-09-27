# lagrello.Api.TokensApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokensCreate**](TokensApi.md#tokenscreate) | **POST** /v1/tokens | Creates new token
[**TokensDelete**](TokensApi.md#tokensdelete) | **DELETE** /v1/tokens/{id} | Deletes specifed access token
[**TokensList**](TokensApi.md#tokenslist) | **GET** /v1/tokens | Returns a list of all active tokens in tenant



## TokensCreate

> Token TokensCreate (CreateTokenRequest createTokenRequest = null)

Creates new token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TokensCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(Configuration.Default);
            var createTokenRequest = new CreateTokenRequest(); // CreateTokenRequest |  (optional) 

            try
            {
                // Creates new token
                Token result = apiInstance.TokensCreate(createTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TokensApi.TokensCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createTokenRequest** | [**CreateTokenRequest**](CreateTokenRequest.md)|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the newly created token |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TokensDelete

> void TokensDelete (string tokenId)

Deletes specifed access token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TokensDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(Configuration.Default);
            var tokenId = ffd12fb4-da5b-4751-a9f6-d3214b418139;  // string | Id of the token you want to delete

            try
            {
                // Deletes specifed access token
                apiInstance.TokensDelete(tokenId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TokensApi.TokensDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| Id of the token you want to delete | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully deleted specified token |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | token could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TokensList

> TokenList TokensList (int? size = null, int? page = null)

Returns a list of all active tokens in tenant

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TokensListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(Configuration.Default);
            var size = 56;  // int? | Maximum of results per page (optional) 
            var page = 56;  // int? | The page you want to see (optional) 

            try
            {
                // Returns a list of all active tokens in tenant
                TokenList result = apiInstance.TokensList(size, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TokensApi.TokensList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| Maximum of results per page | [optional] 
 **page** | **int?**| The page you want to see | [optional] 

### Return type

[**TokenList**](TokenList.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a paginated list of tokens |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

