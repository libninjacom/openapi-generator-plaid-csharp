# Org.OpenAPITools.Model.SignalEvaluateRequest
SignalEvaluateRequest defines the request schema for `/signal/evaluate`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccessToken** | **string** | The access token associated with the Item data is being requested for. | 
**AccountId** | **string** | The &#x60;account_id&#x60; of the account whose verification status is to be modified | 
**ClientTransactionId** | **string** | The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters. | 
**Amount** | **decimal** | The transaction amount, in USD (e.g. &#x60;102.05&#x60;) | 
**UserPresent** | **bool?** | &#x60;true&#x60; if the end user is present while initiating the ACH transfer and the endpoint is being called; &#x60;false&#x60; otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing). | [optional] 
**ClientUserId** | **string** | A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters. | [optional] 
**User** | [**SignalUser**](SignalUser.md) |  | [optional] 
**Device** | [**SignalDevice**](SignalDevice.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

