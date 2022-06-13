# Org.OpenAPITools.Model.TransferEvent
Represents an event in the Transfers API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **int** | Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers. | 
**Timestamp** | **DateTime** | The datetime when this event occurred. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;. | 
**EventType** | **TransferEventType** |  | 
**AccountId** | **string** | The account ID associated with the transfer. | 
**TransferId** | **string** | Plaid’s unique identifier for a transfer. | 
**OriginationAccountId** | **string** | The ID of the origination account that this balance belongs to. | 
**TransferType** | **TransferType** |  | 
**TransferAmount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**FailureReason** | [**TransferFailure**](TransferFailure.md) |  | 
**SweepId** | **string** | Plaid’s unique identifier for a sweep. | 
**SweepAmount** | **string** | A signed amount of how much was &#x60;swept&#x60; or &#x60;reverse_swept&#x60; (decimal string with two digits of precision e.g. \&quot;-5.50\&quot;). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

