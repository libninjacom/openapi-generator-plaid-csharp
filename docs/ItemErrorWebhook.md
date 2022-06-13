# Org.OpenAPITools.Model.ItemErrorWebhook
Fired when an error is encountered with an Item. The error can be resolved by having the user go through Link’s update mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;ITEM&#x60; | 
**WebhookCode** | **string** | &#x60;ERROR&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**Error** | [**PlaidError**](PlaidError.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

