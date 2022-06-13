# Org.OpenAPITools.Model.SandboxPublicTokenCreateRequestOptions
An optional set of options to be used when configuring the Item. If specified, must not be `null`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Webhook** | **string** | Specify a webhook to associate with the new Item. | [optional] 
**OverrideUsername** | **string** | Test username to use for the creation of the Sandbox Item. Default value is &#x60;user_good&#x60;. | [optional] [default to "user_good"]
**OverridePassword** | **string** | Test password to use for the creation of the Sandbox Item. Default value is &#x60;pass_good&#x60;. | [optional] [default to "pass_good"]
**Transactions** | [**SandboxPublicTokenCreateRequestOptionsTransactions**](SandboxPublicTokenCreateRequestOptionsTransactions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

