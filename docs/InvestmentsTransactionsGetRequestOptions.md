# Org.OpenAPITools.Model.InvestmentsTransactionsGetRequestOptions
An optional object to filter `/investments/transactions/get` results. If provided, must be non-`null`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountIds** | **List&lt;string&gt;** | An array of &#x60;account_ids&#x60; to retrieve for the Item. | [optional] 
**Count** | **int** | The number of transactions to fetch.  | [optional] [default to 100]
**Offset** | **int** | The number of transactions to skip when fetching transaction history | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

