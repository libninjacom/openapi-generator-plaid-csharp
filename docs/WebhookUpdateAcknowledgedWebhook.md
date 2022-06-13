# Org.OpenAPITools.Model.WebhookUpdateAcknowledgedWebhook
Fired when an Item's webhook is updated. This will be sent to the newly specified webhook.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;ITEM&#x60; | 
**WebhookCode** | **string** | &#x60;WEBHOOK_UPDATE_ACKNOWLEDGED&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**NewWebhookUrl** | **string** | The new webhook URL | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

