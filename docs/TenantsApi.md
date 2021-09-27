# lagrello.Api.TenantsApi

All URIs are relative to *https://api.lagrello.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TenantUpdate**](TenantsApi.md#tenantupdate) | **PATCH** /v1/tenant | Updates tenant information
[**TenantsActivate**](TenantsApi.md#tenantsactivate) | **POST** /v1/tenant/activate | Activates the tenant, checks that all necessary information to activate a tenant is included
[**TenantsCreate**](TenantsApi.md#tenantscreate) | **POST** /v1/tenant | Creates new tenant
[**TenantsCreate_0**](TenantsApi.md#tenantscreate_0) | **DELETE** /v1/tenant | Deletes tenant caller is part of, will send verification email before deleting tenant
[**TenantsGet**](TenantsApi.md#tenantsget) | **GET** /v1/tenant | Returns the tenant information the caller is part of



## TenantUpdate

> Tenant TenantUpdate (UpdateTenantRequest updateTenantRequest = null)

Updates tenant information

This endpoint is used to update certain information about your tenant. For example if you want to update your tenant's callback URL you will do that here.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(Configuration.Default);
            var updateTenantRequest = new UpdateTenantRequest(); // UpdateTenantRequest |  (optional) 

            try
            {
                // Updates tenant information
                Tenant result = apiInstance.TenantUpdate(updateTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantUpdate: " + e.Message );
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
 **updateTenantRequest** | [**UpdateTenantRequest**](UpdateTenantRequest.md)|  | [optional] 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated tenant |  -  |
| **403** | The access token used to access resource is wrong |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TenantsActivate

> Tenant TenantsActivate (ActivateTenantRequest activateTenantRequest = null)

Activates the tenant, checks that all necessary information to activate a tenant is included

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantsActivateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(Configuration.Default);
            var activateTenantRequest = new ActivateTenantRequest(); // ActivateTenantRequest |  (optional) 

            try
            {
                // Activates the tenant, checks that all necessary information to activate a tenant is included
                Tenant result = apiInstance.TenantsActivate(activateTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsActivate: " + e.Message );
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
 **activateTenantRequest** | [**ActivateTenantRequest**](ActivateTenantRequest.md)|  | [optional] 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns tenant information about the newly activated tenant. |  -  |
| **400** | The payload of the request is not valid |  -  |
| **403** | The access token used to access resource is wrong |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TenantsCreate

> Tenant TenantsCreate (CreateTenantRequest createTenantRequest = null)

Creates new tenant

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantsCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            var apiInstance = new TenantsApi(Configuration.Default);
            var createTenantRequest = new CreateTenantRequest(); // CreateTenantRequest |  (optional) 

            try
            {
                // Creates new tenant
                Tenant result = apiInstance.TenantsCreate(createTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsCreate: " + e.Message );
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
 **createTenantRequest** | [**CreateTenantRequest**](CreateTenantRequest.md)|  | [optional] 

### Return type

[**Tenant**](Tenant.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns information about the newly created tenant |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TenantsCreate_0

> Tenant TenantsCreate_0 ()

Deletes tenant caller is part of, will send verification email before deleting tenant

This endpoint will delete your tenant. Will send an email to the admin email address of the tenant confirming that you want to delete your tenant before deletion.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantsCreate_0Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(Configuration.Default);

            try
            {
                // Deletes tenant caller is part of, will send verification email before deleting tenant
                Tenant result = apiInstance.TenantsCreate_0();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsCreate_0: " + e.Message );
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

[**Tenant**](Tenant.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Sucess, will send verification email before deleting |  -  |
| **403** | The access token used to access resource is wrong |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TenantsGet

> Tenant TenantsGet ()

Returns the tenant information the caller is part of

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lagrello.Api;
using lagrello.Client;
using lagrello.Model;

namespace Example
{
    public class TenantsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.lagrello.com";
            // Configure HTTP bearer authorization: token
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(Configuration.Default);

            try
            {
                // Returns the tenant information the caller is part of
                Tenant result = apiInstance.TenantsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsGet: " + e.Message );
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

[**Tenant**](Tenant.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gives back the tenant call is part of |  -  |
| **403** | The access token used to access resource is wrong |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

