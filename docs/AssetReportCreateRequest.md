# Org.OpenAPITools.Model.AssetReportCreateRequest
AssetReportCreateRequest defines the request schema for `/asset_report/create`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**AccessTokens** | **List&lt;string&gt;** | An array of access tokens corresponding to the Items that will be included in the report. The &#x60;assets&#x60; product must have been initialized for the Items during link; the Assets product cannot be added after initialization. | 
**DaysRequested** | **int** | The maximum integer number of days of history to include in the Asset Report. If using Fannie Mae Day 1 Certainty, &#x60;days_requested&#x60; must be at least 61 for new originations or at least 31 for refinancings. | 
**Options** | [**AssetReportCreateRequestOptions**](AssetReportCreateRequestOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

