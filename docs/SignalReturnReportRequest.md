# Org.OpenAPITools.Model.SignalReturnReportRequest
SignalReturnReportRequest defines the request schema for `/signal/return/report`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**ClientTransactionId** | **string** | Must be the same as the &#x60;client_transaction_id&#x60; supplied when calling &#x60;/signal/evaluate&#x60; | 
**ReturnCode** | **string** | Must be a valid ACH return code (e.g. \&quot;R01\&quot;) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

