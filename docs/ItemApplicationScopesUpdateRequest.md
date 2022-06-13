# Org.OpenAPITools.Model.ItemApplicationScopesUpdateRequest
ItemApplicationScopesUpdateRequest defines the request schema for `/item/application/scopes/update`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccessToken** | **string** | The access token associated with the Item data is being requested for. | 
**ApplicationId** | **string** | This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect. | 
**Scopes** | [**Scopes**](Scopes.md) |  | 
**State** | **string** | When scopes are updated during enrollment, this field must be populated with the state sent to the partner in the OAuth Login URI. This field is required when the context is &#x60;ENROLLMENT&#x60;. | [optional] 
**Context** | **ScopesContext** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

