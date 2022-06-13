# Org.OpenAPITools.Model.ConnectedApplication
Describes the connected application for a particular end user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **string** | This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect. | 
**Name** | **string** | The name of the application | 
**Logo** | **string** | A URL that links to the application logo image (will be deprecated in the future, please use logo_url). | 
**LogoUrl** | **string** | A URL that links to the application logo image. | 
**ApplicationUrl** | **string** | The URL for the application&#39;s website | 
**ReasonForAccess** | **string** | A string provided by the connected app stating why they use their respective enabled products. | 
**CreatedAt** | **DateTime** | The date this application was linked in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format in UTC. | 
**JoinDate** | **DateTime** | The date this application was granted production access at Plaid in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format in UTC. | 
**ProductDataTypes** | **List&lt;string&gt;** | (Deprecated) A list of enums representing the data collected and products enabled for this connected application. | 
**Scopes** | [**ScopesNullable**](ScopesNullable.md) |  | [optional] 
**RequestedScopes** | [**RequestedScopes**](RequestedScopes.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

