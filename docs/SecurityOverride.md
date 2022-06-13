# Org.OpenAPITools.Model.SecurityOverride
Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (`ticker_symbol`, `cusip`, `isin`, or `sedol`) are required.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Isin** | **string** | 12-character ISIN, a globally unique securities identifier. | [optional] 
**Cusip** | **string** | 9-character CUSIP, an identifier assigned to North American securities. | [optional] 
**Sedol** | **string** | 7-character SEDOL, an identifier assigned to securities in the UK. | [optional] 
**Name** | **string** | A descriptive name for the security, suitable for display. | [optional] 
**TickerSymbol** | **string** | The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available. | [optional] 
**Currency** | **string** | Either a valid &#x60;iso_currency_code&#x60; or &#x60;unofficial_currency_code&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

