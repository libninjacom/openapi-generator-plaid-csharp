# Org.OpenAPITools.Model.IncomeVerificationTaxformsGetResponse
IncomeVerificationTaxformsGetResponse defines the response schema for `/income/verification/taxforms/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | [optional] 
**DocumentMetadata** | [**List&lt;DocumentMetadata&gt;**](DocumentMetadata.md) |  | 
**Taxforms** | [**List&lt;Taxform&gt;**](Taxform.md) | A list of forms. | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

