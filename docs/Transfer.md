# Org.OpenAPITools.Model.Transfer
Represents a transfer within the Transfers API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Plaid’s unique identifier for a transfer. | 
**AchClass** | **ACHClass** |  | 
**AccountId** | **string** | The account ID that should be credited/debited for this transfer. | 
**Type** | **TransferType** |  | 
**User** | [**TransferUserInResponse**](TransferUserInResponse.md) |  | 
**Amount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**Description** | **string** | The description of the transfer. | 
**Created** | **DateTime** | The datetime when this transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60; | 
**Status** | **TransferStatus** |  | 
**SweepStatus** | **TransferSweepStatus** |  | [optional] 
**Network** | **TransferNetwork** |  | 
**Cancellable** | **bool** | When &#x60;true&#x60;, you can still cancel this transfer. | 
**FailureReason** | [**TransferFailure**](TransferFailure.md) |  | 
**Metadata** | **Dictionary&lt;string, string&gt;** | The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters  | 
**OriginationAccountId** | **string** | Plaid’s unique identifier for the origination account that was used for this transfer. | 
**GuaranteeDecision** | **TransferAuthorizationGuaranteeDecision** |  | 
**GuaranteeDecisionRationale** | [**TransferAuthorizationGuaranteeDecisionRationale**](TransferAuthorizationGuaranteeDecisionRationale.md) |  | 
**IsoCurrencyCode** | **string** | The currency of the transfer amount, e.g. \&quot;USD\&quot; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

