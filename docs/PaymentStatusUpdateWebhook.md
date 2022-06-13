# Org.OpenAPITools.Model.PaymentStatusUpdateWebhook
Fired when the status of a payment has changed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;PAYMENT_INITIATION&#x60; | 
**WebhookCode** | **string** | &#x60;PAYMENT_STATUS_UPDATE&#x60; | 
**PaymentId** | **string** | The &#x60;payment_id&#x60; for the payment being updated | 
**NewPaymentStatus** | **PaymentInitiationPaymentStatus** |  | 
**OldPaymentStatus** | **PaymentInitiationPaymentStatus** |  | 
**OriginalReference** | **string** | The original value of the reference when creating the payment. | 
**AdjustedReference** | **string** | The value of the reference sent to the bank after adjustment to pass bank validation rules. | [optional] 
**OriginalStartDate** | **DateTime?** | The original value of the &#x60;start_date&#x60; provided during the creation of a standing order. If the payment is not a standing order, this field will be &#x60;null&#x60;. | 
**AdjustedStartDate** | **DateTime?** | The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). If the start date did not require adjustment, or if the payment is not a standing order, this field will be &#x60;null&#x60;. | 
**Timestamp** | **DateTime** | The timestamp of the update, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2017-09-14T14:42:19.350Z\&quot;&#x60; | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

