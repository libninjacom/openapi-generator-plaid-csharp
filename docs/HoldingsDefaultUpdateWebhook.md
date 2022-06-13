# Org.OpenAPITools.Model.HoldingsDefaultUpdateWebhook
Fired when new or updated holdings have been detected on an investment account. The webhook typically fires once per day, after market close, in response to any newly added holdings or price changes to existing holdings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;HOLDINGS&#x60; | 
**WebhookCode** | **string** | &#x60;DEFAULT_UPDATE&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 
**NewHoldings** | **decimal** | The number of new holdings reported since the last time this webhook was fired. | 
**UpdatedHoldings** | **decimal** | The number of updated holdings reported since the last time this webhook was fired. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

