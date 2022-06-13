# Org.OpenAPITools.Model.PaymentInitiationPaymentListRequest
PaymentInitiationPaymentListRequest defines the request schema for `/payment_initiation/payment/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**Count** | **int?** | The maximum number of payments to return. If &#x60;count&#x60; is not specified, a maximum of 10 payments will be returned, beginning with the most recent payment before the cursor (if specified). | [optional] [default to 10]
**Cursor** | **DateTime?** | A string in RFC 3339 format (i.e. \&quot;2019-12-06T22:35:49Z\&quot;). Only payments created before the cursor will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

