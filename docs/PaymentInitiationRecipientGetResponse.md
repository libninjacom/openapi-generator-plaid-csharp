# Org.OpenAPITools.Model.PaymentInitiationRecipientGetResponse
PaymentInitiationRecipientGetResponse defines the response schema for `/payment_initiation/recipient/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipientId** | **string** | The ID of the recipient. | 
**Name** | **string** | The name of the recipient. | 
**Address** | [**PaymentInitiationAddress**](PaymentInitiationAddress.md) |  | [optional] 
**Iban** | **string** | The International Bank Account Number (IBAN) for the recipient. | [optional] 
**Bacs** | [**RecipientBACSNullable**](RecipientBACSNullable.md) |  | [optional] 
**EmiRecipientId** | **string** | The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests. | [optional] 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

