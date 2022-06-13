# Org.OpenAPITools.Model.TransferAuthorization
Contains the authorization decision for a proposed transfer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Plaid’s unique identifier for a transfer authorization. | 
**Created** | **DateTime** | The datetime representing when the authorization was created, in the format &#x60;2006-01-02T15:04:05Z&#x60;. | 
**Decision** | **string** |  A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details. | 
**DecisionRationale** | [**TransferAuthorizationDecisionRationale**](TransferAuthorizationDecisionRationale.md) |  | 
**GuaranteeDecision** | **TransferAuthorizationGuaranteeDecision** |  | 
**GuaranteeDecisionRationale** | [**TransferAuthorizationGuaranteeDecisionRationale**](TransferAuthorizationGuaranteeDecisionRationale.md) |  | 
**ProposedTransfer** | [**TransferAuthorizationProposedTransfer**](TransferAuthorizationProposedTransfer.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

