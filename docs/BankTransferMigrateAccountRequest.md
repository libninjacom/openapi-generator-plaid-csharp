# Org.OpenAPITools.Model.BankTransferMigrateAccountRequest
Defines the request schema for `/bank_transfer/migrate_account`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccountNumber** | **string** | The user&#39;s account number. | 
**RoutingNumber** | **string** | The user&#39;s routing number. | 
**AccountType** | **string** | The type of the bank account (&#x60;checking&#x60; or &#x60;savings&#x60;). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

