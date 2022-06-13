# Org.OpenAPITools.Model.LinkTokenCreateRequestIncomeVerification
Specifies options for initializing Link for use with the Income (beta) product. This field is required if `income_verification` is included in the `products` array.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncomeVerificationId** | **string** | The &#x60;income_verification_id&#x60; of the verification instance, as provided by &#x60;/income/verification/create&#x60;. | [optional] 
**AssetReportId** | **string** | The &#x60;asset_report_id&#x60; of an asset report associated with the user, as provided by &#x60;/asset_report/create&#x60;. Providing an &#x60;asset_report_id&#x60; is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped. | [optional] 
**PrecheckId** | **string** | The ID of a precheck created with &#x60;/income/verification/precheck&#x60;. Will be used to improve conversion of the income verification flow by streamlining the Link interface presented to the end user. | [optional] 
**AccessTokens** | **List&lt;string&gt;** | An array of access tokens corresponding to the Items that will be cross-referenced with the product data. If the &#x60;transactions&#x60; product was not initialized for the Items during link, it will be initialized after this Link session. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

