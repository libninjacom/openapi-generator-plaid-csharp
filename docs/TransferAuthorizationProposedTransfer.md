# Org.OpenAPITools.Model.TransferAuthorizationProposedTransfer
Details regarding the proposed transfer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchClass** | **ACHClass** |  | 
**AccountId** | **string** | The Plaid &#x60;account_id&#x60; for the account that will be debited or credited. | 
**Type** | **TransferType** |  | 
**User** | [**TransferUserInResponse**](TransferUserInResponse.md) |  | 
**Amount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**Network** | **string** | The network or rails used for the transfer. | 
**OriginationAccountId** | **string** | Plaid&#39;s unique identifier for the origination account that was used for this transfer. | 
**IsoCurrencyCode** | **string** | The currency of the transfer amount. The default value is \&quot;USD\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

