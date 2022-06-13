# Org.OpenAPITools.Model.SandboxItemFireWebhookRequest
SandboxItemFireWebhookRequest defines the request schema for `/sandbox/item/fire_webhook`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccessToken** | **string** | The access token associated with the Item data is being requested for. | 
**WebhookCode** | **string** | The following values for &#x60;webhook_code&#x60; are supported:  * &#x60;DEFAULT_UPDATE&#x60; * &#x60;NEW_ACCOUNTS_AVAILABLE&#x60; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

