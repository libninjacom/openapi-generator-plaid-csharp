# Org.OpenAPITools.Model.AssetReportGetResponse
AssetReportGetResponse defines the response schema for `/asset_report/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Report** | [**AssetReport**](AssetReport.md) |  | 
**Warnings** | [**List&lt;Warning&gt;**](Warning.md) | If the Asset Report generation was successful but identity information cannot be returned, this array will contain information about the errors causing identity information to be missing | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

