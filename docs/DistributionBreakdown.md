# Org.OpenAPITools.Model.DistributionBreakdown
Information about the accounts that the payment was distributed to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **string** | Name of the account for the given distribution. | [optional] 
**BankName** | **string** | The name of the bank that the payment is being deposited to. | [optional] 
**CurrentAmount** | **decimal?** | The amount distributed to this account. | [optional] 
**IsoCurrencyCode** | **string** | The ISO-4217 currency code of the net pay. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null. | [optional] 
**Mask** | **string** | The last 2-4 alphanumeric characters of an account&#39;s official account number. | [optional] 
**Type** | **string** | Type of the account that the paystub was sent to (e.g. &#39;checking&#39;). | [optional] 
**UnofficialCurrencyCode** | **string** | The unofficial currency code associated with the net pay. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s. | [optional] 
**CurrentPay** | [**Pay**](Pay.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

