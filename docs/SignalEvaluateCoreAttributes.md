# Org.OpenAPITools.Model.SignalEvaluateCoreAttributes
The core attributes object contains additional data that can be used to assess the ACH return risk. Examples of data include:  `days_since_first_plaid_connection`: The number of days since the first time the Item was connected to an application via Plaid `plaid_connections_count_7d`: The number of times the Item has been connected to applications via Plaid over the past 7 days `plaid_connections_count_30d`: The number of times the Item has been connected to applications via Plaid over the past 30 days `total_plaid_connections_count`: The number of times the Item has been connected to applications via Plaid `is_savings_or_money_market_account`: Indicates whether the ACH transaction funding account is a savings/money market account  For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnauthorizedTransactionsCount7d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited. | [optional] 
**UnauthorizedTransactionsCount30d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited. | [optional] 
**UnauthorizedTransactionsCount60d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited. | [optional] 
**UnauthorizedTransactionsCount90d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited. | [optional] 
**NsfOverdraftTransactionsCount7d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited. | [optional] 
**NsfOverdraftTransactionsCount30d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited. | [optional] 
**NsfOverdraftTransactionsCount60d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited. | [optional] 
**NsfOverdraftTransactionsCount90d** | **int** | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited. | [optional] 
**DaysSinceFirstPlaidConnection** | **int?** | The number of days since the first time the Item was connected to an application via Plaid | [optional] 
**PlaidConnectionsCount7d** | **int?** | The number of times the Item has been connected to applications via Plaid over the past 7 days | [optional] 
**PlaidConnectionsCount30d** | **int?** | The number of times the Item has been connected to applications via Plaid over the past 30 days | [optional] 
**TotalPlaidConnectionsCount** | **int?** | The total number of times the Item has been connected to applications via Plaid | [optional] 
**IsSavingsOrMoneyMarketAccount** | **bool** | Indicates if the ACH transaction funding account is a savings/money market account | [optional] 
**TotalCreditTransactionsAmount10d** | **decimal** | The total credit (inflow) transaction amount over the past 10 days from the account that will be debited | [optional] 
**TotalDebitTransactionsAmount10d** | **decimal** | The total debit (outflow) transaction amount over the past 10 days from the account that will be debited | [optional] 
**P50CreditTransactionsAmount28d** | **decimal?** | The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited | [optional] 
**P50DebitTransactionsAmount28d** | **decimal?** | The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited | [optional] 
**P95CreditTransactionsAmount28d** | **decimal?** | The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited | [optional] 
**P95DebitTransactionsAmount28d** | **decimal?** | The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited | [optional] 
**DaysWithNegativeBalanceCount90d** | **int?** | The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance | [optional] 
**P90EodBalance30d** | **decimal?** | The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited | [optional] 
**P90EodBalance60d** | **decimal?** | The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited | [optional] 
**P90EodBalance90d** | **decimal?** | The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited | [optional] 
**P10EodBalance30d** | **decimal?** | The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited | [optional] 
**P10EodBalance60d** | **decimal?** | The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited | [optional] 
**P10EodBalance90d** | **decimal?** | The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited | [optional] 
**AvailableBalance** | **decimal?** | Available balance, as of the &#x60;balance_last_updated&#x60; time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account. | [optional] 
**CurrentBalance** | **decimal?** | Current balance, as of the &#x60;balance_last_updated&#x60; time. The current balance is the total amount of funds in the account. | [optional] 
**BalanceLastUpdated** | **DateTime?** | Timestamp in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated. | [optional] 
**PhoneChangeCount28d** | **int?** | The number of times the account&#39;s phone numbers on file have changed over the past 28 days | [optional] 
**PhoneChangeCount90d** | **int?** | The number of times the account&#39;s phone numbers on file have changed over the past 90 days | [optional] 
**EmailChangeCount28d** | **int?** | The number of times the account&#39;s email addresses on file have changed over the past 28 days | [optional] 
**EmailChangeCount90d** | **int?** | The number of times the account&#39;s email addresses on file have changed over the past 90 days | [optional] 
**AddressChangeCount28d** | **int?** | The number of times the account&#39;s addresses on file have changed over the past 28 days | [optional] 
**AddressChangeCount90d** | **int?** | The number of times the account&#39;s addresses on file have changed over the past 90 days | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

