# Org.OpenAPITools.Model.WalletTransaction
The transaction details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | A unique ID identifying the transaction | 
**Reference** | **string** | A reference for the transaction | 
**Type** | **string** | The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported. | 
**Amount** | [**WalletTransactionAmount**](WalletTransactionAmount.md) |  | 
**Counterparty** | [**WalletTransactionCounterparty**](WalletTransactionCounterparty.md) |  | 
**Status** | **WalletTransactionStatus** |  | 
**CreatedAt** | **DateTime** | Timestamp when the transaction was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

