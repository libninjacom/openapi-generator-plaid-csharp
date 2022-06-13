# Org.OpenAPITools.Model.TransferIntentGetFailureReason
The reason for a failed transfer intent. Returned only if the transfer intent status is `failed`. Null otherwise.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorType** | **string** | A broad categorization of the error. | [optional] 
**ErrorCode** | **string** | A code representing the reason for a failed transfer intent (i.e., an API error or the authorization being declined).  For a full listing of bank transfer errors, see [Bank Transfers errors](https://plaid.com/docs/errors/bank-transfers/). | [optional] 
**ErrorMessage** | **string** | A human-readable description of the code associated with a failed transfer intent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

