# Org.OpenAPITools.Model.IncomeVerificationPaystubsGetResponse
IncomeVerificationPaystubsGetResponse defines the response schema for `/income/verification/paystubs/get`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentMetadata** | [**List&lt;DocumentMetadata&gt;**](DocumentMetadata.md) | Metadata for an income document. | [optional] 
**Paystubs** | [**List&lt;Paystub&gt;**](Paystub.md) |  | 
**Error** | [**PlaidError**](PlaidError.md) |  | [optional] 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

