# Org.OpenAPITools.Model.TransferRepayment
A repayment is created automatically after one or more guaranteed transactions receive a return. If there are multiple eligible returns in a day, they are batched together into a single repayment.  Repayments are sent over ACH, with funds typically available on the next banking day.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RepaymentId** | **string** | Identifier of the repayment. | 
**Created** | **DateTime** | The datetime when the repayment occurred, in RFC 3339 format. | 
**Amount** | **string** | Decimal amount of the repayment as it appears on your account ledger. | 
**IsoCurrencyCode** | **string** | The currency of the repayment, e.g. \&quot;USD\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

