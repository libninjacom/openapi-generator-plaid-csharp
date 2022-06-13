# Org.OpenAPITools.Model.AssetsErrorWebhook
Fired when Asset Report generation has failed. The resulting `error` will have an `error_type` of `ASSET_REPORT_ERROR`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;ASSETS&#x60; | 
**WebhookCode** | **string** | &#x60;ERROR&#x60; | 
**Error** | [**PlaidError**](PlaidError.md) |  | 
**AssetReportId** | **string** | The ID associated with the Asset Report. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

