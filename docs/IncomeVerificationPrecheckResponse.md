# Org.OpenAPITools.Model.IncomeVerificationPrecheckResponse
IncomeVerificationPrecheckResponse defines the response schema for `/income/verification/precheck`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrecheckId** | **string** | ID of the precheck. Provide this value when calling &#x60;/link/token/create&#x60; in order to optimize Link conversion. | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 
**Confidence** | **IncomeVerificationPrecheckConfidence** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

