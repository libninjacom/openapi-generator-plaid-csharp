# Org.OpenAPITools.Model.InvestmentsTransactionsGetResponse
InvestmentsTransactionsGetResponse defines the response schema for `/investments/transactions/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Item** | [**Item**](Item.md) |  | 
**Accounts** | [**List&lt;AccountBase&gt;**](AccountBase.md) | The accounts for which transaction history is being fetched. | 
**Securities** | [**List&lt;Security&gt;**](Security.md) | All securities for which there is a corresponding transaction being fetched. | 
**InvestmentTransactions** | [**List&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md) | The transactions being fetched | 
**TotalInvestmentTransactions** | **int** | The total number of transactions available within the date range specified. If &#x60;total_investment_transactions&#x60; is larger than the size of the &#x60;transactions&#x60; array, more transactions are available and can be fetched via manipulating the &#x60;offset&#x60; parameter.&#39; | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

