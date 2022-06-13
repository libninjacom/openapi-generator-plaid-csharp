# Org.OpenAPITools.Model.HoldingsOverride
Specify the holdings on the account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstitutionPrice** | **decimal** | The last price given by the institution for this security | 
**InstitutionPriceAsOf** | **DateTime** | The date at which &#x60;institution_price&#x60; was current. Must be formatted as an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date. | [optional] 
**CostBasis** | **decimal** | The average original value of the holding. Multiple cost basis values for the same security purchased at different prices are not supported. | [optional] 
**Quantity** | **decimal** | The total quantity of the asset held, as reported by the financial institution. | 
**Currency** | **string** | Either a valid &#x60;iso_currency_code&#x60; or &#x60;unofficial_currency_code&#x60; | 
**Security** | [**SecurityOverride**](SecurityOverride.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

