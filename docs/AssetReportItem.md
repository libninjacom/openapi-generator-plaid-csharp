# Org.OpenAPITools.Model.AssetReportItem
A representation of an Item within an Asset Report.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error | 
**InstitutionName** | **string** | The full financial institution name associated with the Item. | 
**InstitutionId** | **string** | The id of the financial institution associated with the Item. | 
**DateLastUpdated** | **DateTime** | The date and time when this Item’s data was last retrieved from the financial institution, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. | 
**Accounts** | [**List&lt;AccountAssets&gt;**](AccountAssets.md) | Data about each of the accounts open on the Item. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

