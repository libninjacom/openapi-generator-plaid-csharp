# Org.OpenAPITools.Model.SandboxPublicTokenCreateRequest
SandboxPublicTokenCreateRequest defines the request schema for `/sandbox/public_token/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**InstitutionId** | **string** | The ID of the institution the Item will be associated with | 
**InitialProducts** | [**List&lt;Products&gt;**](Products.md) | The products to initially pull for the Item. May be any products that the specified &#x60;institution_id&#x60;  supports. This array may not be empty. | 
**Options** | [**SandboxPublicTokenCreateRequestOptions**](SandboxPublicTokenCreateRequestOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

