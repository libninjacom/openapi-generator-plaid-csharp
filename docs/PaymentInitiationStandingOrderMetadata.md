# Org.OpenAPITools.Model.PaymentInitiationStandingOrderMetadata
Metadata specifically related to valid Payment Initiation standing order configurations for the institution.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupportsStandingOrderEndDate** | **bool** | Indicates whether the institution supports closed-ended standing orders by providing an end date. | 
**SupportsStandingOrderNegativeExecutionDays** | **bool** | This is only applicable to &#x60;MONTHLY&#x60; standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a &#x60;MONTHLY&#x60; standing order relative to the end of the month. | 
**ValidStandingOrderIntervals** | [**List&lt;PaymentScheduleInterval&gt;**](PaymentScheduleInterval.md) | A list of the valid standing order intervals supported by the institution. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

