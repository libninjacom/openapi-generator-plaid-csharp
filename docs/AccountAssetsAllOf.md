# Org.OpenAPITools.Model.AccountAssetsAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DaysAvailable** | **decimal** | The duration of transaction history available for this Item, typically defined as the time since the date of the earliest transaction in that account. Only returned by Assets endpoints. | 
**Transactions** | [**List&lt;AssetReportTransaction&gt;**](AssetReportTransaction.md) | Transaction history associated with the account. Only returned by Assets endpoints. Transaction history returned by endpoints such as &#x60;/transactions/get&#x60; or &#x60;/investments/transactions/get&#x60; will be returned in the top-level &#x60;transactions&#x60; field instead. | 
**Owners** | [**List&lt;Owner&gt;**](Owner.md) | Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same &#x60;owner&#x60; object, not in multiple owner objects within the array. In API versions 2018-05-22 and earlier, the &#x60;owners&#x60; object is not returned, and instead identity information is returned in the top level &#x60;identity&#x60; object. For more details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2019-05-29) | 
**HistoricalBalances** | [**List&lt;HistoricalBalance&gt;**](HistoricalBalance.md) | Calculated data about the historical balances on the account. Only returned by Assets endpoints and currently not supported by &#x60;brokerage&#x60; or &#x60;investment&#x60; accounts. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

