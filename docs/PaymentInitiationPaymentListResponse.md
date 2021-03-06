# Org.OpenAPITools.Model.PaymentInitiationPaymentListResponse
PaymentInitiationPaymentListResponse defines the response schema for `/payment_initiation/payment/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payments** | [**List&lt;PaymentInitiationPayment&gt;**](PaymentInitiationPayment.md) | An array of payments that have been created, associated with the given &#x60;client_id&#x60;. | 
**NextCursor** | **DateTime?** | The value that, when used as the optional &#x60;cursor&#x60; parameter to &#x60;/payment_initiation/payment/list&#x60;, will return the next unreturned payment as its first payment. | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

