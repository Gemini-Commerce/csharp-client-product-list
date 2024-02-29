# product-list - the C# library for the Collection Service

API for managing collection

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using product-list.Api;
using product-list.Client;
using product-list.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out product-list.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-list.Api;
using product-list.Client;
using product-list.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProductListApi.BulkUpdateProductListAssociations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://product-list.api.gogemini.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ProductListApi* | [**BulkUpdateProductListAssociations**](docs/ProductListApi.md#bulkupdateproductlistassociations) | **POST** /productlist.ProductList/BulkUpdateProductListAssociations | Bulk update collection associations position
*ProductListApi* | [**CreateProductList**](docs/ProductListApi.md#createproductlist) | **POST** /productlist.ProductList/CreateProductList | Create Collection
*ProductListApi* | [**CreateProductListAssociation**](docs/ProductListApi.md#createproductlistassociation) | **POST** /productlist.ProductList/CreateProductListAssociation | Create Collection/Product Association
*ProductListApi* | [**DeleteProductList**](docs/ProductListApi.md#deleteproductlist) | **POST** /productlist.ProductList/DeleteProductList | Delete Collection
*ProductListApi* | [**DeleteProductListAssociation**](docs/ProductListApi.md#deleteproductlistassociation) | **POST** /productlist.ProductList/DeleteProductListAssociation | Delete Collection/Product Association
*ProductListApi* | [**GetProductListAssociationsByProductGrn**](docs/ProductListApi.md#getproductlistassociationsbyproductgrn) | **POST** /productlist.ProductList/GetProductListAssociationsByProductGrn | Get Collection/Product Associations by Product GRN
*ProductListApi* | [**GetProductListByCode**](docs/ProductListApi.md#getproductlistbycode) | **POST** /productlist.ProductList/GetProductListByCode | Get Collection by Code
*ProductListApi* | [**GetProductListById**](docs/ProductListApi.md#getproductlistbyid) | **POST** /productlist.ProductList/GetProductListById | Get Collection by Id
*ProductListApi* | [**GetProductListByUrlKey**](docs/ProductListApi.md#getproductlistbyurlkey) | **POST** /productlist.ProductList/GetProductListByUrlKey | Get Collection by Url Key
*ProductListApi* | [**GetProductListsCount**](docs/ProductListApi.md#getproductlistscount) | **POST** /productlist.ProductList/GetProductListsCount | Get Collection Product Count
*ProductListApi* | [**ListProductListAssociations**](docs/ProductListApi.md#listproductlistassociations) | **POST** /productlist.ProductList/ListProductListAssociations | List Collection/Product Associations
*ProductListApi* | [**ListProductLists**](docs/ProductListApi.md#listproductlists) | **POST** /productlist.ProductList/ListProductLists | List Collections
*ProductListApi* | [**SearchProductLists**](docs/ProductListApi.md#searchproductlists) | **POST** /productlist.ProductList/SearchProductLists | Search Collections
*ProductListApi* | [**SearchProductListsByIds**](docs/ProductListApi.md#searchproductlistsbyids) | **POST** /productlist.ProductList/SearchProductListsByIds | Search Collections by Ids
*ProductListApi* | [**UpdateProductList**](docs/ProductListApi.md#updateproductlist) | **POST** /productlist.ProductList/UpdateProductList | Update Collection


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.OrderByDirection](docs/OrderByDirection.md)
 - [Model.ProductlistBulkUpdateProductListAssociationsRequest](docs/ProductlistBulkUpdateProductListAssociationsRequest.md)
 - [Model.ProductlistBulkUpdateProductListAssociationsRequestProductListAssociation](docs/ProductlistBulkUpdateProductListAssociationsRequestProductListAssociation.md)
 - [Model.ProductlistCreateProductListAssociationRequest](docs/ProductlistCreateProductListAssociationRequest.md)
 - [Model.ProductlistCreateProductListAssociationResponse](docs/ProductlistCreateProductListAssociationResponse.md)
 - [Model.ProductlistCreateProductListRequest](docs/ProductlistCreateProductListRequest.md)
 - [Model.ProductlistCreateProductListResponse](docs/ProductlistCreateProductListResponse.md)
 - [Model.ProductlistDeleteProductListAssociationRequest](docs/ProductlistDeleteProductListAssociationRequest.md)
 - [Model.ProductlistDeleteProductListAssociationResponse](docs/ProductlistDeleteProductListAssociationResponse.md)
 - [Model.ProductlistDeleteProductListRequest](docs/ProductlistDeleteProductListRequest.md)
 - [Model.ProductlistDeleteProductListResponse](docs/ProductlistDeleteProductListResponse.md)
 - [Model.ProductlistGetProductListAssociationsByProductGrnRequest](docs/ProductlistGetProductListAssociationsByProductGrnRequest.md)
 - [Model.ProductlistGetProductListAssociationsByProductGrnResponse](docs/ProductlistGetProductListAssociationsByProductGrnResponse.md)
 - [Model.ProductlistGetProductListByCodeRequest](docs/ProductlistGetProductListByCodeRequest.md)
 - [Model.ProductlistGetProductListByCodeResponse](docs/ProductlistGetProductListByCodeResponse.md)
 - [Model.ProductlistGetProductListByIdRequest](docs/ProductlistGetProductListByIdRequest.md)
 - [Model.ProductlistGetProductListByIdResponse](docs/ProductlistGetProductListByIdResponse.md)
 - [Model.ProductlistGetProductListByUrlKeyRequest](docs/ProductlistGetProductListByUrlKeyRequest.md)
 - [Model.ProductlistGetProductListByUrlKeyResponse](docs/ProductlistGetProductListByUrlKeyResponse.md)
 - [Model.ProductlistGetProductListsCountRequest](docs/ProductlistGetProductListsCountRequest.md)
 - [Model.ProductlistGetProductListsCountResponse](docs/ProductlistGetProductListsCountResponse.md)
 - [Model.ProductlistListProductListAssociationsRequest](docs/ProductlistListProductListAssociationsRequest.md)
 - [Model.ProductlistListProductListAssociationsResponse](docs/ProductlistListProductListAssociationsResponse.md)
 - [Model.ProductlistListProductListsRequest](docs/ProductlistListProductListsRequest.md)
 - [Model.ProductlistListProductListsResponse](docs/ProductlistListProductListsResponse.md)
 - [Model.ProductlistLocalizedText](docs/ProductlistLocalizedText.md)
 - [Model.ProductlistOrderBy](docs/ProductlistOrderBy.md)
 - [Model.ProductlistProductListAssociation](docs/ProductlistProductListAssociation.md)
 - [Model.ProductlistProductListAssociationError](docs/ProductlistProductListAssociationError.md)
 - [Model.ProductlistProductListEntity](docs/ProductlistProductListEntity.md)
 - [Model.ProductlistProductListError](docs/ProductlistProductListError.md)
 - [Model.ProductlistSearchProductListsByIdsRequest](docs/ProductlistSearchProductListsByIdsRequest.md)
 - [Model.ProductlistSearchProductListsByIdsResponse](docs/ProductlistSearchProductListsByIdsResponse.md)
 - [Model.ProductlistSearchProductListsRequest](docs/ProductlistSearchProductListsRequest.md)
 - [Model.ProductlistSearchProductListsResponse](docs/ProductlistSearchProductListsResponse.md)
 - [Model.ProductlistUpdateProductListRequest](docs/ProductlistUpdateProductListRequest.md)
 - [Model.ProductlistUpdateProductListResponse](docs/ProductlistUpdateProductListResponse.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.RpcStatus](docs/RpcStatus.md)
 - [Model.SearchProductListsRequestQuery](docs/SearchProductListsRequestQuery.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="standardAuthorization"></a>
### standardAuthorization

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: 
- **Scopes**: N/A

