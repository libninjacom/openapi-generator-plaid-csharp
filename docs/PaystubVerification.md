# Org.OpenAPITools.Model.PaystubVerification
An object containing details on the paystub's verification status. This object will only be populated if the [`income_verification.access_tokens`](/docs/api/tokens/#link-token-create-request-income-verification-access-tokens) parameter was provided during the `/link/token/create` call or if a problem was detected with the information supplied by the user; otherwise it will be `null`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VerificationStatus** | **PaystubVerificationStatus** |  | 
**VerificationAttributes** | [**List&lt;VerificationAttribute&gt;**](VerificationAttribute.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

