# Org.OpenAPITools.Model.BankTransferEvent
Represents an event in the Bank Transfers API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **int** | Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers. | 
**Timestamp** | **DateTime** | The datetime when this event occurred. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;. | 
**EventType** | **BankTransferEventType** |  | 
**AccountId** | **string** | The account ID associated with the bank transfer. | 
**BankTransferId** | **string** | Plaid’s unique identifier for a bank transfer. | 
**OriginationAccountId** | **string** | The ID of the origination account that this balance belongs to. | 
**BankTransferType** | **BankTransferType** |  | 
**BankTransferAmount** | **string** | The bank transfer amount. | 
**BankTransferIsoCurrencyCode** | **string** | The currency of the bank transfer amount. | 
**FailureReason** | [**BankTransferFailure**](BankTransferFailure.md) |  | 
**Direction** | **BankTransferDirection** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

