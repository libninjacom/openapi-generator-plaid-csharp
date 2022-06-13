# Org.OpenAPITools.Model.PaymentInitiationPaymentCreateResponse
PaymentInitiationPaymentCreateResponse defines the response schema for `/payment_initiation/payment/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | A unique ID identifying the payment | 
**Status** | **string** | For a payment returned by this endpoint, there is only one possible value:  &#x60;PAYMENT_STATUS_INPUT_NEEDED&#x60;: The initial phase of the payment | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

