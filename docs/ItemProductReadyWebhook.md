# Org.OpenAPITools.Model.ItemProductReadyWebhook
Fired once Plaid calculates income from an Item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;INCOME&#x60; | 
**WebhookCode** | **string** | &#x60;PRODUCT_READY&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

