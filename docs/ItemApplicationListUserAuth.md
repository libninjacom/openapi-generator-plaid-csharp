# Org.OpenAPITools.Model.ItemApplicationListUserAuth
User authentication parameters, for clients making a request without an `access_token`. This is only allowed for select clients and will not be supported in the future. Most clients should call /item/import to obtain an access token before making a request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | Account username. | [optional] 
**FiUsernameHash** | **string** | Account username hashed by FI. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

