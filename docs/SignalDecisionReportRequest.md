# Org.OpenAPITools.Model.SignalDecisionReportRequest
SignalDecisionReportRequest defines the request schema for `/signal/decision/report`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**ClientTransactionId** | **string** | Must be the same as the &#x60;client_transaction_id&#x60; supplied when calling &#x60;/signal/evaluate&#x60; | 
**Initiated** | **bool** | &#x60;true&#x60; if the ACH transaction was initiated, &#x60;false&#x60; otherwise. | 
**DaysFundsOnHold** | **int?** | The actual number of days (hold time) since the ACH debit transaction that you wait before making funds available to your customers. The holding time could affect the ACH return rate. For example, use 0 if you make funds available to your customers instantly or the same day following the debit transaction, or 1 if you make funds available the next day following the debit initialization. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

