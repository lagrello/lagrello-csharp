# lagrello.Api.AuthApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersEmailAuth**](AuthApi.md#usersemailauth) | **GET** /v1/users/email | Gives back user data for the magic link token
[**UsersEmailSend**](AuthApi.md#usersemailsend) | **POST** /v1/users/{userId}/email | This endpoint will be used when you want to send a magic login link to specified user
[**UsersTotpAuth**](AuthApi.md#userstotpauth) | **GET** /v1/users/{userId}/totp | Verify users TOTP token
[**UsersTotpToggle**](AuthApi.md#userstotptoggle) | **POST** /v1/users/{userId}/totp | Enables or disables Time-based One-Time Password authentication method for specified user



## UsersEmailAuth

> User UsersEmailAuth (string payload)

Gives back user data for the magic link token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersEmailAuthExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(Configuration.Default);
            var payload = payload_example;  // string | The magic link token the user sent

            try
            {
                // Gives back user data for the magic link token
                User result = apiInstance.UsersEmailAuth(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.UsersEmailAuth: " + e.Message );
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
 **payload** | **string**| The magic link token the user sent | 

### Return type

[**User**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns user data for authenticated user |  -  |
| **401** | End users token is wrong, DO NOT authenticate user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersEmailSend

> void UsersEmailSend (string userId)

This endpoint will be used when you want to send a magic login link to specified user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersEmailSendExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(Configuration.Default);
            var userId = userId_example;  // string | Id of the user you want to send magic link to

            try
            {
                // This endpoint will be used when you want to send a magic login link to specified user
                apiInstance.UsersEmailSend(userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.UsersEmailSend: " + e.Message );
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
 **userId** | **string**| Id of the user you want to send magic link to | 

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
| **204** | Email to user has been sent successfully. |  -  |
| **400** | The payload of the request is not valid |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersTotpAuth

> User UsersTotpAuth (string userId, string payload)

Verify users TOTP token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersTotpAuthExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(Configuration.Default);
            var userId = userId_example;  // string | Id of the user you want to verify TOTP code for
            var payload = payload_example;  // string | The totp token the user sent

            try
            {
                // Verify users TOTP token
                User result = apiInstance.UsersTotpAuth(userId, payload);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.UsersTotpAuth: " + e.Message );
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
 **userId** | **string**| Id of the user you want to verify TOTP code for | 
 **payload** | **string**| The totp token the user sent | 

### Return type

[**User**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - Returns the user information if the totp token is correct |  -  |
| **401** | End users token is wrong, DO NOT authenticate user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersTotpToggle

> TotpEnableResponse UsersTotpToggle (string userId, TotpEnableRequest totpEnableRequest = null)

Enables or disables Time-based One-Time Password authentication method for specified user

When you want your users to be able to use TOTP authentication you need to send enable set to true as payload to this endpoint. To turn off TOTP set enable to false. When enabling you will recieve the secret key and a QR code link. The QR code you need to show your user for them to scan.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersTotpToggleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(Configuration.Default);
            var userId = userId_example;  // string | Id of the user you want to enable TOTP for
            var totpEnableRequest = new TotpEnableRequest(); // TotpEnableRequest |  (optional) 

            try
            {
                // Enables or disables Time-based One-Time Password authentication method for specified user
                TotpEnableResponse result = apiInstance.UsersTotpToggle(userId, totpEnableRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.UsersTotpToggle: " + e.Message );
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
 **userId** | **string**| Id of the user you want to enable TOTP for | 
 **totpEnableRequest** | [**TotpEnableRequest**](TotpEnableRequest.md)|  | [optional] 

### Return type

[**TotpEnableResponse**](TotpEnableResponse.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Will return user&#39;s secret key and a url where QR-code image can be found |  -  |
| **204** | Success when disabling TOTP for user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

