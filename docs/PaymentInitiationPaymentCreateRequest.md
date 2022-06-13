# Org.OpenAPITools.Model.PaymentInitiationPaymentCreateRequest
PaymentInitiationPaymentCreateRequest defines the request schema for `/payment_initiation/payment/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**RecipientId** | **string** | The ID of the recipient the payment is for. | 
**Reference** | **string** | A reference for the payment. This must be an alphanumeric string with at most 18 characters and must not contain any special characters (since not all institutions support them). | 
**Amount** | [**PaymentAmount**](PaymentAmount.md) |  | 
**Schedule** | [**ExternalPaymentScheduleRequest**](ExternalPaymentScheduleRequest.md) |  | [optional] 
**Options** | [**ExternalPaymentOptions**](ExternalPaymentOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

