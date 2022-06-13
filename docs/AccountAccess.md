# Org.OpenAPITools.Model.AccountAccess
Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered `new_accounts`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UniqueId** | **string** | The unique account identifier for this account. This value must match that returned by the data access API for this account. | 
**Authorized** | **bool?** | Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to &#x60;true&#x60;. | [optional] [default to true]
**AccountProductAccess** | [**AccountProductAccessNullable**](AccountProductAccessNullable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

