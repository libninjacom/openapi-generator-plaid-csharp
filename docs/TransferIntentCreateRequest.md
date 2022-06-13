# Org.OpenAPITools.Model.TransferIntentCreateRequest
Defines the request schema for `/transfer/intent/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | 
**AccountId** | **string** | The Plaid &#x60;account_id&#x60; for the account that will be debited or credited. | [optional] 
**Mode** | **TransferIntentCreateMode** |  | 
**Amount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**Description** | **string** | A description for the underlying transfer. Maximum of 8 characters. | 
**AchClass** | **ACHClass** |  | 
**OriginationAccountId** | **string** | Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used. | [optional] 
**User** | [**TransferUserInRequest**](TransferUserInRequest.md) |  | 
**Metadata** | **Dictionary&lt;string, string&gt;** | The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters  | [optional] 
**IsoCurrencyCode** | **string** | The currency of the transfer amount, e.g. \&quot;USD\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

