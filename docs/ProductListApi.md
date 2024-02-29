# product-list.Api.ProductListApi

All URIs are relative to *https://product-list.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkUpdateProductListAssociations**](ProductListApi.md#bulkupdateproductlistassociations) | **POST** /productlist.ProductList/BulkUpdateProductListAssociations | Bulk update collection associations position |
| [**CreateProductList**](ProductListApi.md#createproductlist) | **POST** /productlist.ProductList/CreateProductList | Create Collection |
| [**CreateProductListAssociation**](ProductListApi.md#createproductlistassociation) | **POST** /productlist.ProductList/CreateProductListAssociation | Create Collection/Product Association |
| [**DeleteProductList**](ProductListApi.md#deleteproductlist) | **POST** /productlist.ProductList/DeleteProductList | Delete Collection |
| [**DeleteProductListAssociation**](ProductListApi.md#deleteproductlistassociation) | **POST** /productlist.ProductList/DeleteProductListAssociation | Delete Collection/Product Association |
| [**GetProductListAssociationsByProductGrn**](ProductListApi.md#getproductlistassociationsbyproductgrn) | **POST** /productlist.ProductList/GetProductListAssociationsByProductGrn | Get Collection/Product Associations by Product GRN |
| [**GetProductListByCode**](ProductListApi.md#getproductlistbycode) | **POST** /productlist.ProductList/GetProductListByCode | Get Collection by Code |
| [**GetProductListById**](ProductListApi.md#getproductlistbyid) | **POST** /productlist.ProductList/GetProductListById | Get Collection by Id |
| [**GetProductListByUrlKey**](ProductListApi.md#getproductlistbyurlkey) | **POST** /productlist.ProductList/GetProductListByUrlKey | Get Collection by Url Key |
| [**GetProductListsCount**](ProductListApi.md#getproductlistscount) | **POST** /productlist.ProductList/GetProductListsCount | Get Collection Product Count |
| [**ListProductListAssociations**](ProductListApi.md#listproductlistassociations) | **POST** /productlist.ProductList/ListProductListAssociations | List Collection/Product Associations |
| [**ListProductLists**](ProductListApi.md#listproductlists) | **POST** /productlist.ProductList/ListProductLists | List Collections |
| [**SearchProductLists**](ProductListApi.md#searchproductlists) | **POST** /productlist.ProductList/SearchProductLists | Search Collections |
| [**SearchProductListsByIds**](ProductListApi.md#searchproductlistsbyids) | **POST** /productlist.ProductList/SearchProductListsByIds | Search Collections by Ids |
| [**UpdateProductList**](ProductListApi.md#updateproductlist) | **POST** /productlist.ProductList/UpdateProductList | Update Collection |

<a id="bulkupdateproductlistassociations"></a>
# **BulkUpdateProductListAssociations**
> RpcStatus BulkUpdateProductListAssociations (ProductlistBulkUpdateProductListAssociationsRequest body)

Bulk update collection associations position

The BulkUpdateProductListAssociations endpoint updates the positions of specified associations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class BulkUpdateProductListAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistBulkUpdateProductListAssociationsRequest(); // ProductlistBulkUpdateProductListAssociationsRequest | 

            try
            {
                // Bulk update collection associations position
                RpcStatus result = apiInstance.BulkUpdateProductListAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.BulkUpdateProductListAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkUpdateProductListAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk update collection associations position
    ApiResponse<RpcStatus> response = apiInstance.BulkUpdateProductListAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.BulkUpdateProductListAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistBulkUpdateProductListAssociationsRequest**](ProductlistBulkUpdateProductListAssociationsRequest.md) |  |  |

### Return type

[**RpcStatus**](RpcStatus.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createproductlist"></a>
# **CreateProductList**
> ProductlistCreateProductListResponse CreateProductList (ProductlistCreateProductListRequest body)

Create Collection

The CreateProductList endpoint is used to create a new collection of products within the system. This endpoint allows users to define the details and attributes of the collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class CreateProductListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistCreateProductListRequest(); // ProductlistCreateProductListRequest | 

            try
            {
                // Create Collection
                ProductlistCreateProductListResponse result = apiInstance.CreateProductList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.CreateProductList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Collection
    ApiResponse<ProductlistCreateProductListResponse> response = apiInstance.CreateProductListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.CreateProductListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistCreateProductListRequest**](ProductlistCreateProductListRequest.md) |  |  |

### Return type

[**ProductlistCreateProductListResponse**](ProductlistCreateProductListResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createproductlistassociation"></a>
# **CreateProductListAssociation**
> ProductlistCreateProductListAssociationResponse CreateProductListAssociation (ProductlistCreateProductListAssociationRequest body)

Create Collection/Product Association

The CreateProductListAssociation endpoint is used to create an association between a collection and a product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class CreateProductListAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistCreateProductListAssociationRequest(); // ProductlistCreateProductListAssociationRequest | 

            try
            {
                // Create Collection/Product Association
                ProductlistCreateProductListAssociationResponse result = apiInstance.CreateProductListAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.CreateProductListAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductListAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Collection/Product Association
    ApiResponse<ProductlistCreateProductListAssociationResponse> response = apiInstance.CreateProductListAssociationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.CreateProductListAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistCreateProductListAssociationRequest**](ProductlistCreateProductListAssociationRequest.md) |  |  |

### Return type

[**ProductlistCreateProductListAssociationResponse**](ProductlistCreateProductListAssociationResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteproductlist"></a>
# **DeleteProductList**
> ProductlistDeleteProductListResponse DeleteProductList (ProductlistDeleteProductListRequest body)

Delete Collection

The DeleteProductList endpoint is used to delete an existing collection of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class DeleteProductListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistDeleteProductListRequest(); // ProductlistDeleteProductListRequest | 

            try
            {
                // Delete Collection
                ProductlistDeleteProductListResponse result = apiInstance.DeleteProductList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.DeleteProductList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Collection
    ApiResponse<ProductlistDeleteProductListResponse> response = apiInstance.DeleteProductListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.DeleteProductListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistDeleteProductListRequest**](ProductlistDeleteProductListRequest.md) |  |  |

### Return type

[**ProductlistDeleteProductListResponse**](ProductlistDeleteProductListResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteproductlistassociation"></a>
# **DeleteProductListAssociation**
> ProductlistDeleteProductListAssociationResponse DeleteProductListAssociation (ProductlistDeleteProductListAssociationRequest body)

Delete Collection/Product Association

The DeleteProductListAssociation endpoint is used to delete an association between a collection and a product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class DeleteProductListAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistDeleteProductListAssociationRequest(); // ProductlistDeleteProductListAssociationRequest | 

            try
            {
                // Delete Collection/Product Association
                ProductlistDeleteProductListAssociationResponse result = apiInstance.DeleteProductListAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.DeleteProductListAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductListAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Collection/Product Association
    ApiResponse<ProductlistDeleteProductListAssociationResponse> response = apiInstance.DeleteProductListAssociationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.DeleteProductListAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistDeleteProductListAssociationRequest**](ProductlistDeleteProductListAssociationRequest.md) |  |  |

### Return type

[**ProductlistDeleteProductListAssociationResponse**](ProductlistDeleteProductListAssociationResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductlistassociationsbyproductgrn"></a>
# **GetProductListAssociationsByProductGrn**
> ProductlistGetProductListAssociationsByProductGrnResponse GetProductListAssociationsByProductGrn (ProductlistGetProductListAssociationsByProductGrnRequest body)

Get Collection/Product Associations by Product GRN

The GetProductListAssociationsByProductGrn endpoint is used to get the associations between a collection and a list of products by product GRN.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class GetProductListAssociationsByProductGrnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistGetProductListAssociationsByProductGrnRequest(); // ProductlistGetProductListAssociationsByProductGrnRequest | 

            try
            {
                // Get Collection/Product Associations by Product GRN
                ProductlistGetProductListAssociationsByProductGrnResponse result = apiInstance.GetProductListAssociationsByProductGrn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.GetProductListAssociationsByProductGrn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListAssociationsByProductGrnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collection/Product Associations by Product GRN
    ApiResponse<ProductlistGetProductListAssociationsByProductGrnResponse> response = apiInstance.GetProductListAssociationsByProductGrnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.GetProductListAssociationsByProductGrnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistGetProductListAssociationsByProductGrnRequest**](ProductlistGetProductListAssociationsByProductGrnRequest.md) |  |  |

### Return type

[**ProductlistGetProductListAssociationsByProductGrnResponse**](ProductlistGetProductListAssociationsByProductGrnResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductlistbycode"></a>
# **GetProductListByCode**
> ProductlistGetProductListByCodeResponse GetProductListByCode (ProductlistGetProductListByCodeRequest body)

Get Collection by Code

The GetProductListByCode endpoint is used to retrieve an existing collection of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class GetProductListByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistGetProductListByCodeRequest(); // ProductlistGetProductListByCodeRequest | 

            try
            {
                // Get Collection by Code
                ProductlistGetProductListByCodeResponse result = apiInstance.GetProductListByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.GetProductListByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collection by Code
    ApiResponse<ProductlistGetProductListByCodeResponse> response = apiInstance.GetProductListByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.GetProductListByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistGetProductListByCodeRequest**](ProductlistGetProductListByCodeRequest.md) |  |  |

### Return type

[**ProductlistGetProductListByCodeResponse**](ProductlistGetProductListByCodeResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductlistbyid"></a>
# **GetProductListById**
> ProductlistGetProductListByIdResponse GetProductListById (ProductlistGetProductListByIdRequest body)

Get Collection by Id

The GetProductListById endpoint is used to retrieve an existing collection of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class GetProductListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistGetProductListByIdRequest(); // ProductlistGetProductListByIdRequest | 

            try
            {
                // Get Collection by Id
                ProductlistGetProductListByIdResponse result = apiInstance.GetProductListById(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.GetProductListById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collection by Id
    ApiResponse<ProductlistGetProductListByIdResponse> response = apiInstance.GetProductListByIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.GetProductListByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistGetProductListByIdRequest**](ProductlistGetProductListByIdRequest.md) |  |  |

### Return type

[**ProductlistGetProductListByIdResponse**](ProductlistGetProductListByIdResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductlistbyurlkey"></a>
# **GetProductListByUrlKey**
> ProductlistGetProductListByUrlKeyResponse GetProductListByUrlKey (ProductlistGetProductListByUrlKeyRequest body)

Get Collection by Url Key

The GetProductListByUrlKey endpoint is used to retrieve an existing collection of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class GetProductListByUrlKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistGetProductListByUrlKeyRequest(); // ProductlistGetProductListByUrlKeyRequest | 

            try
            {
                // Get Collection by Url Key
                ProductlistGetProductListByUrlKeyResponse result = apiInstance.GetProductListByUrlKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.GetProductListByUrlKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListByUrlKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collection by Url Key
    ApiResponse<ProductlistGetProductListByUrlKeyResponse> response = apiInstance.GetProductListByUrlKeyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.GetProductListByUrlKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistGetProductListByUrlKeyRequest**](ProductlistGetProductListByUrlKeyRequest.md) |  |  |

### Return type

[**ProductlistGetProductListByUrlKeyResponse**](ProductlistGetProductListByUrlKeyResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproductlistscount"></a>
# **GetProductListsCount**
> ProductlistGetProductListsCountResponse GetProductListsCount (ProductlistGetProductListsCountRequest body)

Get Collection Product Count

The GetProductListsCount endpoint is used to get the number of products associated with a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class GetProductListsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistGetProductListsCountRequest(); // ProductlistGetProductListsCountRequest | 

            try
            {
                // Get Collection Product Count
                ProductlistGetProductListsCountResponse result = apiInstance.GetProductListsCount(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.GetProductListsCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductListsCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collection Product Count
    ApiResponse<ProductlistGetProductListsCountResponse> response = apiInstance.GetProductListsCountWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.GetProductListsCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistGetProductListsCountRequest**](ProductlistGetProductListsCountRequest.md) |  |  |

### Return type

[**ProductlistGetProductListsCountResponse**](ProductlistGetProductListsCountResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductlistassociations"></a>
# **ListProductListAssociations**
> ProductlistListProductListAssociationsResponse ListProductListAssociations (ProductlistListProductListAssociationsRequest body)

List Collection/Product Associations

The ListProductListAssociations endpoint is used to list the associations between a collection and a list of products.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class ListProductListAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistListProductListAssociationsRequest(); // ProductlistListProductListAssociationsRequest | 

            try
            {
                // List Collection/Product Associations
                ProductlistListProductListAssociationsResponse result = apiInstance.ListProductListAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.ListProductListAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductListAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Collection/Product Associations
    ApiResponse<ProductlistListProductListAssociationsResponse> response = apiInstance.ListProductListAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.ListProductListAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistListProductListAssociationsRequest**](ProductlistListProductListAssociationsRequest.md) |  |  |

### Return type

[**ProductlistListProductListAssociationsResponse**](ProductlistListProductListAssociationsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductlists"></a>
# **ListProductLists**
> ProductlistListProductListsResponse ListProductLists (ProductlistListProductListsRequest body)

List Collections

The ListProductLists endpoint is used to retrieve a list of existing collections of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class ListProductListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistListProductListsRequest(); // ProductlistListProductListsRequest | 

            try
            {
                // List Collections
                ProductlistListProductListsResponse result = apiInstance.ListProductLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.ListProductLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Collections
    ApiResponse<ProductlistListProductListsResponse> response = apiInstance.ListProductListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.ListProductListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistListProductListsRequest**](ProductlistListProductListsRequest.md) |  |  |

### Return type

[**ProductlistListProductListsResponse**](ProductlistListProductListsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchproductlists"></a>
# **SearchProductLists**
> ProductlistSearchProductListsResponse SearchProductLists (ProductlistSearchProductListsRequest body)

Search Collections

The SearchProductLists endpoint is used to retrieve a list of existing collections of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class SearchProductListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistSearchProductListsRequest(); // ProductlistSearchProductListsRequest | 

            try
            {
                // Search Collections
                ProductlistSearchProductListsResponse result = apiInstance.SearchProductLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.SearchProductLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchProductListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Collections
    ApiResponse<ProductlistSearchProductListsResponse> response = apiInstance.SearchProductListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.SearchProductListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistSearchProductListsRequest**](ProductlistSearchProductListsRequest.md) |  |  |

### Return type

[**ProductlistSearchProductListsResponse**](ProductlistSearchProductListsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchproductlistsbyids"></a>
# **SearchProductListsByIds**
> ProductlistSearchProductListsByIdsResponse SearchProductListsByIds (ProductlistSearchProductListsByIdsRequest body)

Search Collections by Ids

The SearchProductListsByIds endpoint is used to retrieve a list of existing collections of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class SearchProductListsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistSearchProductListsByIdsRequest(); // ProductlistSearchProductListsByIdsRequest | 

            try
            {
                // Search Collections by Ids
                ProductlistSearchProductListsByIdsResponse result = apiInstance.SearchProductListsByIds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.SearchProductListsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchProductListsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Collections by Ids
    ApiResponse<ProductlistSearchProductListsByIdsResponse> response = apiInstance.SearchProductListsByIdsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.SearchProductListsByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistSearchProductListsByIdsRequest**](ProductlistSearchProductListsByIdsRequest.md) |  |  |

### Return type

[**ProductlistSearchProductListsByIdsResponse**](ProductlistSearchProductListsByIdsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproductlist"></a>
# **UpdateProductList**
> ProductlistUpdateProductListResponse UpdateProductList (ProductlistUpdateProductListRequest body)

Update Collection

The UpdateProductList endpoint is used to update an existing collection of products within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class UpdateProductListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-list.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductListApi(config);
            var body = new ProductlistUpdateProductListRequest(); // ProductlistUpdateProductListRequest | 

            try
            {
                // Update Collection
                ProductlistUpdateProductListResponse result = apiInstance.UpdateProductList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductListApi.UpdateProductList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Collection
    ApiResponse<ProductlistUpdateProductListResponse> response = apiInstance.UpdateProductListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductListApi.UpdateProductListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProductlistUpdateProductListRequest**](ProductlistUpdateProductListRequest.md) |  |  |

### Return type

[**ProductlistUpdateProductListResponse**](ProductlistUpdateProductListResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

