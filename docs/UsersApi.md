# lagrello.Api.UsersApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersCreate**](UsersApi.md#userscreate) | **POST** /v1/users | Creates a user in tenant, tenant is determined from the token
[**UsersDelete**](UsersApi.md#usersdelete) | **DELETE** /v1/users/{userId} | Deletes specified user
[**UsersGet**](UsersApi.md#usersget) | **GET** /v1/users/{userId} | Returns specified user
[**UsersUpdate**](UsersApi.md#usersupdate) | **PATCH** /v1/users/{userId} | Updates specified user



## UsersCreate

> User UsersCreate (CreateUserRequest createUserRequest = null)

Creates a user in tenant, tenant is determined from the token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(Configuration.Default);
            var createUserRequest = new CreateUserRequest(); // CreateUserRequest |  (optional) 

            try
            {
                // Creates a user in tenant, tenant is determined from the token
                User result = apiInstance.UsersCreate(createUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCreate: " + e.Message );
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
 **createUserRequest** | [**CreateUserRequest**](CreateUserRequest.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created a new user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **409** | Returned when user already exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersDelete

> void UsersDelete (string userId)

Deletes specified user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | Id of the user you want to delete

            try
            {
                // Deletes specified user
                apiInstance.UsersDelete(userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDelete: " + e.Message );
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
 **userId** | **string**| Id of the user you want to delete | 

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
| **204** | Successfully deleted specified user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersGet

> User UsersGet (string userId)

Returns specified user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | userId of user you want to fetch information about

            try
            {
                // Returns specified user
                User result = apiInstance.UsersGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
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
 **userId** | **string**| userId of user you want to fetch information about | 

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
| **200** | Returns user data for specified user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersUpdate

> User UsersUpdate (string userId, UpdateUserRequest updateUserRequest = null)

Updates specified user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class UsersUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | Id of the user you want to update
            var updateUserRequest = new UpdateUserRequest(); // UpdateUserRequest |  (optional) 

            try
            {
                // Updates specified user
                User result = apiInstance.UsersUpdate(userId, updateUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUpdate: " + e.Message );
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
 **userId** | **string**| Id of the user you want to update | 
 **updateUserRequest** | [**UpdateUserRequest**](UpdateUserRequest.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated specified user |  -  |
| **403** | The access token used to access resource is wrong |  -  |
| **404** | user could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

