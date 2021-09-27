# lagrello.Api.InternalApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TenantsCardtoken**](InternalApi.md#tenantscardtoken) | **GET** /v1/tenant/cardtoken | Returns token that is used by stripe to save card number.



## TenantsCardtoken

> string TenantsCardtoken ()

Returns token that is used by stripe to save card number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantsCardtokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InternalApi(Configuration.Default);

            try
            {
                // Returns token that is used by stripe to save card number.
                string result = apiInstance.TenantsCardtoken();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InternalApi.TenantsCardtoken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the token as a string |  -  |
| **403** | The access token used to access resource is wrong |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

