# Org.OpenAPITools.Model.BankTransfer
Represents a bank transfer within the Bank Transfers API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Plaid’s unique identifier for a bank transfer. | 
**AchClass** | **ACHClass** |  | 
**AccountId** | **string** | The account ID that should be credited/debited for this bank transfer. | 
**Type** | **BankTransferType** |  | 
**User** | [**BankTransferUser**](BankTransferUser.md) |  | 
**Amount** | **string** | The amount of the bank transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**IsoCurrencyCode** | **string** | The currency of the transfer amount, e.g. \&quot;USD\&quot; | 
**Description** | **string** | The description of the transfer. | 
**Created** | **DateTime** | The datetime when this bank transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60; | 
**Status** | **BankTransferStatus** |  | 
**Network** | **BankTransferNetwork** |  | 
**Cancellable** | **bool** | When &#x60;true&#x60;, you can still cancel this bank transfer. | 
**FailureReason** | [**BankTransferFailure**](BankTransferFailure.md) |  | 
**CustomTag** | **string** | A string containing the custom tag provided by the client in the create request. Will be null if not provided. | 
**Metadata** | **Dictionary&lt;string, string&gt;** | The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters  | 
**OriginationAccountId** | **string** | Plaid’s unique identifier for the origination account that was used for this transfer. | 
**Direction** | **BankTransferDirection** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

