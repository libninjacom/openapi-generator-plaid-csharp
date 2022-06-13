# Org.OpenAPITools.Model.TransferFailure
The failure reason if the event type for a transfer is `\"failed\"` or `\"reversed\"`. Null value otherwise.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchReturnCode** | **string** | The ACH return code, e.g. &#x60;R01&#x60;.  A return code will be provided if and only if the transfer status is &#x60;reversed&#x60;. For a full listing of ACH return codes, see [Transfer errors](https://plaid.com/docs/errors/transfer/#ach-return-codes). | [optional] 
**Description** | **string** | A human-readable description of the reason for the failure or reversal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

