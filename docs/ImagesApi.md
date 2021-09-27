# lagrello.Api.ImagesApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImagesTotp**](ImagesApi.md#imagestotp) | **GET** /v1/images/totp | Returns a generated QR code



## ImagesTotp

> System.IO.Stream ImagesTotp (string tenantName = null, string userId = null, string userSecret = null)

Returns a generated QR code

This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class ImagesTotpExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            var apiInstance = new ImagesApi(Configuration.Default);
            var tenantName = tenantName_example;  // string | The company name you your users to see in their TOTP application (optional) 
            var userId = userId_example;  // string | The userId of the user you want to create the TOTP QR image for (optional) 
            var userSecret = userSecret_example;  // string | The TOTP secret for the specified user (optional) 

            try
            {
                // Returns a generated QR code
                System.IO.Stream result = apiInstance.ImagesTotp(tenantName, userId, userSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImagesApi.ImagesTotp: " + e.Message );
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
 **tenantName** | **string**| The company name you your users to see in their TOTP application | [optional] 
 **userId** | **string**| The userId of the user you want to create the TOTP QR image for | [optional] 
 **userSecret** | **string**| The TOTP secret for the specified user | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gives back the QR code as an image |  -  |
| **400** | The payload of the request is not valid |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

