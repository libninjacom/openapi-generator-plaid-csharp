# Org.OpenAPITools.Model.BankTransferListRequest
Defines the request schema for `/bank_transfer/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**StartDate** | **DateTime?** | The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;) | [optional] 
**EndDate** | **DateTime?** | The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;) | [optional] 
**Count** | **int** | The maximum number of bank transfers to return. | [optional] [default to 25]
**Offset** | **int** | The number of bank transfers to skip before returning results. | [optional] [default to 0]
**OriginationAccountId** | **string** | Filter bank transfers to only those originated through the specified origination account. | [optional] 
**Direction** | **BankTransferDirection** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

