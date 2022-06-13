# Org.OpenAPITools.Model.TransactionsRemovedWebhook
Fired when transaction(s) for an Item are deleted. The deleted transaction IDs are included in the webhook payload. Plaid will typically check for deleted transaction data several times a day.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;TRANSACTIONS&#x60; | 
**WebhookCode** | **string** | &#x60;TRANSACTIONS_REMOVED&#x60; | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 
**RemovedTransactions** | **List&lt;string&gt;** | An array of &#x60;transaction_ids&#x60; corresponding to the removed transactions | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

