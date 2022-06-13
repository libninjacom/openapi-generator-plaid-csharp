# Org.OpenAPITools.Model.ProductStatus
A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | This field is deprecated in favor of the &#x60;breakdown&#x60; object, which provides more granular institution health data.  &#x60;HEALTHY&#x60;: the majority of requests are successful &#x60;DEGRADED&#x60;: only some requests are successful &#x60;DOWN&#x60;: all requests are failing | 
**LastStatusChange** | **DateTime** | [ISO 8601](https://wikipedia.org/wiki/ISO_8601) formatted timestamp of the last status change for the institution.  | 
**Breakdown** | [**ProductStatusBreakdown**](ProductStatusBreakdown.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

