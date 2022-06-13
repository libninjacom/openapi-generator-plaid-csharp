# Org.OpenAPITools.Model.TransferAuthorizationCreateRequest
Defines the request schema for `/transfer/authorization/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccessToken** | **string** | The Plaid &#x60;access_token&#x60; for the account that will be debited or credited. | 
**AccountId** | **string** | The Plaid &#x60;account_id&#x60; for the account that will be debited or credited. | 
**Type** | **TransferType** |  | 
**Network** | **TransferNetwork** |  | 
**Amount** | **string** | The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). | 
**AchClass** | **ACHClass** |  | 
**User** | [**TransferUserInRequest**](TransferUserInRequest.md) |  | 
**Device** | [**TransferAuthorizationDevice**](TransferAuthorizationDevice.md) |  | [optional] 
**OriginationAccountId** | **string** | Plaid&#39;s unique identifier for the origination account for this authorization. If not specified, the default account will be used. | [optional] 
**IsoCurrencyCode** | **string** | The currency of the transfer amount. The default value is \&quot;USD\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

