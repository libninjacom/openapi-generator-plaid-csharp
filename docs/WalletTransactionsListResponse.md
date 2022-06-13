# Org.OpenAPITools.Model.WalletTransactionsListResponse
WalletTransactionsListResponse defines the response schema for `/wallet/transactions/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transactions** | [**List&lt;WalletTransaction&gt;**](WalletTransaction.md) | An array of transactions of an e-wallet, associated with the given &#x60;wallet_id&#x60; | 
**NextCursor** | **string** | Cursor used for fetching transactions created before the latest transaction provided in this response | [optional] 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

