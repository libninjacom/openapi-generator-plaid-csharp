# Org.OpenAPITools.Model.TransactionsRecurringGetResponse
TransactionsRecurringGetResponse defines the response schema for `/transactions/recurring/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InflowStreams** | [**List&lt;TransactionStream&gt;**](TransactionStream.md) | An array of depository transaction streams. | 
**OutflowStreams** | [**List&lt;TransactionStream&gt;**](TransactionStream.md) | An array of expense transaction streams. | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

