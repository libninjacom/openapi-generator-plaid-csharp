# Org.OpenAPITools.Model.PaymentInitiationPayment
PaymentInitiationPayment defines a payment initiation payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | The ID of the payment. Like all Plaid identifiers, the &#x60;payment_id&#x60; is case sensitive. | 
**Amount** | [**PaymentAmount**](PaymentAmount.md) |  | 
**Status** | **PaymentInitiationPaymentStatus** |  | 
**RecipientId** | **string** | The ID of the recipient | 
**Reference** | **string** | A reference for the payment. | 
**AdjustedReference** | **string** | The value of the reference sent to the bank after adjustment to pass bank validation rules. | [optional] 
**LastStatusUpdate** | **DateTime** | The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format | 
**Schedule** | [**ExternalPaymentScheduleGet**](ExternalPaymentScheduleGet.md) |  | [optional] 
**RefundDetails** | [**ExternalPaymentRefundDetails**](ExternalPaymentRefundDetails.md) |  | [optional] 
**Bacs** | [**SenderBACSNullable**](SenderBACSNullable.md) |  | 
**Iban** | **string** | The International Bank Account Number (IBAN) for the sender, if specified in the &#x60;/payment_initiation/payment/create&#x60; call. | 
**InitiatedRefunds** | [**List&lt;PaymentInitiationRefund&gt;**](PaymentInitiationRefund.md) | Initiated refunds associated with the payment. | [optional] 
**WalletId** | **string** | The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests. | [optional] 
**Scheme** | **PaymentScheme** |  | [optional] 
**AdjustedScheme** | **PaymentScheme** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

