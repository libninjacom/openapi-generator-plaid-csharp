# Org.OpenAPITools.Model.OverrideAccounts
Data to use to set values of test accounts. Some values cannot be specified in the schema and will instead will be calculated from other test data in order to achieve more consistent, realistic test data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **OverrideAccountType** |  | 
**Subtype** | **AccountSubtype** |  | 
**StartingBalance** | **decimal** | If provided, the account will start with this amount as the current balance.  | 
**ForceAvailableBalance** | **decimal** | If provided, the account will always have this amount as its  available balance, regardless of current balance or changes in transactions over time. | 
**Currency** | **string** | ISO-4217 currency code. If provided, the account will be denominated in the given currency. Transactions will also be in this currency by default. | 
**Meta** | [**Meta**](Meta.md) |  | 
**Numbers** | [**Numbers**](Numbers.md) |  | 
**Transactions** | [**List&lt;TransactionOverride&gt;**](TransactionOverride.md) | Specify the list of transactions on the account. | 
**Holdings** | [**HoldingsOverride**](HoldingsOverride.md) |  | [optional] 
**InvestmentTransactions** | [**InvestmentsTransactionsOverride**](InvestmentsTransactionsOverride.md) |  | [optional] 
**Identity** | [**OwnerOverride**](OwnerOverride.md) |  | 
**Liability** | [**LiabilityOverride**](LiabilityOverride.md) |  | 
**InflowModel** | [**InflowModel**](InflowModel.md) |  | 
**Income** | [**IncomeOverride**](IncomeOverride.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

