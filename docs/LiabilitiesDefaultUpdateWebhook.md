# Org.OpenAPITools.Model.LiabilitiesDefaultUpdateWebhook
The webhook of type `LIABILITIES` and code `DEFAULT_UPDATE` will be fired when new or updated liabilities have been detected on a liabilities item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;LIABILITIES&#x60; | 
**WebhookCode** | **string** | &#x60;DEFAULT_UPDATE&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**Error** | [**PlaidError**](PlaidError.md) |  | 
**AccountIdsWithNewLiabilities** | **List&lt;string&gt;** | An array of &#x60;account_id&#x60;&#39;s for accounts that contain new liabilities.&#39; | 
**AccountIdsWithUpdatedLiabilities** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | An object with keys of &#x60;account_id&#x60;&#39;s that are mapped to their respective liabilities fields that changed.  Example: &#x60;{ \&quot;XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58\&quot;: [\&quot;past_amount_due\&quot;] }&#x60;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

