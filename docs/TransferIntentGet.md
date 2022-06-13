# Org.OpenAPITools.Model.TransferIntentGet
Represents a transfer intent within Transfer UI.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Plaid&#39;s unique identifier for a transfer intent object. | 
**Created** | **DateTime** | The datetime the transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;. | 
**Status** | **string** | The status of the transfer intent.  - &#x60;PENDING&#x60; – The transfer intent is pending. - &#x60;SUCCEEDED&#x60; – The transfer intent was successfully created. - &#x60;FAILED&#x60; – The transfer intent was unable to be created. | 
**TransferId** | **string** | Plaid&#39;s unique identifier for the transfer created through the UI. Returned only if the transfer was successfully created. Null value otherwise. | 
**FailureReason** | [**TransferIntentGetFailureReason**](TransferIntentGetFailureReason.md) |  | 
**AuthorizationDecision** | **string** |  A decision regarding the proposed transfer.  &#x60;APPROVED&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;PERMITTED&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;DECLINED&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details. Null value otherwise. | 
**AuthorizationDecisionRationale** | [**TransferAuthorizationDecisionRationale**](TransferAuthorizationDecisionRationale.md) |  | 
**AccountId** | **string** | The Plaid &#x60;account_id&#x60; for the account that will be debited or credited. Returned only if &#x60;account_id&#x60; was set on intent creation. | [optional] 
**OriginationAccountId** | **string** | Plaid’s unique identifier for the origination account used for the transfer. | 
**Amount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**Mode** | **TransferIntentCreateMode** |  | 
**AchClass** | **ACHClass** |  | 
**User** | [**TransferUserInResponse**](TransferUserInResponse.md) |  | 
**Description** | **string** | A description for the underlying transfer. Maximum of 8 characters. | 
**Metadata** | **Dictionary&lt;string, string&gt;** | The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters  | [optional] 
**IsoCurrencyCode** | **string** | The currency of the transfer amount, e.g. \&quot;USD\&quot; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

