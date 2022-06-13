# Org.OpenAPITools.Model.Institution
Details relating to a specific financial institution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstitutionId** | **string** | Unique identifier for the institution | 
**Name** | **string** | The official name of the institution | 
**Products** | [**List&lt;Products&gt;**](Products.md) | A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return &#x60;auth&#x60; in the product array; institutions that do not list &#x60;auth&#x60; may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. To identify institutions that support those methods, use the &#x60;auth_metadata&#x60; object. For more details, see [Full Auth coverage](https://plaid.com/docs/auth/coverage/). | 
**CountryCodes** | [**List&lt;CountryCode&gt;**](CountryCode.md) | A list of the country codes supported by the institution. | 
**Url** | **string** | The URL for the institution&#39;s website | [optional] 
**PrimaryColor** | **string** | Hexadecimal representation of the primary color used by the institution | [optional] 
**Logo** | **string** | Base64 encoded representation of the institution&#39;s logo | [optional] 
**RoutingNumbers** | **List&lt;string&gt;** | A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution. | 
**Oauth** | **bool** | Indicates that the institution has an OAuth login flow. | 
**Status** | [**InstitutionStatus**](InstitutionStatus.md) |  | [optional] 
**PaymentInitiationMetadata** | [**PaymentInitiationMetadata**](PaymentInitiationMetadata.md) |  | [optional] 
**AuthMetadata** | [**AuthMetadata**](AuthMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

