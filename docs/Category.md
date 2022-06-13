# Org.OpenAPITools.Model.Category
Information describing a transaction category

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryId** | **string** | An identifying number for the category. &#x60;category_id&#x60; is a Plaid-specific identifier and does not necessarily correspond to merchant category codes. | 
**Group** | **string** | &#x60;place&#x60; for physical transactions or &#x60;special&#x60; for other transactions such as bank charges. | 
**Hierarchy** | **List&lt;string&gt;** | A hierarchical array of the categories to which this &#x60;category_id&#x60; belongs. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

