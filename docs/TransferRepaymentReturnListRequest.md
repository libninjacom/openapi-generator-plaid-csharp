# Org.OpenAPITools.Model.TransferRepaymentReturnListRequest
Defines the request schema for `/transfer/repayment/return/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**RepaymentId** | **string** | Identifier of the repayment to query. | 
**Count** | **int?** | The maximum number of repayments to return. | [optional] [default to 25]
**Offset** | **int** | The number of repayments to skip before returning results. | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

