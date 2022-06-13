# Org.OpenAPITools.Model.TransactionStream
A grouping of related transactions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The ID of the account to which the stream belongs | 
**StreamId** | **string** | A unique id for the stream | 
**CategoryId** | **string** | The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview). | 
**Category** | **List&lt;string&gt;** | A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview). | 
**Description** | **string** | A description of the transaction stream. | 
**FirstDate** | **DateTime** | The posted date of the earliest transaction in the stream. | 
**LastDate** | **DateTime** | The posted date of the latest transaction in the stream. | 
**Frequency** | **RecurringTransactionFrequency** |  | 
**TransactionIds** | **List&lt;string&gt;** | An array of Plaid transaction IDs belonging to the stream, sorted by posted date. | 
**AverageAmount** | [**TransactionStreamAmount**](TransactionStreamAmount.md) |  | 
**IsActive** | **bool** | indicates whether the transaction stream is still live. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

