# Org.OpenAPITools.Model.AssetReport
An object representing an Asset Report

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssetReportId** | **string** | A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive. | 
**ClientReportId** | **string** | An identifier you determine and submit for the Asset Report. | 
**DateGenerated** | **DateTime** | The date and time when the Asset Report was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (e.g. \&quot;2018-04-12T03:32:11Z\&quot;). | 
**DaysRequested** | **decimal** | The duration of transaction history you requested | 
**User** | [**AssetReportUser**](AssetReportUser.md) |  | 
**Items** | [**List&lt;AssetReportItem&gt;**](AssetReportItem.md) | Data returned by Plaid about each of the Items included in the Asset Report. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

