# Org.OpenAPITools.Model.InvestmentsDefaultUpdateWebhook
Fired when new or canceled transactions have been detected on an investment account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;INVESTMENTS_TRANSACTIONS&#x60; | 
**WebhookCode** | **string** | &#x60;DEFAULT_UPDATE&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 
**NewInvestmentsTransactions** | **decimal** | The number of new transactions reported since the last time this webhook was fired. | 
**CanceledInvestmentsTransactions** | **decimal** | The number of canceled transactions reported since the last time this webhook was fired. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

