# Org.OpenAPITools.Model.StandaloneInvestmentTransactionType
Valid values for investment transaction types and subtypes. Note that transactions representing inflow of cash will appear as negative amounts, outflow of cash will appear as positive amounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Buy** | **string** | Buying an investment | 
**Sell** | **string** | Selling an investment | 
**Cancel** | **string** | A cancellation of a pending transaction | 
**Cash** | **string** | Activity that modifies a cash position | 
**Fee** | **string** | Fees on the account, e.g. commission, bookkeeping, options-related. | 
**Transfer** | **string** | Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

