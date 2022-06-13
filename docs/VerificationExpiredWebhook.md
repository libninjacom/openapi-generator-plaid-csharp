# Org.OpenAPITools.Model.VerificationExpiredWebhook
Fired when an Item was not verified via automated micro-deposits after seven days since the automated micro-deposit was made.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;AUTH&#x60; | 
**WebhookCode** | **string** | &#x60;VERIFICATION_EXPIRED&#x60; | 
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**AccountId** | **string** | The &#x60;account_id&#x60; of the account associated with the webhook | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

