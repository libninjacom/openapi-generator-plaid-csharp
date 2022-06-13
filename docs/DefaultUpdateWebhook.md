# Org.OpenAPITools.Model.DefaultUpdateWebhook
Fired when new transaction data is available for an Item. Plaid will typically check for new transaction data several times a day. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;TRANSACTIONS&#x60; | 
**WebhookCode** | **string** | &#x60;DEFAULT_UPDATE&#x60; | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 
**NewTransactions** | **decimal** | The number of new transactions detected since the last time this webhook was fired. | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item the webhook relates to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

