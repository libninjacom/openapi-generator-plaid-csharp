# Org.OpenAPITools.Model.DepositSwitchAltCreateRequest
DepositSwitchAltCreateRequest defines the request schema for `/deposit_switch/alt/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**TargetAccount** | [**DepositSwitchTargetAccount**](DepositSwitchTargetAccount.md) |  | 
**TargetUser** | [**DepositSwitchTargetUser**](DepositSwitchTargetUser.md) |  | 
**Options** | [**DepositSwitchCreateRequestOptions**](DepositSwitchCreateRequestOptions.md) |  | [optional] 
**CountryCode** | **string** | ISO-3166-1 alpha-2 country code standard. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

