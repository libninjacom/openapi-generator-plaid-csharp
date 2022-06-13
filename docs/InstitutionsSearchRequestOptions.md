# Org.OpenAPITools.Model.InstitutionsSearchRequestOptions
An optional object to filter `/institutions/search` results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Oauth** | **bool?** | Limit results to institutions with or without OAuth login flows. | [optional] 
**IncludeOptionalMetadata** | **bool** | When true, return the institution&#39;s homepage URL, logo and primary brand color. | [optional] 
**IncludeAuthMetadata** | **bool?** | When &#x60;true&#x60;, returns metadata related to the Auth product indicating which auth methods are supported. | [optional] [default to false]
**IncludePaymentInitiationMetadata** | **bool?** | When &#x60;true&#x60;, returns metadata related to the Payment Initiation product indicating which payment configurations are supported. | [optional] [default to false]
**PaymentInitiation** | [**InstitutionsSearchPaymentInitiationOptions**](InstitutionsSearchPaymentInitiationOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

