# Org.OpenAPITools.Model.ExternalPaymentOptions
Additional payment options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestRefundDetails** | **bool?** | When &#x60;true&#x60;, Plaid will attempt to request refund details from the payee&#39;s financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the &#x60;/payment_initiation/payment/get&#x60; response. | [optional] 
**Iban** | **string** | The International Bank Account Number (IBAN) for the payer&#39;s account. If provided, the end user will be able to send payments only from the specified bank account. | [optional] 
**Bacs** | [**PaymentInitiationOptionalRestrictionBacs**](PaymentInitiationOptionalRestrictionBacs.md) |  | [optional] 
**WalletId** | **string** | The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests. | [optional] 
**Scheme** | **PaymentScheme** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

