# Org.OpenAPITools.Model.Warning
It is possible for an Asset Report to be returned with missing account owner information. In such cases, the Asset Report will contain warning data in the response, indicating why obtaining the owner information failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WarningType** | **string** | The warning type, which will always be &#x60;ASSET_REPORT_WARNING&#x60; | 
**WarningCode** | **string** | The warning code identifies a specific kind of warning. Currently, the only possible warning code is &#x60;OWNERS_UNAVAILABLE&#x60;, which indicates that account-owner information is not available. | 
**Cause** | [**Cause**](Cause.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

