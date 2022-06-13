# Org.OpenAPITools.Model.PaymentInitiationMetadata
Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupportsInternationalPayments** | **bool** | Indicates whether the institution supports payments from a different country. | 
**MaximumPaymentAmount** | **Dictionary&lt;string, string&gt;** | A mapping of currency to maximum payment amount (denominated in the smallest unit of currency) supported by the institution.  Example: &#x60;{\&quot;GBP\&quot;: \&quot;10000\&quot;}&#x60;  | 
**SupportsRefundDetails** | **bool** | Indicates whether the institution supports returning refund details when initiating a payment. | 
**StandingOrderMetadata** | [**PaymentInitiationStandingOrderMetadata**](PaymentInitiationStandingOrderMetadata.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

