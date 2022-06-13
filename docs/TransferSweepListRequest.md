# Org.OpenAPITools.Model.TransferSweepListRequest
Defines the request schema for `/transfer/sweep/list`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**StartDate** | **DateTime?** | The start datetime of sweeps to return (RFC 3339 format). | [optional] 
**EndDate** | **DateTime?** | The end datetime of sweeps to return (RFC 3339 format). | [optional] 
**Count** | **int?** | The maximum number of sweeps to return. | [optional] [default to 25]
**Offset** | **int** | The number of sweeps to skip before returning results. | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

