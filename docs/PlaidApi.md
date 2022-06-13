# Org.OpenAPITools.Api.PlaidApi

All URIs are relative to *https://production.plaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsBalanceGet**](PlaidApi.md#accountsbalanceget) | **POST** /accounts/balance/get | Retrieve real-time balance data
[**AccountsGet**](PlaidApi.md#accountsget) | **POST** /accounts/get | Retrieve accounts
[**ApplicationGet**](PlaidApi.md#applicationget) | **POST** /application/get | Retrieve information about a Plaid application
[**AssetReportAuditCopyCreate**](PlaidApi.md#assetreportauditcopycreate) | **POST** /asset_report/audit_copy/create | Create Asset Report Audit Copy
[**AssetReportAuditCopyGet**](PlaidApi.md#assetreportauditcopyget) | **POST** /asset_report/audit_copy/get | Retrieve an Asset Report Audit Copy
[**AssetReportAuditCopyRemove**](PlaidApi.md#assetreportauditcopyremove) | **POST** /asset_report/audit_copy/remove | Remove Asset Report Audit Copy
[**AssetReportCreate**](PlaidApi.md#assetreportcreate) | **POST** /asset_report/create | Create an Asset Report
[**AssetReportFilter**](PlaidApi.md#assetreportfilter) | **POST** /asset_report/filter | Filter Asset Report
[**AssetReportGet**](PlaidApi.md#assetreportget) | **POST** /asset_report/get | Retrieve an Asset Report
[**AssetReportPdfGet**](PlaidApi.md#assetreportpdfget) | **POST** /asset_report/pdf/get | Retrieve a PDF Asset Report
[**AssetReportRefresh**](PlaidApi.md#assetreportrefresh) | **POST** /asset_report/refresh | Refresh an Asset Report
[**AssetReportRemove**](PlaidApi.md#assetreportremove) | **POST** /asset_report/remove | Delete an Asset Report
[**AuthGet**](PlaidApi.md#authget) | **POST** /auth/get | Retrieve auth data
[**BankTransferBalanceGet**](PlaidApi.md#banktransferbalanceget) | **POST** /bank_transfer/balance/get | Get balance of your Bank Transfer account
[**BankTransferCancel**](PlaidApi.md#banktransfercancel) | **POST** /bank_transfer/cancel | Cancel a bank transfer
[**BankTransferCreate**](PlaidApi.md#banktransfercreate) | **POST** /bank_transfer/create | Create a bank transfer
[**BankTransferEventList**](PlaidApi.md#banktransfereventlist) | **POST** /bank_transfer/event/list | List bank transfer events
[**BankTransferEventSync**](PlaidApi.md#banktransfereventsync) | **POST** /bank_transfer/event/sync | Sync bank transfer events
[**BankTransferGet**](PlaidApi.md#banktransferget) | **POST** /bank_transfer/get | Retrieve a bank transfer
[**BankTransferList**](PlaidApi.md#banktransferlist) | **POST** /bank_transfer/list | List bank transfers
[**BankTransferMigrateAccount**](PlaidApi.md#banktransfermigrateaccount) | **POST** /bank_transfer/migrate_account | Migrate account into Bank Transfers
[**BankTransferSweepGet**](PlaidApi.md#banktransfersweepget) | **POST** /bank_transfer/sweep/get | Retrieve a sweep
[**BankTransferSweepList**](PlaidApi.md#banktransfersweeplist) | **POST** /bank_transfer/sweep/list | List sweeps
[**CategoriesGet**](PlaidApi.md#categoriesget) | **POST** /categories/get | Get Categories
[**CreatePaymentToken**](PlaidApi.md#createpaymenttoken) | **POST** /payment_initiation/payment/token/create | Create payment token
[**DepositSwitchAltCreate**](PlaidApi.md#depositswitchaltcreate) | **POST** /deposit_switch/alt/create | Create a deposit switch without using Plaid Exchange
[**DepositSwitchCreate**](PlaidApi.md#depositswitchcreate) | **POST** /deposit_switch/create | Create a deposit switch
[**DepositSwitchGet**](PlaidApi.md#depositswitchget) | **POST** /deposit_switch/get | Retrieve a deposit switch
[**DepositSwitchTokenCreate**](PlaidApi.md#depositswitchtokencreate) | **POST** /deposit_switch/token/create | Create a deposit switch token
[**EmployersSearch**](PlaidApi.md#employerssearch) | **POST** /employers/search | Search employer database
[**EmploymentVerificationGet**](PlaidApi.md#employmentverificationget) | **POST** /employment/verification/get | Retrieve a summary of an individual&#39;s employment information
[**IdentityGet**](PlaidApi.md#identityget) | **POST** /identity/get | Retrieve identity data
[**IncomeVerificationCreate**](PlaidApi.md#incomeverificationcreate) | **POST** /income/verification/create | (Deprecated) Create an income verification instance
[**IncomeVerificationDocumentsDownload**](PlaidApi.md#incomeverificationdocumentsdownload) | **POST** /income/verification/documents/download | Download the original documents used for income verification
[**IncomeVerificationPaystubGet**](PlaidApi.md#incomeverificationpaystubget) | **POST** /income/verification/paystub/get | (Deprecated) Retrieve information from a single paystub used for income verification
[**IncomeVerificationPaystubsGet**](PlaidApi.md#incomeverificationpaystubsget) | **POST** /income/verification/paystubs/get | Retrieve information from the paystubs used for income verification
[**IncomeVerificationPrecheck**](PlaidApi.md#incomeverificationprecheck) | **POST** /income/verification/precheck | Check digital income verification eligibility and optimize conversion
[**IncomeVerificationRefresh**](PlaidApi.md#incomeverificationrefresh) | **POST** /income/verification/refresh | Refresh an income verification
[**IncomeVerificationSummaryGet**](PlaidApi.md#incomeverificationsummaryget) | **POST** /income/verification/summary/get | (Deprecated) Retrieve a summary of information derived from income verification
[**IncomeVerificationTaxformsGet**](PlaidApi.md#incomeverificationtaxformsget) | **POST** /income/verification/taxforms/get | Retrieve information from the tax documents used for income verification
[**InstitutionsGet**](PlaidApi.md#institutionsget) | **POST** /institutions/get | Get details of all supported institutions
[**InstitutionsGetById**](PlaidApi.md#institutionsgetbyid) | **POST** /institutions/get_by_id | Get details of an institution
[**InstitutionsSearch**](PlaidApi.md#institutionssearch) | **POST** /institutions/search | Search institutions
[**InvestmentsHoldingsGet**](PlaidApi.md#investmentsholdingsget) | **POST** /investments/holdings/get | Get Investment holdings
[**InvestmentsTransactionsGet**](PlaidApi.md#investmentstransactionsget) | **POST** /investments/transactions/get | Get investment transactions
[**ItemAccessTokenInvalidate**](PlaidApi.md#itemaccesstokeninvalidate) | **POST** /item/access_token/invalidate | Invalidate access_token
[**ItemApplicationList**](PlaidApi.md#itemapplicationlist) | **POST** /item/application/list | List a user’s connected applications
[**ItemApplicationScopesUpdate**](PlaidApi.md#itemapplicationscopesupdate) | **POST** /item/application/scopes/update | Update the scopes of access for a particular application
[**ItemCreatePublicToken**](PlaidApi.md#itemcreatepublictoken) | **POST** /item/public_token/create | Create public token
[**ItemGet**](PlaidApi.md#itemget) | **POST** /item/get | Retrieve an Item
[**ItemImport**](PlaidApi.md#itemimport) | **POST** /item/import | Import Item
[**ItemPublicTokenExchange**](PlaidApi.md#itempublictokenexchange) | **POST** /item/public_token/exchange | Exchange public token for an access token
[**ItemRemove**](PlaidApi.md#itemremove) | **POST** /item/remove | Remove an Item
[**ItemWebhookUpdate**](PlaidApi.md#itemwebhookupdate) | **POST** /item/webhook/update | Update Webhook URL
[**LiabilitiesGet**](PlaidApi.md#liabilitiesget) | **POST** /liabilities/get | Retrieve Liabilities data
[**LinkTokenCreate**](PlaidApi.md#linktokencreate) | **POST** /link/token/create | Create Link Token
[**LinkTokenGet**](PlaidApi.md#linktokenget) | **POST** /link/token/get | Get Link Token
[**PaymentInitiationPaymentCreate**](PlaidApi.md#paymentinitiationpaymentcreate) | **POST** /payment_initiation/payment/create | Create a payment
[**PaymentInitiationPaymentGet**](PlaidApi.md#paymentinitiationpaymentget) | **POST** /payment_initiation/payment/get | Get payment details
[**PaymentInitiationPaymentList**](PlaidApi.md#paymentinitiationpaymentlist) | **POST** /payment_initiation/payment/list | List payments
[**PaymentInitiationPaymentReverse**](PlaidApi.md#paymentinitiationpaymentreverse) | **POST** /payment_initiation/payment/reverse | Reverse an existing payment
[**PaymentInitiationRecipientCreate**](PlaidApi.md#paymentinitiationrecipientcreate) | **POST** /payment_initiation/recipient/create | Create payment recipient
[**PaymentInitiationRecipientGet**](PlaidApi.md#paymentinitiationrecipientget) | **POST** /payment_initiation/recipient/get | Get payment recipient
[**PaymentInitiationRecipientList**](PlaidApi.md#paymentinitiationrecipientlist) | **POST** /payment_initiation/recipient/list | List payment recipients
[**ProcessorApexProcessorTokenCreate**](PlaidApi.md#processorapexprocessortokencreate) | **POST** /processor/apex/processor_token/create | Create Apex bank account token
[**ProcessorAuthGet**](PlaidApi.md#processorauthget) | **POST** /processor/auth/get | Retrieve Auth data
[**ProcessorBalanceGet**](PlaidApi.md#processorbalanceget) | **POST** /processor/balance/get | Retrieve Balance data
[**ProcessorBankTransferCreate**](PlaidApi.md#processorbanktransfercreate) | **POST** /processor/bank_transfer/create | Create a bank transfer as a processor
[**ProcessorIdentityGet**](PlaidApi.md#processoridentityget) | **POST** /processor/identity/get | Retrieve Identity data
[**ProcessorStripeBankAccountTokenCreate**](PlaidApi.md#processorstripebankaccounttokencreate) | **POST** /processor/stripe/bank_account_token/create | Create Stripe bank account token
[**ProcessorTokenCreate**](PlaidApi.md#processortokencreate) | **POST** /processor/token/create | Create processor token
[**SandboxBankTransferFireWebhook**](PlaidApi.md#sandboxbanktransferfirewebhook) | **POST** /sandbox/bank_transfer/fire_webhook | Manually fire a Bank Transfer webhook
[**SandboxBankTransferSimulate**](PlaidApi.md#sandboxbanktransfersimulate) | **POST** /sandbox/bank_transfer/simulate | Simulate a bank transfer event in Sandbox
[**SandboxIncomeFireWebhook**](PlaidApi.md#sandboxincomefirewebhook) | **POST** /sandbox/income/fire_webhook | Manually fire an Income webhook
[**SandboxItemFireWebhook**](PlaidApi.md#sandboxitemfirewebhook) | **POST** /sandbox/item/fire_webhook | Fire a test webhook
[**SandboxItemResetLogin**](PlaidApi.md#sandboxitemresetlogin) | **POST** /sandbox/item/reset_login | Force a Sandbox Item into an error state
[**SandboxItemSetVerificationStatus**](PlaidApi.md#sandboxitemsetverificationstatus) | **POST** /sandbox/item/set_verification_status | Set verification status for Sandbox account
[**SandboxOauthSelectAccounts**](PlaidApi.md#sandboxoauthselectaccounts) | **POST** /sandbox/oauth/select_accounts | Save the selected accounts when connecting to the Platypus Oauth institution
[**SandboxProcessorTokenCreate**](PlaidApi.md#sandboxprocessortokencreate) | **POST** /sandbox/processor_token/create | Create a test Item and processor token
[**SandboxPublicTokenCreate**](PlaidApi.md#sandboxpublictokencreate) | **POST** /sandbox/public_token/create | Create a test Item
[**SandboxTransferRepaymentSimulate**](PlaidApi.md#sandboxtransferrepaymentsimulate) | **POST** /sandbox/transfer/repayment/simulate | Trigger the creation of a repayment
[**SandboxTransferSimulate**](PlaidApi.md#sandboxtransfersimulate) | **POST** /sandbox/transfer/simulate | Simulate a transfer event in Sandbox
[**SandboxTransferSweepSimulate**](PlaidApi.md#sandboxtransfersweepsimulate) | **POST** /sandbox/transfer/sweep/simulate | Simulate creating a sweep
[**SignalDecisionReport**](PlaidApi.md#signaldecisionreport) | **POST** /signal/decision/report | Report whether you initiated an ACH transaction
[**SignalEvaluate**](PlaidApi.md#signalevaluate) | **POST** /signal/evaluate | Evaluate a planned ACH transaction
[**SignalReturnReport**](PlaidApi.md#signalreturnreport) | **POST** /signal/return/report | Report a return for an ACH transaction
[**TransactionsGet**](PlaidApi.md#transactionsget) | **POST** /transactions/get | Get transaction data
[**TransactionsRecurringGet**](PlaidApi.md#transactionsrecurringget) | **POST** /transactions/recurring/get | Get streams of recurring transactions
[**TransactionsRefresh**](PlaidApi.md#transactionsrefresh) | **POST** /transactions/refresh | Refresh transaction data
[**TransactionsSync**](PlaidApi.md#transactionssync) | **POST** /transactions/sync | Get incremental transaction updates on an Item
[**TransferAuthorizationCreate**](PlaidApi.md#transferauthorizationcreate) | **POST** /transfer/authorization/create | Create a transfer authorization
[**TransferCancel**](PlaidApi.md#transfercancel) | **POST** /transfer/cancel | Cancel a transfer
[**TransferCreate**](PlaidApi.md#transfercreate) | **POST** /transfer/create | Create a transfer
[**TransferEventList**](PlaidApi.md#transfereventlist) | **POST** /transfer/event/list | List transfer events
[**TransferEventSync**](PlaidApi.md#transfereventsync) | **POST** /transfer/event/sync | Sync transfer events
[**TransferGet**](PlaidApi.md#transferget) | **POST** /transfer/get | Retrieve a transfer
[**TransferIntentCreate**](PlaidApi.md#transferintentcreate) | **POST** /transfer/intent/create | Create a transfer intent object to invoke the Transfer UI
[**TransferIntentGet**](PlaidApi.md#transferintentget) | **POST** /transfer/intent/get | Retrieve more information about a transfer intent
[**TransferList**](PlaidApi.md#transferlist) | **POST** /transfer/list | List transfers
[**TransferRepaymentList**](PlaidApi.md#transferrepaymentlist) | **POST** /transfer/repayment/list | Lists historical repayments
[**TransferRepaymentReturnList**](PlaidApi.md#transferrepaymentreturnlist) | **POST** /transfer/repayment/return/list | List the returns included in a repayment
[**TransferSweepGet**](PlaidApi.md#transfersweepget) | **POST** /transfer/sweep/get | Retrieve a sweep
[**TransferSweepList**](PlaidApi.md#transfersweeplist) | **POST** /transfer/sweep/list | List sweeps
[**WalletGet**](PlaidApi.md#walletget) | **POST** /wallet/get | Fetch an e-wallet
[**WalletTransactionExecute**](PlaidApi.md#wallettransactionexecute) | **POST** /wallet/transaction/execute | Execute a transaction using an e-wallet
[**WalletTransactionsList**](PlaidApi.md#wallettransactionslist) | **POST** /wallet/transactions/list | List e-wallet transactions
[**WebhookVerificationKeyGet**](PlaidApi.md#webhookverificationkeyget) | **POST** /webhook_verification_key/get | Get webhook verification key


<a name="accountsbalanceget"></a>
# **AccountsBalanceGet**
> AccountsGetResponse AccountsBalanceGet (AccountsBalanceGetRequest accountsBalanceGetRequest)

Retrieve real-time balance data

The `/accounts/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/accounts/balance/get` forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, `balance` itself is not a product that can be used to initialize Link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountsBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var accountsBalanceGetRequest = new AccountsBalanceGetRequest(); // AccountsBalanceGetRequest | 

            try
            {
                // Retrieve real-time balance data
                AccountsGetResponse result = apiInstance.AccountsBalanceGet(accountsBalanceGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AccountsBalanceGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountsBalanceGetRequest** | [**AccountsBalanceGetRequest**](AccountsBalanceGetRequest.md)|  | 

### Return type

[**AccountsGetResponse**](AccountsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsget"></a>
# **AccountsGet**
> AccountsGetResponse AccountsGet (AccountsGetRequest accountsGetRequest)

Retrieve accounts

The `/accounts/get` endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts — that is, accounts that are not closed and are capable of carrying a balance.  This endpoint only returns accounts that were permissioned by the user when they initially created the Item. If a user creates a new account after the initial link, you can capture this event through the [`NEW_ACCOUNTS_AVAILABLE`](https://plaid.com/docs/api/webhooks/#item-new_accounts_available) webhook and then use Link's [update mode](https://plaid.com/docs/link/update-mode/) to request that the user share this new account with you.  This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, balances returned may not be up-to-date; for realtime balance information, use `/accounts/balance/get` instead. Note that some information is nullable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var accountsGetRequest = new AccountsGetRequest(); // AccountsGetRequest | 

            try
            {
                // Retrieve accounts
                AccountsGetResponse result = apiInstance.AccountsGet(accountsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AccountsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountsGetRequest** | [**AccountsGetRequest**](AccountsGetRequest.md)|  | 

### Return type

[**AccountsGetResponse**](AccountsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applicationget"></a>
# **ApplicationGet**
> ApplicationGetResponse ApplicationGet (ApplicationGetRequest applicationGetRequest)

Retrieve information about a Plaid application

Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApplicationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var applicationGetRequest = new ApplicationGetRequest(); // ApplicationGetRequest | 

            try
            {
                // Retrieve information about a Plaid application
                ApplicationGetResponse result = apiInstance.ApplicationGet(applicationGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ApplicationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationGetRequest** | [**ApplicationGetRequest**](ApplicationGetRequest.md)|  | 

### Return type

[**ApplicationGetResponse**](ApplicationGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportauditcopycreate"></a>
# **AssetReportAuditCopyCreate**
> AssetReportAuditCopyCreateResponse AssetReportAuditCopyCreate (AssetReportAuditCopyCreateRequest assetReportAuditCopyCreateRequest)

Create Asset Report Audit Copy

Plaid can provide an Audit Copy of any Asset Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy directly to Fannie Mae on your behalf if you participate in the Day 1 Certainty™ program. An Audit Copy contains the same underlying data as the Asset Report.  To grant access to an Audit Copy, use the `/asset_report/audit_copy/create` endpoint to create an `audit_copy_token` and then pass that token to the third party who needs access. Each third party has its own `auditor_id`, for example `fannie_mae`. You’ll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportAuditCopyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportAuditCopyCreateRequest = new AssetReportAuditCopyCreateRequest(); // AssetReportAuditCopyCreateRequest | 

            try
            {
                // Create Asset Report Audit Copy
                AssetReportAuditCopyCreateResponse result = apiInstance.AssetReportAuditCopyCreate(assetReportAuditCopyCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportAuditCopyCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportAuditCopyCreateRequest** | [**AssetReportAuditCopyCreateRequest**](AssetReportAuditCopyCreateRequest.md)|  | 

### Return type

[**AssetReportAuditCopyCreateResponse**](AssetReportAuditCopyCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportauditcopyget"></a>
# **AssetReportAuditCopyGet**
> AssetReportGetResponse AssetReportAuditCopyGet (AssetReportAuditCopyGetRequest assetReportAuditCopyGetRequest)

Retrieve an Asset Report Audit Copy

`/asset_report/audit_copy/get` allows auditors to get a copy of an Asset Report that was previously shared via the `/asset_report/audit_copy/create` endpoint.  The caller of `/asset_report/audit_copy/create` must provide the `audit_copy_token` to the auditor.  This token can then be used to call `/asset_report/audit_copy/create`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportAuditCopyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportAuditCopyGetRequest = new AssetReportAuditCopyGetRequest(); // AssetReportAuditCopyGetRequest | 

            try
            {
                // Retrieve an Asset Report Audit Copy
                AssetReportGetResponse result = apiInstance.AssetReportAuditCopyGet(assetReportAuditCopyGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportAuditCopyGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportAuditCopyGetRequest** | [**AssetReportAuditCopyGetRequest**](AssetReportAuditCopyGetRequest.md)|  | 

### Return type

[**AssetReportGetResponse**](AssetReportGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportauditcopyremove"></a>
# **AssetReportAuditCopyRemove**
> AssetReportAuditCopyRemoveResponse AssetReportAuditCopyRemove (AssetReportAuditCopyRemoveRequest assetReportAuditCopyRemoveRequest)

Remove Asset Report Audit Copy

The `/asset_report/audit_copy/remove` endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the `audit_copy_token` associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Asset Report, the Asset Report itself and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportAuditCopyRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportAuditCopyRemoveRequest = new AssetReportAuditCopyRemoveRequest(); // AssetReportAuditCopyRemoveRequest | 

            try
            {
                // Remove Asset Report Audit Copy
                AssetReportAuditCopyRemoveResponse result = apiInstance.AssetReportAuditCopyRemove(assetReportAuditCopyRemoveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportAuditCopyRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportAuditCopyRemoveRequest** | [**AssetReportAuditCopyRemoveRequest**](AssetReportAuditCopyRemoveRequest.md)|  | 

### Return type

[**AssetReportAuditCopyRemoveResponse**](AssetReportAuditCopyRemoveResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportcreate"></a>
# **AssetReportCreate**
> AssetReportCreateResponse AssetReportCreate (AssetReportCreateRequest assetReportCreateRequest)

Create an Asset Report

The `/asset_report/create` endpoint initiates the process of creating an Asset Report, which can then be retrieved by passing the `asset_report_token` return value to the `/asset_report/get` or `/asset_report/pdf/get` endpoints.  The Asset Report takes some time to be created and is not available immediately after calling `/asset_report/create`. When the Asset Report is ready to be retrieved using `/asset_report/get` or `/asset_report/pdf/get`, Plaid will fire a `PRODUCT_READY` webhook. For full details of the webhook schema, see [Asset Report webhooks](https://plaid.com/docs/api/webhooks/#assets-webhooks).  The `/asset_report/create` endpoint creates an Asset Report at a moment in time. Asset Reports are immutable. To get an updated Asset Report, use the `/asset_report/refresh` endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportCreateRequest = new AssetReportCreateRequest(); // AssetReportCreateRequest | 

            try
            {
                // Create an Asset Report
                AssetReportCreateResponse result = apiInstance.AssetReportCreate(assetReportCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportCreateRequest** | [**AssetReportCreateRequest**](AssetReportCreateRequest.md)|  | 

### Return type

[**AssetReportCreateResponse**](AssetReportCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportfilter"></a>
# **AssetReportFilter**
> AssetReportFilterResponse AssetReportFilter (AssetReportFilterRequest assetReportFilterRequest)

Filter Asset Report

By default, an Asset Report will contain all of the accounts on a given Item. In some cases, you may not want the Asset Report to contain all accounts. For example, you might have the end user choose which accounts are relevant in Link using the Account Select view, which you can enable in the dashboard. Or, you might always exclude certain account types or subtypes, which you can identify by using the `/accounts/get` endpoint. To narrow an Asset Report to only a subset of accounts, use the `/asset_report/filter` endpoint.  To exclude certain Accounts from an Asset Report, first use the `/asset_report/create` endpoint to create the report, then send the `asset_report_token` along with a list of `account_ids` to exclude to the `/asset_report/filter` endpoint, to create a new Asset Report which contains only a subset of the original Asset Report's data.  Because Asset Reports are immutable, calling `/asset_report/filter` does not alter the original Asset Report in any way; rather, `/asset_report/filter` creates a new Asset Report with a new token and id. Asset Reports created via `/asset_report/filter` do not contain new Asset data, and are not billed.  Plaid will fire a [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook once generation of the filtered Asset Report has completed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportFilterRequest = new AssetReportFilterRequest(); // AssetReportFilterRequest | 

            try
            {
                // Filter Asset Report
                AssetReportFilterResponse result = apiInstance.AssetReportFilter(assetReportFilterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportFilter: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportFilterRequest** | [**AssetReportFilterRequest**](AssetReportFilterRequest.md)|  | 

### Return type

[**AssetReportFilterResponse**](AssetReportFilterResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportget"></a>
# **AssetReportGet**
> AssetReportGetResponse AssetReportGet (AssetReportGetRequest assetReportGetRequest)

Retrieve an Asset Report

The `/asset_report/get` endpoint retrieves the Asset Report in JSON format. Before calling `/asset_report/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook to fire, indicating that the Report is ready to be retrieved.  By default, an Asset Report includes transaction descriptions as returned by the bank, as opposed to parsed and categorized by Plaid. You can also receive cleaned and categorized transactions, as well as additional insights like merchant name or location information. We call this an Asset Report with Insights. An Asset Report with Insights provides transaction category, location, and merchant information in addition to the transaction strings provided in a standard Asset Report.  To retrieve an Asset Report with Insights, call the `/asset_report/get` endpoint with `include_insights` set to `true`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportGetRequest = new AssetReportGetRequest(); // AssetReportGetRequest | 

            try
            {
                // Retrieve an Asset Report
                AssetReportGetResponse result = apiInstance.AssetReportGet(assetReportGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportGetRequest** | [**AssetReportGetRequest**](AssetReportGetRequest.md)|  | 

### Return type

[**AssetReportGetResponse**](AssetReportGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportpdfget"></a>
# **AssetReportPdfGet**
> System.IO.Stream AssetReportPdfGet (AssetReportPDFGetRequest assetReportPDFGetRequest)

Retrieve a PDF Asset Report

The `/asset_report/pdf/get` endpoint retrieves the Asset Report in PDF format. Before calling `/asset_report/pdf/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook to fire, indicating that the Report is ready to be retrieved.  The response to `/asset_report/pdf/get` is the PDF binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.  [View a sample PDF Asset Report](https://plaid.com/documents/sample-asset-report.pdf).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportPdfGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportPDFGetRequest = new AssetReportPDFGetRequest(); // AssetReportPDFGetRequest | 

            try
            {
                // Retrieve a PDF Asset Report
                System.IO.Stream result = apiInstance.AssetReportPdfGet(assetReportPDFGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportPdfGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportPDFGetRequest** | [**AssetReportPDFGetRequest**](AssetReportPDFGetRequest.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PDF of the Asset Report |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportrefresh"></a>
# **AssetReportRefresh**
> AssetReportRefreshResponse AssetReportRefresh (AssetReportRefreshRequest assetReportRefreshRequest)

Refresh an Asset Report

An Asset Report is an immutable snapshot of a user's assets. In order to \"refresh\" an Asset Report you created previously, you can use the `/asset_report/refresh` endpoint to create a new Asset Report based on the old one, but with the most recent data available.  The new Asset Report will contain the same Items as the original Report, as well as the same filters applied by any call to `/asset_report/filter`. By default, the new Asset Report will also use the same parameters you submitted with your original `/asset_report/create` request, but the original `days_requested` value and the values of any parameters in the `options` object can be overridden with new values. To change these arguments, simply supply new values for them in your request to `/asset_report/refresh`. Submit an empty string (\"\") for any previously-populated fields you would like set as empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportRefreshRequest = new AssetReportRefreshRequest(); // AssetReportRefreshRequest | 

            try
            {
                // Refresh an Asset Report
                AssetReportRefreshResponse result = apiInstance.AssetReportRefresh(assetReportRefreshRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportRefresh: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportRefreshRequest** | [**AssetReportRefreshRequest**](AssetReportRefreshRequest.md)|  | 

### Return type

[**AssetReportRefreshResponse**](AssetReportRefreshResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetreportremove"></a>
# **AssetReportRemove**
> AssetReportRemoveResponse AssetReportRemove (AssetReportRemoveRequest assetReportRemoveRequest)

Delete an Asset Report

The `/item/remove` endpoint allows you to invalidate an `access_token`, meaning you will not be able to create new Asset Reports with it. Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove them specifically.  The `/asset_report/remove` endpoint allows you to remove an Asset Report. Removing an Asset Report invalidates its `asset_report_token`, meaning you will no longer be able to use it to access Report data or create new Audit Copies. Removing an Asset Report does not affect the underlying Items, but does invalidate any `audit_copy_tokens` associated with the Asset Report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssetReportRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var assetReportRemoveRequest = new AssetReportRemoveRequest(); // AssetReportRemoveRequest | 

            try
            {
                // Delete an Asset Report
                AssetReportRemoveResponse result = apiInstance.AssetReportRemove(assetReportRemoveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AssetReportRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetReportRemoveRequest** | [**AssetReportRemoveRequest**](AssetReportRemoveRequest.md)|  | 

### Return type

[**AssetReportRemoveResponse**](AssetReportRemoveResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authget"></a>
# **AuthGet**
> AuthGetResponse AuthGet (AuthGetRequest authGetRequest)

Retrieve auth data

The `/auth/get` endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking and savings accounts, along with high-level account data and balances when available.  Note: This request may take some time to complete if `auth` was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.  Also note that `/auth/get` will not return data for any new accounts opened after the Item was created. To obtain data for new accounts, create a new Item.  Versioning note: In API version 2017-03-08, the schema of the `numbers` object returned by this endpoint is substantially different. For details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2018-05-22).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var authGetRequest = new AuthGetRequest(); // AuthGetRequest | 

            try
            {
                // Retrieve auth data
                AuthGetResponse result = apiInstance.AuthGet(authGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.AuthGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authGetRequest** | [**AuthGetRequest**](AuthGetRequest.md)|  | 

### Return type

[**AuthGetResponse**](AuthGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Default error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransferbalanceget"></a>
# **BankTransferBalanceGet**
> BankTransferBalanceGetResponse BankTransferBalanceGet (BankTransferBalanceGetRequest bankTransferBalanceGetRequest)

Get balance of your Bank Transfer account

Use the `/bank_transfer/balance/get` endpoint to see the available balance in your bank transfer account. Debit transfers increase this balance once their status is posted. Credit transfers decrease this balance when they are created.  The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.  Note that this endpoint can only be used with FBO accounts, when using Bank Transfers in the Full Service configuration. It cannot be used on your own account when using Bank Transfers in the BTS Platform configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferBalanceGetRequest = new BankTransferBalanceGetRequest(); // BankTransferBalanceGetRequest | 

            try
            {
                // Get balance of your Bank Transfer account
                BankTransferBalanceGetResponse result = apiInstance.BankTransferBalanceGet(bankTransferBalanceGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferBalanceGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferBalanceGetRequest** | [**BankTransferBalanceGetRequest**](BankTransferBalanceGetRequest.md)|  | 

### Return type

[**BankTransferBalanceGetResponse**](BankTransferBalanceGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfercancel"></a>
# **BankTransferCancel**
> BankTransferCancelResponse BankTransferCancel (BankTransferCancelRequest bankTransferCancelRequest)

Cancel a bank transfer

Use the `/bank_transfer/cancel` endpoint to cancel a bank transfer.  A transfer is eligible for cancelation if the `cancellable` property returned by `/bank_transfer/get` is `true`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferCancelRequest = new BankTransferCancelRequest(); // BankTransferCancelRequest | 

            try
            {
                // Cancel a bank transfer
                BankTransferCancelResponse result = apiInstance.BankTransferCancel(bankTransferCancelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferCancelRequest** | [**BankTransferCancelRequest**](BankTransferCancelRequest.md)|  | 

### Return type

[**BankTransferCancelResponse**](BankTransferCancelResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfercreate"></a>
# **BankTransferCreate**
> BankTransferCreateResponse BankTransferCreate (BankTransferCreateRequest bankTransferCreateRequest)

Create a bank transfer

Use the `/bank_transfer/create` endpoint to initiate a new bank transfer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferCreateRequest = new BankTransferCreateRequest(); // BankTransferCreateRequest | 

            try
            {
                // Create a bank transfer
                BankTransferCreateResponse result = apiInstance.BankTransferCreate(bankTransferCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferCreateRequest** | [**BankTransferCreateRequest**](BankTransferCreateRequest.md)|  | 

### Return type

[**BankTransferCreateResponse**](BankTransferCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfereventlist"></a>
# **BankTransferEventList**
> BankTransferEventListResponse BankTransferEventList (BankTransferEventListRequest bankTransferEventListRequest)

List bank transfer events

Use the `/bank_transfer/event/list` endpoint to get a list of bank transfer events based on specified filter criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferEventListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferEventListRequest = new BankTransferEventListRequest(); // BankTransferEventListRequest | 

            try
            {
                // List bank transfer events
                BankTransferEventListResponse result = apiInstance.BankTransferEventList(bankTransferEventListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferEventList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferEventListRequest** | [**BankTransferEventListRequest**](BankTransferEventListRequest.md)|  | 

### Return type

[**BankTransferEventListResponse**](BankTransferEventListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfereventsync"></a>
# **BankTransferEventSync**
> BankTransferEventSyncResponse BankTransferEventSync (BankTransferEventSyncRequest bankTransferEventSyncRequest)

Sync bank transfer events

`/bank_transfer/event/sync` allows you to request up to the next 25 bank transfer events that happened after a specific `event_id`. Use the `/bank_transfer/event/sync` endpoint to guarantee you have seen all bank transfer events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferEventSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferEventSyncRequest = new BankTransferEventSyncRequest(); // BankTransferEventSyncRequest | 

            try
            {
                // Sync bank transfer events
                BankTransferEventSyncResponse result = apiInstance.BankTransferEventSync(bankTransferEventSyncRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferEventSync: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferEventSyncRequest** | [**BankTransferEventSyncRequest**](BankTransferEventSyncRequest.md)|  | 

### Return type

[**BankTransferEventSyncResponse**](BankTransferEventSyncResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransferget"></a>
# **BankTransferGet**
> BankTransferGetResponse BankTransferGet (BankTransferGetRequest bankTransferGetRequest)

Retrieve a bank transfer

The `/bank_transfer/get` fetches information about the bank transfer corresponding to the given `bank_transfer_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferGetRequest = new BankTransferGetRequest(); // BankTransferGetRequest | 

            try
            {
                // Retrieve a bank transfer
                BankTransferGetResponse result = apiInstance.BankTransferGet(bankTransferGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferGetRequest** | [**BankTransferGetRequest**](BankTransferGetRequest.md)|  | 

### Return type

[**BankTransferGetResponse**](BankTransferGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransferlist"></a>
# **BankTransferList**
> BankTransferListResponse BankTransferList (BankTransferListRequest bankTransferListRequest)

List bank transfers

Use the `/bank_transfer/list` endpoint to see a list of all your bank transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired bank transfers. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferListRequest = new BankTransferListRequest(); // BankTransferListRequest | 

            try
            {
                // List bank transfers
                BankTransferListResponse result = apiInstance.BankTransferList(bankTransferListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferListRequest** | [**BankTransferListRequest**](BankTransferListRequest.md)|  | 

### Return type

[**BankTransferListResponse**](BankTransferListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfermigrateaccount"></a>
# **BankTransferMigrateAccount**
> BankTransferMigrateAccountResponse BankTransferMigrateAccount (BankTransferMigrateAccountRequest bankTransferMigrateAccountRequest)

Migrate account into Bank Transfers

As an alternative to adding Items via Link, you can also use the `/bank_transfer/migrate_account` endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as `/accounts/balance/get`, and can only be used with Bank Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to `/bank_transfer/migrate_account` is not enabled by default; to obtain access, contact your Plaid Account Manager.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferMigrateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferMigrateAccountRequest = new BankTransferMigrateAccountRequest(); // BankTransferMigrateAccountRequest | 

            try
            {
                // Migrate account into Bank Transfers
                BankTransferMigrateAccountResponse result = apiInstance.BankTransferMigrateAccount(bankTransferMigrateAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferMigrateAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferMigrateAccountRequest** | [**BankTransferMigrateAccountRequest**](BankTransferMigrateAccountRequest.md)|  | 

### Return type

[**BankTransferMigrateAccountResponse**](BankTransferMigrateAccountResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfersweepget"></a>
# **BankTransferSweepGet**
> BankTransferSweepGetResponse BankTransferSweepGet (BankTransferSweepGetRequest bankTransferSweepGetRequest)

Retrieve a sweep

The `/bank_transfer/sweep/get` endpoint fetches information about the sweep corresponding to the given `sweep_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferSweepGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferSweepGetRequest = new BankTransferSweepGetRequest(); // BankTransferSweepGetRequest | 

            try
            {
                // Retrieve a sweep
                BankTransferSweepGetResponse result = apiInstance.BankTransferSweepGet(bankTransferSweepGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferSweepGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferSweepGetRequest** | [**BankTransferSweepGetRequest**](BankTransferSweepGetRequest.md)|  | 

### Return type

[**BankTransferSweepGetResponse**](BankTransferSweepGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banktransfersweeplist"></a>
# **BankTransferSweepList**
> BankTransferSweepListResponse BankTransferSweepList (BankTransferSweepListRequest bankTransferSweepListRequest)

List sweeps

The `/bank_transfer/sweep/list` endpoint fetches information about the sweeps matching the given filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankTransferSweepListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var bankTransferSweepListRequest = new BankTransferSweepListRequest(); // BankTransferSweepListRequest | 

            try
            {
                // List sweeps
                BankTransferSweepListResponse result = apiInstance.BankTransferSweepList(bankTransferSweepListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.BankTransferSweepList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankTransferSweepListRequest** | [**BankTransferSweepListRequest**](BankTransferSweepListRequest.md)|  | 

### Return type

[**BankTransferSweepListResponse**](BankTransferSweepListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesget"></a>
# **CategoriesGet**
> CategoriesGetResponse CategoriesGet (Object body)

Get Categories

Send a request to the `/categories/get` endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            var apiInstance = new PlaidApi(config);
            var body = null;  // Object | 

            try
            {
                // Get Categories
                CategoriesGetResponse result = apiInstance.CategoriesGet(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.CategoriesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 

### Return type

[**CategoriesGetResponse**](CategoriesGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaymenttoken"></a>
# **CreatePaymentToken**
> PaymentInitiationPaymentTokenCreateResponse CreatePaymentToken (PaymentInitiationPaymentTokenCreateRequest paymentInitiationPaymentTokenCreateRequest)

Create payment token

The `/payment_initiation/payment/token/create` endpoint has been deprecated. New Plaid customers will be unable to use this endpoint, and existing customers are encouraged to migrate to the newer, `link_token`-based flow. The recommended flow is to provide the `payment_id` to `/link/token/create`, which returns a `link_token` used to initialize Link.  The `/payment_initiation/payment/token/create` is used to create a `payment_token`, which can then be used in Link initialization to enter a payment initiation flow. You can only use a `payment_token` once. If this attempt fails, the end user aborts the flow, or the token expires, you will need to create a new payment token. Creating a new payment token does not require end user input.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationPaymentTokenCreateRequest = new PaymentInitiationPaymentTokenCreateRequest(); // PaymentInitiationPaymentTokenCreateRequest | 

            try
            {
                // Create payment token
                PaymentInitiationPaymentTokenCreateResponse result = apiInstance.CreatePaymentToken(paymentInitiationPaymentTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.CreatePaymentToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationPaymentTokenCreateRequest** | [**PaymentInitiationPaymentTokenCreateRequest**](PaymentInitiationPaymentTokenCreateRequest.md)|  | 

### Return type

[**PaymentInitiationPaymentTokenCreateResponse**](PaymentInitiationPaymentTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositswitchaltcreate"></a>
# **DepositSwitchAltCreate**
> DepositSwitchAltCreateResponse DepositSwitchAltCreate (DepositSwitchAltCreateRequest depositSwitchAltCreateRequest)

Create a deposit switch without using Plaid Exchange

This endpoint provides an alternative to `/deposit_switch/create` for customers who have not yet fully integrated with Plaid Exchange. Like `/deposit_switch/create`, it creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepositSwitchAltCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var depositSwitchAltCreateRequest = new DepositSwitchAltCreateRequest(); // DepositSwitchAltCreateRequest | 

            try
            {
                // Create a deposit switch without using Plaid Exchange
                DepositSwitchAltCreateResponse result = apiInstance.DepositSwitchAltCreate(depositSwitchAltCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.DepositSwitchAltCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **depositSwitchAltCreateRequest** | [**DepositSwitchAltCreateRequest**](DepositSwitchAltCreateRequest.md)|  | 

### Return type

[**DepositSwitchAltCreateResponse**](DepositSwitchAltCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositswitchcreate"></a>
# **DepositSwitchCreate**
> DepositSwitchCreateResponse DepositSwitchCreate (DepositSwitchCreateRequest depositSwitchCreateRequest)

Create a deposit switch

This endpoint creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepositSwitchCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var depositSwitchCreateRequest = new DepositSwitchCreateRequest(); // DepositSwitchCreateRequest | 

            try
            {
                // Create a deposit switch
                DepositSwitchCreateResponse result = apiInstance.DepositSwitchCreate(depositSwitchCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.DepositSwitchCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **depositSwitchCreateRequest** | [**DepositSwitchCreateRequest**](DepositSwitchCreateRequest.md)|  | 

### Return type

[**DepositSwitchCreateResponse**](DepositSwitchCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositswitchget"></a>
# **DepositSwitchGet**
> DepositSwitchGetResponse DepositSwitchGet (DepositSwitchGetRequest depositSwitchGetRequest)

Retrieve a deposit switch

This endpoint returns information related to how the user has configured their payroll allocation and the state of the switch. You can use this information to build logic related to the user's direct deposit allocation preferences.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepositSwitchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var depositSwitchGetRequest = new DepositSwitchGetRequest(); // DepositSwitchGetRequest | 

            try
            {
                // Retrieve a deposit switch
                DepositSwitchGetResponse result = apiInstance.DepositSwitchGet(depositSwitchGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.DepositSwitchGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **depositSwitchGetRequest** | [**DepositSwitchGetRequest**](DepositSwitchGetRequest.md)|  | 

### Return type

[**DepositSwitchGetResponse**](DepositSwitchGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositswitchtokencreate"></a>
# **DepositSwitchTokenCreate**
> DepositSwitchTokenCreateResponse DepositSwitchTokenCreate (DepositSwitchTokenCreateRequest depositSwitchTokenCreateRequest)

Create a deposit switch token

In order for the end user to take action, you will need to create a public token representing the deposit switch. This token is used to initialize Link. It can be used one time and expires after 30 minutes. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepositSwitchTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var depositSwitchTokenCreateRequest = new DepositSwitchTokenCreateRequest(); // DepositSwitchTokenCreateRequest | 

            try
            {
                // Create a deposit switch token
                DepositSwitchTokenCreateResponse result = apiInstance.DepositSwitchTokenCreate(depositSwitchTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.DepositSwitchTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **depositSwitchTokenCreateRequest** | [**DepositSwitchTokenCreateRequest**](DepositSwitchTokenCreateRequest.md)|  | 

### Return type

[**DepositSwitchTokenCreateResponse**](DepositSwitchTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employerssearch"></a>
# **EmployersSearch**
> EmployersSearchResponse EmployersSearch (EmployersSearchRequest employersSearchRequest)

Search employer database

`/employers/search` allows you the ability to search Plaid’s database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.  The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmployersSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var employersSearchRequest = new EmployersSearchRequest(); // EmployersSearchRequest | 

            try
            {
                // Search employer database
                EmployersSearchResponse result = apiInstance.EmployersSearch(employersSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.EmployersSearch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employersSearchRequest** | [**EmployersSearchRequest**](EmployersSearchRequest.md)|  | 

### Return type

[**EmployersSearchResponse**](EmployersSearchResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employmentverificationget"></a>
# **EmploymentVerificationGet**
> EmploymentVerificationGetResponse EmploymentVerificationGet (EmploymentVerificationGetRequest employmentVerificationGetRequest)

Retrieve a summary of an individual's employment information

`/employment/verification/get` returns a list of employments through a user payroll that was verified by an end user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmploymentVerificationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var employmentVerificationGetRequest = new EmploymentVerificationGetRequest(); // EmploymentVerificationGetRequest | 

            try
            {
                // Retrieve a summary of an individual's employment information
                EmploymentVerificationGetResponse result = apiInstance.EmploymentVerificationGet(employmentVerificationGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.EmploymentVerificationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employmentVerificationGetRequest** | [**EmploymentVerificationGetRequest**](EmploymentVerificationGetRequest.md)|  | 

### Return type

[**EmploymentVerificationGetResponse**](EmploymentVerificationGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="identityget"></a>
# **IdentityGet**
> IdentityGetResponse IdentityGet (IdentityGetRequest identityGetRequest)

Retrieve identity data

The `/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.  Note: This request may take some time to complete if identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var identityGetRequest = new IdentityGetRequest(); // IdentityGetRequest | 

            try
            {
                // Retrieve identity data
                IdentityGetResponse result = apiInstance.IdentityGet(identityGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IdentityGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityGetRequest** | [**IdentityGetRequest**](IdentityGetRequest.md)|  | 

### Return type

[**IdentityGetResponse**](IdentityGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationcreate"></a>
# **IncomeVerificationCreate**
> IncomeVerificationCreateResponse IncomeVerificationCreate (IncomeVerificationCreateRequest incomeVerificationCreateRequest)

(Deprecated) Create an income verification instance

`/income/verification/create` begins the income verification process by returning an `income_verification_id`. You can then provide the `income_verification_id` to `/link/token/create` under the `income_verification` parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an `INCOME` webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationCreateRequest = new IncomeVerificationCreateRequest(); // IncomeVerificationCreateRequest | 

            try
            {
                // (Deprecated) Create an income verification instance
                IncomeVerificationCreateResponse result = apiInstance.IncomeVerificationCreate(incomeVerificationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationCreateRequest** | [**IncomeVerificationCreateRequest**](IncomeVerificationCreateRequest.md)|  | 

### Return type

[**IncomeVerificationCreateResponse**](IncomeVerificationCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationdocumentsdownload"></a>
# **IncomeVerificationDocumentsDownload**
> System.IO.Stream IncomeVerificationDocumentsDownload (IncomeVerificationDocumentsDownloadRequest incomeVerificationDocumentsDownloadRequest)

Download the original documents used for income verification

`/income/verification/documents/download` provides the ability to download the source documents associated with the verification.  If Document Income was used, the documents will be those the user provided in Link. For Payroll Income, the most recent files available for download from the payroll provider will be available from this endpoint.  The response to `/income/verification/documents/download` is a ZIP file in binary data. If a `document_id` is passed, a single document will be contained in this file. If not, the response will contain all documents associated with the verification.  The `request_id` is returned in the `Plaid-Request-ID` header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationDocumentsDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationDocumentsDownloadRequest = new IncomeVerificationDocumentsDownloadRequest(); // IncomeVerificationDocumentsDownloadRequest | 

            try
            {
                // Download the original documents used for income verification
                System.IO.Stream result = apiInstance.IncomeVerificationDocumentsDownload(incomeVerificationDocumentsDownloadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationDocumentsDownload: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationDocumentsDownloadRequest** | [**IncomeVerificationDocumentsDownloadRequest**](IncomeVerificationDocumentsDownloadRequest.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/zip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ZIP file containing source documents(s) used as the basis for income verification. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationpaystubget"></a>
# **IncomeVerificationPaystubGet**
> IncomeVerificationPaystubGetResponse IncomeVerificationPaystubGet (IncomeVerificationPaystubGetRequest incomeVerificationPaystubGetRequest)

(Deprecated) Retrieve information from a single paystub used for income verification

/income/verification/paystub/get returns information from a single paystub used for income verification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationPaystubGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationPaystubGetRequest = new IncomeVerificationPaystubGetRequest(); // IncomeVerificationPaystubGetRequest | 

            try
            {
                // (Deprecated) Retrieve information from a single paystub used for income verification
                IncomeVerificationPaystubGetResponse result = apiInstance.IncomeVerificationPaystubGet(incomeVerificationPaystubGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationPaystubGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationPaystubGetRequest** | [**IncomeVerificationPaystubGetRequest**](IncomeVerificationPaystubGetRequest.md)|  | 

### Return type

[**IncomeVerificationPaystubGetResponse**](IncomeVerificationPaystubGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationpaystubsget"></a>
# **IncomeVerificationPaystubsGet**
> IncomeVerificationPaystubsGetResponse IncomeVerificationPaystubsGet (IncomeVerificationPaystubsGetRequest incomeVerificationPaystubsGetRequest)

Retrieve information from the paystubs used for income verification

`/income/verification/paystubs/get` returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationPaystubsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationPaystubsGetRequest = new IncomeVerificationPaystubsGetRequest(); // IncomeVerificationPaystubsGetRequest | 

            try
            {
                // Retrieve information from the paystubs used for income verification
                IncomeVerificationPaystubsGetResponse result = apiInstance.IncomeVerificationPaystubsGet(incomeVerificationPaystubsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationPaystubsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationPaystubsGetRequest** | [**IncomeVerificationPaystubsGetRequest**](IncomeVerificationPaystubsGetRequest.md)|  | 

### Return type

[**IncomeVerificationPaystubsGetResponse**](IncomeVerificationPaystubsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationprecheck"></a>
# **IncomeVerificationPrecheck**
> IncomeVerificationPrecheckResponse IncomeVerificationPrecheck (IncomeVerificationPrecheckRequest incomeVerificationPrecheckRequest)

Check digital income verification eligibility and optimize conversion

`/income/verification/precheck` is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification and returns a `precheck_id` that can be provided to `/link/token/create`. If the user is eligible for digital verification, providing the `precheck_id` in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the `precheck_id` can still be provided to `/link/token/create` and the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.  While all request fields are optional, providing either `employer` or `transactions_access_tokens` data will increase the chance of receiving a useful result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationPrecheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationPrecheckRequest = new IncomeVerificationPrecheckRequest(); // IncomeVerificationPrecheckRequest | 

            try
            {
                // Check digital income verification eligibility and optimize conversion
                IncomeVerificationPrecheckResponse result = apiInstance.IncomeVerificationPrecheck(incomeVerificationPrecheckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationPrecheck: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationPrecheckRequest** | [**IncomeVerificationPrecheckRequest**](IncomeVerificationPrecheckRequest.md)|  | 

### Return type

[**IncomeVerificationPrecheckResponse**](IncomeVerificationPrecheckResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationrefresh"></a>
# **IncomeVerificationRefresh**
> IncomeVerificationRefreshResponse IncomeVerificationRefresh (IncomeVerificationRefreshRequest incomeVerificationRefreshRequest)

Refresh an income verification

`/income/verification/refresh` refreshes a given income verification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationRefreshRequest = new IncomeVerificationRefreshRequest(); // IncomeVerificationRefreshRequest | 

            try
            {
                // Refresh an income verification
                IncomeVerificationRefreshResponse result = apiInstance.IncomeVerificationRefresh(incomeVerificationRefreshRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationRefresh: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationRefreshRequest** | [**IncomeVerificationRefreshRequest**](IncomeVerificationRefreshRequest.md)|  | 

### Return type

[**IncomeVerificationRefreshResponse**](IncomeVerificationRefreshResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationsummaryget"></a>
# **IncomeVerificationSummaryGet**
> IncomeVerificationSummaryGetResponse IncomeVerificationSummaryGet (IncomeVerificationSummaryGetRequest incomeVerificationSummaryGetRequest)

(Deprecated) Retrieve a summary of information derived from income verification

`/income/verification/summary/get` returns a verification summary for the income that was verified for an end user. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var incomeVerificationSummaryGetRequest = new IncomeVerificationSummaryGetRequest(); // IncomeVerificationSummaryGetRequest | 

            try
            {
                // (Deprecated) Retrieve a summary of information derived from income verification
                IncomeVerificationSummaryGetResponse result = apiInstance.IncomeVerificationSummaryGet(incomeVerificationSummaryGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationSummaryGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **incomeVerificationSummaryGetRequest** | [**IncomeVerificationSummaryGetRequest**](IncomeVerificationSummaryGetRequest.md)|  | 

### Return type

[**IncomeVerificationSummaryGetResponse**](IncomeVerificationSummaryGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomeverificationtaxformsget"></a>
# **IncomeVerificationTaxformsGet**
> IncomeVerificationTaxformsGetResponse IncomeVerificationTaxformsGet (Dictionary<string, Object> requestBody)

Retrieve information from the tax documents used for income verification

`/income/verification/taxforms/get` returns the information collected from forms that were used to verify an end user's income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IncomeVerificationTaxformsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                // Retrieve information from the tax documents used for income verification
                IncomeVerificationTaxformsGetResponse result = apiInstance.IncomeVerificationTaxformsGet(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.IncomeVerificationTaxformsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md)|  | 

### Return type

[**IncomeVerificationTaxformsGetResponse**](IncomeVerificationTaxformsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="institutionsget"></a>
# **InstitutionsGet**
> InstitutionsGetResponse InstitutionsGet (InstitutionsGetRequest institutionsGetRequest)

Get details of all supported institutions

Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because Plaid supports thousands of institutions, results are paginated.  If there is no overlap between an institution’s enabled products and a client’s enabled products, then the institution will be filtered out from the response. As a result, the number of institutions returned may not match the count specified in the call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstitutionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var institutionsGetRequest = new InstitutionsGetRequest(); // InstitutionsGetRequest | 

            try
            {
                // Get details of all supported institutions
                InstitutionsGetResponse result = apiInstance.InstitutionsGet(institutionsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.InstitutionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionsGetRequest** | [**InstitutionsGetRequest**](InstitutionsGetRequest.md)|  | 

### Return type

[**InstitutionsGetResponse**](InstitutionsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="institutionsgetbyid"></a>
# **InstitutionsGetById**
> InstitutionsGetByIdResponse InstitutionsGetById (InstitutionsGetByIdRequest institutionsGetByIdRequest)

Get details of an institution

Returns a JSON response containing details on a specified financial institution currently supported by Plaid.   Versioning note: API versions 2019-05-29 and earlier allow use of the `public_key` parameter instead of the `client_id` and `secret` to authenticate to this endpoint. The `public_key` has been deprecated; all customers are encouraged to use `client_id` and `secret` instead. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstitutionsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var institutionsGetByIdRequest = new InstitutionsGetByIdRequest(); // InstitutionsGetByIdRequest | 

            try
            {
                // Get details of an institution
                InstitutionsGetByIdResponse result = apiInstance.InstitutionsGetById(institutionsGetByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.InstitutionsGetById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionsGetByIdRequest** | [**InstitutionsGetByIdRequest**](InstitutionsGetByIdRequest.md)|  | 

### Return type

[**InstitutionsGetByIdResponse**](InstitutionsGetByIdResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="institutionssearch"></a>
# **InstitutionsSearch**
> InstitutionsSearchResponse InstitutionsSearch (InstitutionsSearchRequest institutionsSearchRequest)

Search institutions

Returns a JSON response containing details for institutions that match the query parameters, up to a maximum of ten institutions per query.  Versioning note: API versions 2019-05-29 and earlier allow use of the `public_key` parameter instead of the `client_id` and `secret` parameters to authenticate to this endpoint. The `public_key` parameter has since been deprecated; all customers are encouraged to use `client_id` and `secret` instead. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstitutionsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var institutionsSearchRequest = new InstitutionsSearchRequest(); // InstitutionsSearchRequest | 

            try
            {
                // Search institutions
                InstitutionsSearchResponse result = apiInstance.InstitutionsSearch(institutionsSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.InstitutionsSearch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionsSearchRequest** | [**InstitutionsSearchRequest**](InstitutionsSearchRequest.md)|  | 

### Return type

[**InstitutionsSearchResponse**](InstitutionsSearchResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentsholdingsget"></a>
# **InvestmentsHoldingsGet**
> InvestmentsHoldingsGetResponse InvestmentsHoldingsGet (InvestmentsHoldingsGetRequest investmentsHoldingsGetRequest)

Get Investment holdings

The `/investments/holdings/get` endpoint allows developers to receive user-authorized stock position data for `investment`-type accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InvestmentsHoldingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var investmentsHoldingsGetRequest = new InvestmentsHoldingsGetRequest(); // InvestmentsHoldingsGetRequest | 

            try
            {
                // Get Investment holdings
                InvestmentsHoldingsGetResponse result = apiInstance.InvestmentsHoldingsGet(investmentsHoldingsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.InvestmentsHoldingsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investmentsHoldingsGetRequest** | [**InvestmentsHoldingsGetRequest**](InvestmentsHoldingsGetRequest.md)|  | 

### Return type

[**InvestmentsHoldingsGetResponse**](InvestmentsHoldingsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentstransactionsget"></a>
# **InvestmentsTransactionsGet**
> InvestmentsTransactionsGetResponse InvestmentsTransactionsGet (InvestmentsTransactionsGetRequest investmentsTransactionsGetRequest)

Get investment transactions

The `/investments/transactions/get` endpoint allows developers to retrieve user-authorized transaction data for investment accounts.  Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the `total_investment_transactions` response body field to fetch all available investment transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InvestmentsTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var investmentsTransactionsGetRequest = new InvestmentsTransactionsGetRequest(); // InvestmentsTransactionsGetRequest | 

            try
            {
                // Get investment transactions
                InvestmentsTransactionsGetResponse result = apiInstance.InvestmentsTransactionsGet(investmentsTransactionsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.InvestmentsTransactionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investmentsTransactionsGetRequest** | [**InvestmentsTransactionsGetRequest**](InvestmentsTransactionsGetRequest.md)|  | 

### Return type

[**InvestmentsTransactionsGetResponse**](InvestmentsTransactionsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemaccesstokeninvalidate"></a>
# **ItemAccessTokenInvalidate**
> ItemAccessTokenInvalidateResponse ItemAccessTokenInvalidate (ItemAccessTokenInvalidateRequest itemAccessTokenInvalidateRequest)

Invalidate access_token

By default, the `access_token` associated with an Item does not expire and should be stored in a persistent, secure manner.  You can use the `/item/access_token/invalidate` endpoint to rotate the `access_token` associated with an Item. The endpoint returns a new `access_token` and immediately invalidates the previous `access_token`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemAccessTokenInvalidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemAccessTokenInvalidateRequest = new ItemAccessTokenInvalidateRequest(); // ItemAccessTokenInvalidateRequest | 

            try
            {
                // Invalidate access_token
                ItemAccessTokenInvalidateResponse result = apiInstance.ItemAccessTokenInvalidate(itemAccessTokenInvalidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemAccessTokenInvalidate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccessTokenInvalidateRequest** | [**ItemAccessTokenInvalidateRequest**](ItemAccessTokenInvalidateRequest.md)|  | 

### Return type

[**ItemAccessTokenInvalidateResponse**](ItemAccessTokenInvalidateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemapplicationlist"></a>
# **ItemApplicationList**
> ItemApplicationListResponse ItemApplicationList (ItemApplicationListRequest itemApplicationListRequest)

List a user’s connected applications

List a user’s connected applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemApplicationListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemApplicationListRequest = new ItemApplicationListRequest(); // ItemApplicationListRequest | 

            try
            {
                // List a user’s connected applications
                ItemApplicationListResponse result = apiInstance.ItemApplicationList(itemApplicationListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemApplicationList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemApplicationListRequest** | [**ItemApplicationListRequest**](ItemApplicationListRequest.md)|  | 

### Return type

[**ItemApplicationListResponse**](ItemApplicationListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemapplicationscopesupdate"></a>
# **ItemApplicationScopesUpdate**
> ItemApplicationScopesUpdateResponse ItemApplicationScopesUpdate (ItemApplicationScopesUpdateRequest itemApplicationScopesUpdateRequest)

Update the scopes of access for a particular application

Enable consumers to update product access on selected accounts for an application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemApplicationScopesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemApplicationScopesUpdateRequest = new ItemApplicationScopesUpdateRequest(); // ItemApplicationScopesUpdateRequest | 

            try
            {
                // Update the scopes of access for a particular application
                ItemApplicationScopesUpdateResponse result = apiInstance.ItemApplicationScopesUpdate(itemApplicationScopesUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemApplicationScopesUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemApplicationScopesUpdateRequest** | [**ItemApplicationScopesUpdateRequest**](ItemApplicationScopesUpdateRequest.md)|  | 

### Return type

[**ItemApplicationScopesUpdateResponse**](ItemApplicationScopesUpdateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemcreatepublictoken"></a>
# **ItemCreatePublicToken**
> ItemPublicTokenCreateResponse ItemCreatePublicToken (ItemPublicTokenCreateRequest itemPublicTokenCreateRequest)

Create public token

Note: As of July 2020, the `/item/public_token/create` endpoint is deprecated. Instead, use `/link/token/create` with an `access_token` to create a Link token for use with [update mode](https://plaid.com/docs/link/update-mode).  If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the `/item/public_token/create` endpoint and then initialize Link with that `public_token`.  A `public_token` is one-time use and expires after 30 minutes. You use a `public_token` to initialize Link in [update mode](https://plaid.com/docs/link/update-mode) for a particular Item. You can generate a `public_token` for an Item even if you did not use Link to create the Item originally.  The `/item/public_token/create` endpoint is **not** used to create your initial `public_token`. If you have not already received an `access_token` for a specific Item, use Link to obtain your `public_token` instead. See the [Quickstart](https://plaid.com/docs/quickstart) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemCreatePublicTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemPublicTokenCreateRequest = new ItemPublicTokenCreateRequest(); // ItemPublicTokenCreateRequest | 

            try
            {
                // Create public token
                ItemPublicTokenCreateResponse result = apiInstance.ItemCreatePublicToken(itemPublicTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemCreatePublicToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemPublicTokenCreateRequest** | [**ItemPublicTokenCreateRequest**](ItemPublicTokenCreateRequest.md)|  | 

### Return type

[**ItemPublicTokenCreateResponse**](ItemPublicTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemget"></a>
# **ItemGet**
> ItemGetResponse ItemGet (ItemGetRequest itemGetRequest)

Retrieve an Item

Returns information about the status of an Item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemGetRequest = new ItemGetRequest(); // ItemGetRequest | 

            try
            {
                // Retrieve an Item
                ItemGetResponse result = apiInstance.ItemGet(itemGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemGetRequest** | [**ItemGetRequest**](ItemGetRequest.md)|  | 

### Return type

[**ItemGetResponse**](ItemGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemimport"></a>
# **ItemImport**
> ItemImportResponse ItemImport (ItemImportRequest itemImportRequest)

Import Item

`/item/import` creates an Item via your Plaid Exchange Integration and returns an `access_token`. As part of an `/item/import` request, you will include a User ID (`user_auth.user_id`) and Authentication Token (`user_auth.auth_token`) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.  Upon creating an Item via `/item/import`, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated. This will automatically generate the Plaid native account ID for the account the user will switch their direct deposit to (`target_account_id`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemImportRequest = new ItemImportRequest(); // ItemImportRequest | 

            try
            {
                // Import Item
                ItemImportResponse result = apiInstance.ItemImport(itemImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemImportRequest** | [**ItemImportRequest**](ItemImportRequest.md)|  | 

### Return type

[**ItemImportResponse**](ItemImportResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itempublictokenexchange"></a>
# **ItemPublicTokenExchange**
> ItemPublicTokenExchangeResponse ItemPublicTokenExchange (ItemPublicTokenExchangeRequest itemPublicTokenExchangeRequest)

Exchange public token for an access token

Exchange a Link `public_token` for an API `access_token`. Link hands off the `public_token` client-side via the `onSuccess` callback once a user has successfully created an Item. The `public_token` is ephemeral and expires after 30 minutes.  The response also includes an `item_id` that should be stored with the `access_token`. The `item_id` is used to identify an Item in a webhook. The `item_id` can also be retrieved by making an `/item/get` request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemPublicTokenExchangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemPublicTokenExchangeRequest = new ItemPublicTokenExchangeRequest(); // ItemPublicTokenExchangeRequest | 

            try
            {
                // Exchange public token for an access token
                ItemPublicTokenExchangeResponse result = apiInstance.ItemPublicTokenExchange(itemPublicTokenExchangeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemPublicTokenExchange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemPublicTokenExchangeRequest** | [**ItemPublicTokenExchangeRequest**](ItemPublicTokenExchangeRequest.md)|  | 

### Return type

[**ItemPublicTokenExchangeResponse**](ItemPublicTokenExchangeResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemremove"></a>
# **ItemRemove**
> ItemRemoveResponse ItemRemove (ItemRemoveRequest itemRemoveRequest)

Remove an Item

The `/item/remove`  endpoint allows you to remove an Item. Once removed, the `access_token`  associated with the Item is no longer valid and cannot be used to access any data that was associated with the Item.  Note that in the Development environment, issuing an `/item/remove`  request will not decrement your live credential count. To increase your credential account in Development, contact Support.  Also note that for certain OAuth-based institutions, an Item removed via `/item/remove` may still show as an active connection in the institution's OAuth permission manager.  API versions 2019-05-29 and earlier return a `removed` boolean as part of the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemRemoveRequest = new ItemRemoveRequest(); // ItemRemoveRequest | 

            try
            {
                // Remove an Item
                ItemRemoveResponse result = apiInstance.ItemRemove(itemRemoveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemRemoveRequest** | [**ItemRemoveRequest**](ItemRemoveRequest.md)|  | 

### Return type

[**ItemRemoveResponse**](ItemRemoveResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemwebhookupdate"></a>
# **ItemWebhookUpdate**
> ItemWebhookUpdateResponse ItemWebhookUpdate (ItemWebhookUpdateRequest itemWebhookUpdateRequest)

Update Webhook URL

The POST `/item/webhook/update` allows you to update the webhook URL associated with an Item. This request triggers a [`WEBHOOK_UPDATE_ACKNOWLEDGED`](https://plaid.com/docs/api/webhooks/#item-webhook-update-acknowledged) webhook to the newly specified webhook URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ItemWebhookUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var itemWebhookUpdateRequest = new ItemWebhookUpdateRequest(); // ItemWebhookUpdateRequest | 

            try
            {
                // Update Webhook URL
                ItemWebhookUpdateResponse result = apiInstance.ItemWebhookUpdate(itemWebhookUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ItemWebhookUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemWebhookUpdateRequest** | [**ItemWebhookUpdateRequest**](ItemWebhookUpdateRequest.md)|  | 

### Return type

[**ItemWebhookUpdateResponse**](ItemWebhookUpdateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liabilitiesget"></a>
# **LiabilitiesGet**
> LiabilitiesGetResponse LiabilitiesGet (LiabilitiesGetRequest liabilitiesGetRequest)

Retrieve Liabilities data

The `/liabilities/get` endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type `credit` with account subtype `credit card` or `paypal`, and account type `loan` with account subtype `student` or `mortgage`. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the `account_filters` parameter when [creating a Link token](https://plaid.com/docs/api/tokens/#linktokencreate).  The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling `/liabilities/get`.  Note: This request may take some time to complete if `liabilities` was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the additional data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LiabilitiesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var liabilitiesGetRequest = new LiabilitiesGetRequest(); // LiabilitiesGetRequest | 

            try
            {
                // Retrieve Liabilities data
                LiabilitiesGetResponse result = apiInstance.LiabilitiesGet(liabilitiesGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.LiabilitiesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liabilitiesGetRequest** | [**LiabilitiesGetRequest**](LiabilitiesGetRequest.md)|  | 

### Return type

[**LiabilitiesGetResponse**](LiabilitiesGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linktokencreate"></a>
# **LinkTokenCreate**
> LinkTokenCreateResponse LinkTokenCreate (LinkTokenCreateRequest linkTokenCreateRequest)

Create Link Token

The `/link/token/create` endpoint creates a `link_token`, which is required as a parameter when initializing Link. Once Link has been initialized, it returns a `public_token`, which can then be exchanged for an `access_token` via `/item/public_token/exchange` as part of the main Link flow.  A `link_token` generated by `/link/token/create` is also used to initialize other Link flows, such as the update mode flow for tokens with expired credentials, or the Payment Initiation (Europe) flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LinkTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var linkTokenCreateRequest = new LinkTokenCreateRequest(); // LinkTokenCreateRequest | 

            try
            {
                // Create Link Token
                LinkTokenCreateResponse result = apiInstance.LinkTokenCreate(linkTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.LinkTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkTokenCreateRequest** | [**LinkTokenCreateRequest**](LinkTokenCreateRequest.md)|  | 

### Return type

[**LinkTokenCreateResponse**](LinkTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linktokenget"></a>
# **LinkTokenGet**
> LinkTokenGetResponse LinkTokenGet (LinkTokenGetRequest linkTokenGetRequest)

Get Link Token

The `/link/token/get` endpoint gets information about a previously-created `link_token` using the `/link/token/create` endpoint. It can be useful for debugging purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LinkTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var linkTokenGetRequest = new LinkTokenGetRequest(); // LinkTokenGetRequest | 

            try
            {
                // Get Link Token
                LinkTokenGetResponse result = apiInstance.LinkTokenGet(linkTokenGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.LinkTokenGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkTokenGetRequest** | [**LinkTokenGetRequest**](LinkTokenGetRequest.md)|  | 

### Return type

[**LinkTokenGetResponse**](LinkTokenGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationpaymentcreate"></a>
# **PaymentInitiationPaymentCreate**
> PaymentInitiationPaymentCreateResponse PaymentInitiationPaymentCreate (PaymentInitiationPaymentCreateRequest paymentInitiationPaymentCreateRequest)

Create a payment

After creating a payment recipient, you can use the `/payment_initiation/payment/create` endpoint to create a payment to that recipient.  Payments can be one-time or standing order (recurring) and can be denominated in either EUR or GBP.  If making domestic GBP-denominated payments, your recipient must have been created with BACS numbers. In general, EUR-denominated payments will be sent via SEPA Credit Transfer and GBP-denominated payments will be sent via the Faster Payments network, but the payment network used will be determined by the institution. Payments sent via Faster Payments will typically arrive immediately, while payments sent via SEPA Credit Transfer will typically arrive in one business day.  Standing orders (recurring payments) must be denominated in GBP and can only be sent to recipients in the UK. Once created, standing order payments cannot be modified or canceled via the API. An end user can cancel or modify a standing order directly on their banking application or website, or by contacting the bank. Standing orders will follow the payment rules of the underlying rails (Faster Payments in UK). Payments can be sent Monday to Friday, excluding bank holidays. If the pre-arranged date falls on a weekend or bank holiday, the payment is made on the next working day. It is not possible to guarantee the exact time the payment will reach the recipient’s account, although at least 90% of standing order payments are sent by 6am.  In the Development environment, payments must be below 5 GBP / EUR. For details on any payment limits in Production, contact your Plaid Account Manager.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationPaymentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationPaymentCreateRequest = new PaymentInitiationPaymentCreateRequest(); // PaymentInitiationPaymentCreateRequest | 

            try
            {
                // Create a payment
                PaymentInitiationPaymentCreateResponse result = apiInstance.PaymentInitiationPaymentCreate(paymentInitiationPaymentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationPaymentCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationPaymentCreateRequest** | [**PaymentInitiationPaymentCreateRequest**](PaymentInitiationPaymentCreateRequest.md)|  | 

### Return type

[**PaymentInitiationPaymentCreateResponse**](PaymentInitiationPaymentCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationpaymentget"></a>
# **PaymentInitiationPaymentGet**
> PaymentInitiationPaymentGetResponse PaymentInitiationPaymentGet (PaymentInitiationPaymentGetRequest paymentInitiationPaymentGetRequest)

Get payment details

The `/payment_initiation/payment/get` endpoint can be used to check the status of a payment, as well as to receive basic information such as recipient and payment amount. In the case of standing orders, the `/payment_initiation/payment/get` endpoint will provide information about the status of the overall standing order itself; the API cannot be used to retrieve payment status for individual payments within a standing order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationPaymentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationPaymentGetRequest = new PaymentInitiationPaymentGetRequest(); // PaymentInitiationPaymentGetRequest | 

            try
            {
                // Get payment details
                PaymentInitiationPaymentGetResponse result = apiInstance.PaymentInitiationPaymentGet(paymentInitiationPaymentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationPaymentGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationPaymentGetRequest** | [**PaymentInitiationPaymentGetRequest**](PaymentInitiationPaymentGetRequest.md)|  | 

### Return type

[**PaymentInitiationPaymentGetResponse**](PaymentInitiationPaymentGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationpaymentlist"></a>
# **PaymentInitiationPaymentList**
> PaymentInitiationPaymentListResponse PaymentInitiationPaymentList (PaymentInitiationPaymentListRequest paymentInitiationPaymentListRequest)

List payments

The `/payment_initiation/payment/list` endpoint can be used to retrieve all created payments. By default, the 10 most recent payments are returned. You can request more payments and paginate through the results using the optional `count` and `cursor` parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationPaymentListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationPaymentListRequest = new PaymentInitiationPaymentListRequest(); // PaymentInitiationPaymentListRequest | 

            try
            {
                // List payments
                PaymentInitiationPaymentListResponse result = apiInstance.PaymentInitiationPaymentList(paymentInitiationPaymentListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationPaymentList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationPaymentListRequest** | [**PaymentInitiationPaymentListRequest**](PaymentInitiationPaymentListRequest.md)|  | 

### Return type

[**PaymentInitiationPaymentListResponse**](PaymentInitiationPaymentListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationpaymentreverse"></a>
# **PaymentInitiationPaymentReverse**
> PaymentInitiationPaymentReverseResponse PaymentInitiationPaymentReverse (PaymentInitiationPaymentReverseRequest paymentInitiationPaymentReverseRequest)

Reverse an existing payment

Reverse a previously initiated payment.  A payment can only be reversed once and will be refunded to the original sender's account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationPaymentReverseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationPaymentReverseRequest = new PaymentInitiationPaymentReverseRequest(); // PaymentInitiationPaymentReverseRequest | 

            try
            {
                // Reverse an existing payment
                PaymentInitiationPaymentReverseResponse result = apiInstance.PaymentInitiationPaymentReverse(paymentInitiationPaymentReverseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationPaymentReverse: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationPaymentReverseRequest** | [**PaymentInitiationPaymentReverseRequest**](PaymentInitiationPaymentReverseRequest.md)|  | 

### Return type

[**PaymentInitiationPaymentReverseResponse**](PaymentInitiationPaymentReverseResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationrecipientcreate"></a>
# **PaymentInitiationRecipientCreate**
> PaymentInitiationRecipientCreateResponse PaymentInitiationRecipientCreate (PaymentInitiationRecipientCreateRequest paymentInitiationRecipientCreateRequest)

Create payment recipient

Create a payment recipient for payment initiation.  The recipient must be in Europe, within a country that is a member of the Single Euro Payment Area (SEPA).  For a standing order (recurring) payment, the recipient must be in the UK.  The endpoint is idempotent: if a developer has already made a request with the same payment details, Plaid will return the same `recipient_id`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationRecipientCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationRecipientCreateRequest = new PaymentInitiationRecipientCreateRequest(); // PaymentInitiationRecipientCreateRequest | 

            try
            {
                // Create payment recipient
                PaymentInitiationRecipientCreateResponse result = apiInstance.PaymentInitiationRecipientCreate(paymentInitiationRecipientCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationRecipientCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationRecipientCreateRequest** | [**PaymentInitiationRecipientCreateRequest**](PaymentInitiationRecipientCreateRequest.md)|  | 

### Return type

[**PaymentInitiationRecipientCreateResponse**](PaymentInitiationRecipientCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationrecipientget"></a>
# **PaymentInitiationRecipientGet**
> PaymentInitiationRecipientGetResponse PaymentInitiationRecipientGet (PaymentInitiationRecipientGetRequest paymentInitiationRecipientGetRequest)

Get payment recipient

Get details about a payment recipient you have previously created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationRecipientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationRecipientGetRequest = new PaymentInitiationRecipientGetRequest(); // PaymentInitiationRecipientGetRequest | 

            try
            {
                // Get payment recipient
                PaymentInitiationRecipientGetResponse result = apiInstance.PaymentInitiationRecipientGet(paymentInitiationRecipientGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationRecipientGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationRecipientGetRequest** | [**PaymentInitiationRecipientGetRequest**](PaymentInitiationRecipientGetRequest.md)|  | 

### Return type

[**PaymentInitiationRecipientGetResponse**](PaymentInitiationRecipientGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentinitiationrecipientlist"></a>
# **PaymentInitiationRecipientList**
> PaymentInitiationRecipientListResponse PaymentInitiationRecipientList (PaymentInitiationRecipientListRequest paymentInitiationRecipientListRequest)

List payment recipients

The `/payment_initiation/recipient/list` endpoint list the payment recipients that you have previously created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentInitiationRecipientListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var paymentInitiationRecipientListRequest = new PaymentInitiationRecipientListRequest(); // PaymentInitiationRecipientListRequest | 

            try
            {
                // List payment recipients
                PaymentInitiationRecipientListResponse result = apiInstance.PaymentInitiationRecipientList(paymentInitiationRecipientListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.PaymentInitiationRecipientList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInitiationRecipientListRequest** | [**PaymentInitiationRecipientListRequest**](PaymentInitiationRecipientListRequest.md)|  | 

### Return type

[**PaymentInitiationRecipientListResponse**](PaymentInitiationRecipientListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processorapexprocessortokencreate"></a>
# **ProcessorApexProcessorTokenCreate**
> ProcessorTokenCreateResponse ProcessorApexProcessorTokenCreate (ProcessorApexProcessorTokenCreateRequest processorApexProcessorTokenCreateRequest)

Create Apex bank account token

Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorApexProcessorTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorApexProcessorTokenCreateRequest = new ProcessorApexProcessorTokenCreateRequest(); // ProcessorApexProcessorTokenCreateRequest | 

            try
            {
                // Create Apex bank account token
                ProcessorTokenCreateResponse result = apiInstance.ProcessorApexProcessorTokenCreate(processorApexProcessorTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorApexProcessorTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorApexProcessorTokenCreateRequest** | [**ProcessorApexProcessorTokenCreateRequest**](ProcessorApexProcessorTokenCreateRequest.md)|  | 

### Return type

[**ProcessorTokenCreateResponse**](ProcessorTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processorauthget"></a>
# **ProcessorAuthGet**
> ProcessorAuthGetResponse ProcessorAuthGet (ProcessorAuthGetRequest processorAuthGetRequest)

Retrieve Auth data

The `/processor/auth/get` endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that''s associated with a given `processor_token`. The endpoint also returns high-level account data and balances when available.   Versioning note: API versions 2019-05-29 and earlier use a different schema for the `numbers` object returned by this endpoint. For details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2020-09-14). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorAuthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorAuthGetRequest = new ProcessorAuthGetRequest(); // ProcessorAuthGetRequest | 

            try
            {
                // Retrieve Auth data
                ProcessorAuthGetResponse result = apiInstance.ProcessorAuthGet(processorAuthGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorAuthGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorAuthGetRequest** | [**ProcessorAuthGetRequest**](ProcessorAuthGetRequest.md)|  | 

### Return type

[**ProcessorAuthGetResponse**](ProcessorAuthGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processorbalanceget"></a>
# **ProcessorBalanceGet**
> ProcessorBalanceGetResponse ProcessorBalanceGet (ProcessorBalanceGetRequest processorBalanceGetRequest)

Retrieve Balance data

The `/processor/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/processor/balance/get` forces the available and current balance fields to be refreshed rather than cached. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorBalanceGetRequest = new ProcessorBalanceGetRequest(); // ProcessorBalanceGetRequest | The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.  The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.  Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`.

            try
            {
                // Retrieve Balance data
                ProcessorBalanceGetResponse result = apiInstance.ProcessorBalanceGet(processorBalanceGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorBalanceGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorBalanceGetRequest** | [**ProcessorBalanceGetRequest**](ProcessorBalanceGetRequest.md)| The &#x60;/processor/balance/get&#x60; endpoint returns the real-time balance for the account associated with a given &#x60;processor_token&#x60;.  The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.  Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of &#x60;null&#x60;. | 

### Return type

[**ProcessorBalanceGetResponse**](ProcessorBalanceGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processorbanktransfercreate"></a>
# **ProcessorBankTransferCreate**
> ProcessorBankTransferCreateResponse ProcessorBankTransferCreate (ProcessorBankTransferCreateRequest processorBankTransferCreateRequest)

Create a bank transfer as a processor

Use the `/processor/bank_transfer/create` endpoint to initiate a new bank transfer as a processor

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorBankTransferCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorBankTransferCreateRequest = new ProcessorBankTransferCreateRequest(); // ProcessorBankTransferCreateRequest | 

            try
            {
                // Create a bank transfer as a processor
                ProcessorBankTransferCreateResponse result = apiInstance.ProcessorBankTransferCreate(processorBankTransferCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorBankTransferCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorBankTransferCreateRequest** | [**ProcessorBankTransferCreateRequest**](ProcessorBankTransferCreateRequest.md)|  | 

### Return type

[**ProcessorBankTransferCreateResponse**](ProcessorBankTransferCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processoridentityget"></a>
# **ProcessorIdentityGet**
> ProcessorIdentityGetResponse ProcessorIdentityGet (ProcessorIdentityGetRequest processorIdentityGetRequest)

Retrieve Identity data

The `/processor/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorIdentityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorIdentityGetRequest = new ProcessorIdentityGetRequest(); // ProcessorIdentityGetRequest | 

            try
            {
                // Retrieve Identity data
                ProcessorIdentityGetResponse result = apiInstance.ProcessorIdentityGet(processorIdentityGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorIdentityGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorIdentityGetRequest** | [**ProcessorIdentityGetRequest**](ProcessorIdentityGetRequest.md)|  | 

### Return type

[**ProcessorIdentityGetResponse**](ProcessorIdentityGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processorstripebankaccounttokencreate"></a>
# **ProcessorStripeBankAccountTokenCreate**
> ProcessorStripeBankAccountTokenCreateResponse ProcessorStripeBankAccountTokenCreate (ProcessorStripeBankAccountTokenCreateRequest processorStripeBankAccountTokenCreateRequest)

Create Stripe bank account token

Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see [Add Stripe to your app](https://plaid.com/docs/auth/partnerships/stripe/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorStripeBankAccountTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorStripeBankAccountTokenCreateRequest = new ProcessorStripeBankAccountTokenCreateRequest(); // ProcessorStripeBankAccountTokenCreateRequest | 

            try
            {
                // Create Stripe bank account token
                ProcessorStripeBankAccountTokenCreateResponse result = apiInstance.ProcessorStripeBankAccountTokenCreate(processorStripeBankAccountTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorStripeBankAccountTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorStripeBankAccountTokenCreateRequest** | [**ProcessorStripeBankAccountTokenCreateRequest**](ProcessorStripeBankAccountTokenCreateRequest.md)|  | 

### Return type

[**ProcessorStripeBankAccountTokenCreateResponse**](ProcessorStripeBankAccountTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processortokencreate"></a>
# **ProcessorTokenCreate**
> ProcessorTokenCreateResponse ProcessorTokenCreate (ProcessorTokenCreateRequest processorTokenCreateRequest)

Create processor token

Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see `/processor/stripe/bank_account_token/create` for creating tokens for use with Stripe integrations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessorTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var processorTokenCreateRequest = new ProcessorTokenCreateRequest(); // ProcessorTokenCreateRequest | 

            try
            {
                // Create processor token
                ProcessorTokenCreateResponse result = apiInstance.ProcessorTokenCreate(processorTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.ProcessorTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processorTokenCreateRequest** | [**ProcessorTokenCreateRequest**](ProcessorTokenCreateRequest.md)|  | 

### Return type

[**ProcessorTokenCreateResponse**](ProcessorTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxbanktransferfirewebhook"></a>
# **SandboxBankTransferFireWebhook**
> SandboxBankTransferFireWebhookResponse SandboxBankTransferFireWebhook (SandboxBankTransferFireWebhookRequest sandboxBankTransferFireWebhookRequest)

Manually fire a Bank Transfer webhook

Use the `/sandbox/bank_transfer/fire_webhook` endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxBankTransferFireWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxBankTransferFireWebhookRequest = new SandboxBankTransferFireWebhookRequest(); // SandboxBankTransferFireWebhookRequest | 

            try
            {
                // Manually fire a Bank Transfer webhook
                SandboxBankTransferFireWebhookResponse result = apiInstance.SandboxBankTransferFireWebhook(sandboxBankTransferFireWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxBankTransferFireWebhook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxBankTransferFireWebhookRequest** | [**SandboxBankTransferFireWebhookRequest**](SandboxBankTransferFireWebhookRequest.md)|  | 

### Return type

[**SandboxBankTransferFireWebhookResponse**](SandboxBankTransferFireWebhookResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxbanktransfersimulate"></a>
# **SandboxBankTransferSimulate**
> SandboxBankTransferSimulateResponse SandboxBankTransferSimulate (SandboxBankTransferSimulateRequest sandboxBankTransferSimulateRequest)

Simulate a bank transfer event in Sandbox

Use the `/sandbox/bank_transfer/simulate` endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/bank_transfer/event/sync` or `/bank_transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxBankTransferSimulateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxBankTransferSimulateRequest = new SandboxBankTransferSimulateRequest(); // SandboxBankTransferSimulateRequest | 

            try
            {
                // Simulate a bank transfer event in Sandbox
                SandboxBankTransferSimulateResponse result = apiInstance.SandboxBankTransferSimulate(sandboxBankTransferSimulateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxBankTransferSimulate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxBankTransferSimulateRequest** | [**SandboxBankTransferSimulateRequest**](SandboxBankTransferSimulateRequest.md)|  | 

### Return type

[**SandboxBankTransferSimulateResponse**](SandboxBankTransferSimulateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxincomefirewebhook"></a>
# **SandboxIncomeFireWebhook**
> SandboxIncomeFireWebhookResponse SandboxIncomeFireWebhook (SandboxIncomeFireWebhookRequest sandboxIncomeFireWebhookRequest)

Manually fire an Income webhook

Use the `/sandbox/income/fire_webhook` endpoint to manually trigger an Income webhook in the Sandbox environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxIncomeFireWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxIncomeFireWebhookRequest = new SandboxIncomeFireWebhookRequest(); // SandboxIncomeFireWebhookRequest | 

            try
            {
                // Manually fire an Income webhook
                SandboxIncomeFireWebhookResponse result = apiInstance.SandboxIncomeFireWebhook(sandboxIncomeFireWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxIncomeFireWebhook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxIncomeFireWebhookRequest** | [**SandboxIncomeFireWebhookRequest**](SandboxIncomeFireWebhookRequest.md)|  | 

### Return type

[**SandboxIncomeFireWebhookResponse**](SandboxIncomeFireWebhookResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxitemfirewebhook"></a>
# **SandboxItemFireWebhook**
> SandboxItemFireWebhookResponse SandboxItemFireWebhook (SandboxItemFireWebhookRequest sandboxItemFireWebhookRequest)

Fire a test webhook

The `/sandbox/item/fire_webhook` endpoint is used to test that code correctly handles webhooks. This endpoint can trigger a Transactions `DEFAULT_UPDATE` webhook to be fired for a given Sandbox Item. If the Item does not support Transactions, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result. This endpoint can also trigger a `NEW_ACCOUNTS_AVAILABLE` webhook to be fired for a given Sandbox Item created with Account Select v2. Note that this endpoint is provided for developer ease-of-use and is not required for testing webhooks; webhooks will also fire in Sandbox under the same conditions that they would in Production or Development.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxItemFireWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxItemFireWebhookRequest = new SandboxItemFireWebhookRequest(); // SandboxItemFireWebhookRequest | 

            try
            {
                // Fire a test webhook
                SandboxItemFireWebhookResponse result = apiInstance.SandboxItemFireWebhook(sandboxItemFireWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxItemFireWebhook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxItemFireWebhookRequest** | [**SandboxItemFireWebhookRequest**](SandboxItemFireWebhookRequest.md)|  | 

### Return type

[**SandboxItemFireWebhookResponse**](SandboxItemFireWebhookResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxitemresetlogin"></a>
# **SandboxItemResetLogin**
> SandboxItemResetLoginResponse SandboxItemResetLogin (SandboxItemResetLoginRequest sandboxItemResetLoginRequest)

Force a Sandbox Item into an error state

`/sandbox/item/reset_login/` forces an Item into an `ITEM_LOGIN_REQUIRED` state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's [update mode](https://plaid.com/docs/link/update-mode) flow in the Sandbox environment.  After calling `/sandbox/item/reset_login`, You can then use Plaid Link update mode to restore the Item to a good state. An `ITEM_LOGIN_REQUIRED` webhook will also be fired after a call to this endpoint, if one is associated with the Item.   In the Sandbox, Items will transition to an `ITEM_LOGIN_REQUIRED` error state automatically after 30 days, even if this endpoint is not called.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxItemResetLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxItemResetLoginRequest = new SandboxItemResetLoginRequest(); // SandboxItemResetLoginRequest | 

            try
            {
                // Force a Sandbox Item into an error state
                SandboxItemResetLoginResponse result = apiInstance.SandboxItemResetLogin(sandboxItemResetLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxItemResetLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxItemResetLoginRequest** | [**SandboxItemResetLoginRequest**](SandboxItemResetLoginRequest.md)|  | 

### Return type

[**SandboxItemResetLoginResponse**](SandboxItemResetLoginResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxitemsetverificationstatus"></a>
# **SandboxItemSetVerificationStatus**
> SandboxItemSetVerificationStatusResponse SandboxItemSetVerificationStatus (SandboxItemSetVerificationStatusRequest sandboxItemSetVerificationStatusRequest)

Set verification status for Sandbox account

The `/sandbox/item/set_verification_status` endpoint can be used to change the verification status of an Item in in the Sandbox in order to simulate the Automated Micro-deposit flow.  Note that not all Plaid developer accounts are enabled for micro-deposit based verification by default. Your account must be enabled for this feature in order to test it in Sandbox. To enable this features or check your status, contact your account manager or [submit a product access Support ticket](https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access).  For more information on testing Automated Micro-deposits in Sandbox, see [Auth full coverage testing](https://plaid.com/docs/auth/coverage/testing#).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxItemSetVerificationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxItemSetVerificationStatusRequest = new SandboxItemSetVerificationStatusRequest(); // SandboxItemSetVerificationStatusRequest | 

            try
            {
                // Set verification status for Sandbox account
                SandboxItemSetVerificationStatusResponse result = apiInstance.SandboxItemSetVerificationStatus(sandboxItemSetVerificationStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxItemSetVerificationStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxItemSetVerificationStatusRequest** | [**SandboxItemSetVerificationStatusRequest**](SandboxItemSetVerificationStatusRequest.md)|  | 

### Return type

[**SandboxItemSetVerificationStatusResponse**](SandboxItemSetVerificationStatusResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxoauthselectaccounts"></a>
# **SandboxOauthSelectAccounts**
> Dictionary&lt;string, Object&gt; SandboxOauthSelectAccounts (SandboxOauthSelectAccountsRequest sandboxOauthSelectAccountsRequest)

Save the selected accounts when connecting to the Platypus Oauth institution

Save the selected accounts when connecting to the Platypus Oauth institution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxOauthSelectAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxOauthSelectAccountsRequest = new SandboxOauthSelectAccountsRequest(); // SandboxOauthSelectAccountsRequest | 

            try
            {
                // Save the selected accounts when connecting to the Platypus Oauth institution
                Dictionary<string, Object> result = apiInstance.SandboxOauthSelectAccounts(sandboxOauthSelectAccountsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxOauthSelectAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxOauthSelectAccountsRequest** | [**SandboxOauthSelectAccountsRequest**](SandboxOauthSelectAccountsRequest.md)|  | 

### Return type

**Dictionary<string, Object>**

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxprocessortokencreate"></a>
# **SandboxProcessorTokenCreate**
> SandboxProcessorTokenCreateResponse SandboxProcessorTokenCreate (SandboxProcessorTokenCreateRequest sandboxProcessorTokenCreateRequest)

Create a test Item and processor token

Use the `/sandbox/processor_token/create` endpoint to create a valid `processor_token` for an arbitrary institution ID and test credentials. The created `processor_token` corresponds to a new Sandbox Item. You can then use this `processor_token` with the `/processor/` API endpoints in Sandbox. You can also use `/sandbox/processor_token/create` with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxProcessorTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxProcessorTokenCreateRequest = new SandboxProcessorTokenCreateRequest(); // SandboxProcessorTokenCreateRequest | 

            try
            {
                // Create a test Item and processor token
                SandboxProcessorTokenCreateResponse result = apiInstance.SandboxProcessorTokenCreate(sandboxProcessorTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxProcessorTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxProcessorTokenCreateRequest** | [**SandboxProcessorTokenCreateRequest**](SandboxProcessorTokenCreateRequest.md)|  | 

### Return type

[**SandboxProcessorTokenCreateResponse**](SandboxProcessorTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxpublictokencreate"></a>
# **SandboxPublicTokenCreate**
> SandboxPublicTokenCreateResponse SandboxPublicTokenCreate (SandboxPublicTokenCreateRequest sandboxPublicTokenCreateRequest)

Create a test Item

Use the `/sandbox/public_token/create` endpoint to create a valid `public_token`  for an arbitrary institution ID, initial products, and test credentials. The created `public_token` maps to a new Sandbox Item. You can then call `/item/public_token/exchange` to exchange the `public_token` for an `access_token` and perform all API actions. `/sandbox/public_token/create` can also be used with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data. `/sandbox/public_token/create` cannot be used with OAuth institutions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxPublicTokenCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxPublicTokenCreateRequest = new SandboxPublicTokenCreateRequest(); // SandboxPublicTokenCreateRequest | 

            try
            {
                // Create a test Item
                SandboxPublicTokenCreateResponse result = apiInstance.SandboxPublicTokenCreate(sandboxPublicTokenCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxPublicTokenCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxPublicTokenCreateRequest** | [**SandboxPublicTokenCreateRequest**](SandboxPublicTokenCreateRequest.md)|  | 

### Return type

[**SandboxPublicTokenCreateResponse**](SandboxPublicTokenCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxtransferrepaymentsimulate"></a>
# **SandboxTransferRepaymentSimulate**
> SandboxTransferRepaymentSimulateResponse SandboxTransferRepaymentSimulate (SandboxTransferRepaymentSimulateRequest sandboxTransferRepaymentSimulateRequest)

Trigger the creation of a repayment

Use the `/sandbox/transfer/repayment/simulate` endpoint to trigger the creation of a repayment. As a side effect of calling this route, a repayment is created that includes all unreimbursed returns of guaranteed transfers. If there are no such returns, an 400 error is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxTransferRepaymentSimulateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxTransferRepaymentSimulateRequest = new SandboxTransferRepaymentSimulateRequest(); // SandboxTransferRepaymentSimulateRequest | 

            try
            {
                // Trigger the creation of a repayment
                SandboxTransferRepaymentSimulateResponse result = apiInstance.SandboxTransferRepaymentSimulate(sandboxTransferRepaymentSimulateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxTransferRepaymentSimulate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxTransferRepaymentSimulateRequest** | [**SandboxTransferRepaymentSimulateRequest**](SandboxTransferRepaymentSimulateRequest.md)|  | 

### Return type

[**SandboxTransferRepaymentSimulateResponse**](SandboxTransferRepaymentSimulateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxtransfersimulate"></a>
# **SandboxTransferSimulate**
> SandboxTransferSimulateResponse SandboxTransferSimulate (SandboxTransferSimulateRequest sandboxTransferSimulateRequest)

Simulate a transfer event in Sandbox

Use the `/sandbox/transfer/simulate` endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/transfer/event/sync` or `/transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxTransferSimulateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxTransferSimulateRequest = new SandboxTransferSimulateRequest(); // SandboxTransferSimulateRequest | 

            try
            {
                // Simulate a transfer event in Sandbox
                SandboxTransferSimulateResponse result = apiInstance.SandboxTransferSimulate(sandboxTransferSimulateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxTransferSimulate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxTransferSimulateRequest** | [**SandboxTransferSimulateRequest**](SandboxTransferSimulateRequest.md)|  | 

### Return type

[**SandboxTransferSimulateResponse**](SandboxTransferSimulateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxtransfersweepsimulate"></a>
# **SandboxTransferSweepSimulate**
> SandboxTransferSweepSimulateResponse SandboxTransferSweepSimulate (SandboxTransferSweepSimulateRequest sandboxTransferSweepSimulateRequest)

Simulate creating a sweep

Use the `/sandbox/transfer/sweep/simulate` endpoint to create a sweep and associated events in the Sandbox environment. Upon calling this endpoint, all `posted` or `pending` transfers with a sweep status of `unswept` will become `swept`, and all `reversed` transfers with a sweep status of `swept` will become `reverse_swept`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SandboxTransferSweepSimulateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var sandboxTransferSweepSimulateRequest = new SandboxTransferSweepSimulateRequest(); // SandboxTransferSweepSimulateRequest | 

            try
            {
                // Simulate creating a sweep
                SandboxTransferSweepSimulateResponse result = apiInstance.SandboxTransferSweepSimulate(sandboxTransferSweepSimulateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SandboxTransferSweepSimulate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sandboxTransferSweepSimulateRequest** | [**SandboxTransferSweepSimulateRequest**](SandboxTransferSweepSimulateRequest.md)|  | 

### Return type

[**SandboxTransferSweepSimulateResponse**](SandboxTransferSweepSimulateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaldecisionreport"></a>
# **SignalDecisionReport**
> SignalDecisionReportResponse SignalDecisionReport (SignalDecisionReportRequest signalDecisionReportRequest)

Report whether you initiated an ACH transaction

After calling `/signal/evaluate`, call `/signal/decision/report` to report whether the transaction was initiated. This endpoint will return an `INVALID_REQUEST` error if called a second time with a different value for `initiated`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SignalDecisionReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var signalDecisionReportRequest = new SignalDecisionReportRequest(); // SignalDecisionReportRequest | 

            try
            {
                // Report whether you initiated an ACH transaction
                SignalDecisionReportResponse result = apiInstance.SignalDecisionReport(signalDecisionReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SignalDecisionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signalDecisionReportRequest** | [**SignalDecisionReportRequest**](SignalDecisionReportRequest.md)|  | 

### Return type

[**SignalDecisionReportResponse**](SignalDecisionReportResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signalevaluate"></a>
# **SignalEvaluate**
> SignalEvaluateResponse SignalEvaluate (SignalEvaluateRequest signalEvaluateRequest)

Evaluate a planned ACH transaction

Use `/signal/evaluate` to evaluate a planned ACH transaction to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.  In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause. If `/signal/evaluate` is called on the same transaction multiple times within a 24-hour period, cached results may be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SignalEvaluateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var signalEvaluateRequest = new SignalEvaluateRequest(); // SignalEvaluateRequest | 

            try
            {
                // Evaluate a planned ACH transaction
                SignalEvaluateResponse result = apiInstance.SignalEvaluate(signalEvaluateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SignalEvaluate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signalEvaluateRequest** | [**SignalEvaluateRequest**](SignalEvaluateRequest.md)|  | 

### Return type

[**SignalEvaluateResponse**](SignalEvaluateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signalreturnreport"></a>
# **SignalReturnReport**
> SignalReturnReportResponse SignalReturnReport (SignalReturnReportRequest signalReturnReportRequest)

Report a return for an ACH transaction

Call the `/signal/return/report` endpoint to report a returned transaction that was previously sent to the `/signal/evaluate` endpoint. Your feedback will be used by the foo to incorporate the latest risk trend in your portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SignalReturnReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var signalReturnReportRequest = new SignalReturnReportRequest(); // SignalReturnReportRequest | 

            try
            {
                // Report a return for an ACH transaction
                SignalReturnReportResponse result = apiInstance.SignalReturnReport(signalReturnReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.SignalReturnReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signalReturnReportRequest** | [**SignalReturnReportRequest**](SignalReturnReportRequest.md)|  | 

### Return type

[**SignalReturnReportResponse**](SignalReturnReportResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsget"></a>
# **TransactionsGet**
> TransactionsGetResponse TransactionsGet (TransactionsGetRequest transactionsGetRequest)

Get transaction data

The `/transactions/get` endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype `student`; coverage may be limited). For transaction history from investments accounts, use the [Investments endpoint](https://plaid.com/docs/api/products#investments) instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.  Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/transactions/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).  Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the `count` and `offset` parameters in conjunction with the `total_transactions` response body field to fetch all available transactions.  Data returned by `/transactions/get` will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. An Item's `status.transactions.last_successful_update` field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the `/transactions/refresh` endpoint.  Note that data may not be immediately available to `/transactions/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `transactions`, or upon the first call to `/transactions/get`, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the [`INITIAL_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-initial_update) and [`HISTORICAL_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-historical_update) webhooks. If no transaction history is ready when `/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transactionsGetRequest = new TransactionsGetRequest(); // TransactionsGetRequest | 

            try
            {
                // Get transaction data
                TransactionsGetResponse result = apiInstance.TransactionsGet(transactionsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransactionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionsGetRequest** | [**TransactionsGetRequest**](TransactionsGetRequest.md)|  | 

### Return type

[**TransactionsGetResponse**](TransactionsGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsrecurringget"></a>
# **TransactionsRecurringGet**
> TransactionsRecurringGetResponse TransactionsRecurringGet (TransactionsRecurringGetRequest transactionsRecurringGetRequest)

Get streams of recurring transactions

The `/transactions/recurring/get` endpoint identifies and returns groups of transactions that occur on a regular basis for the inputted Item and accounts.  The product is currently in beta. To request access, contact transactions-feedback@plaid.com.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransactionsRecurringGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transactionsRecurringGetRequest = new TransactionsRecurringGetRequest(); // TransactionsRecurringGetRequest | 

            try
            {
                // Get streams of recurring transactions
                TransactionsRecurringGetResponse result = apiInstance.TransactionsRecurringGet(transactionsRecurringGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransactionsRecurringGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionsRecurringGetRequest** | [**TransactionsRecurringGetRequest**](TransactionsRecurringGetRequest.md)|  | 

### Return type

[**TransactionsRecurringGetResponse**](TransactionsRecurringGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsrefresh"></a>
# **TransactionsRefresh**
> TransactionsRefreshResponse TransactionsRefresh (TransactionsRefreshRequest transactionsRefreshRequest)

Refresh transaction data

`/transactions/refresh` is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur multiple times a day for any Transactions-enabled Item. If changes to transactions are discovered after calling `/transactions/refresh`, Plaid will fire a webhook: [`TRANSACTIONS_REMOVED`](https://plaid.com/docs/api/webhooks#deleted-transactions-detected) will be fired if any removed transactions are detected, and [`DEFAULT_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-default_update) will be fired if any new transactions are detected. New transactions can be fetched by calling `/transactions/get`.  Access to `/transactions/refresh` in Production is specific to certain pricing plans. If you cannot access `/transactions/refresh` in Production, [contact Sales](https://www.plaid.com/contact) for assistance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransactionsRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transactionsRefreshRequest = new TransactionsRefreshRequest(); // TransactionsRefreshRequest | 

            try
            {
                // Refresh transaction data
                TransactionsRefreshResponse result = apiInstance.TransactionsRefresh(transactionsRefreshRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransactionsRefresh: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionsRefreshRequest** | [**TransactionsRefreshRequest**](TransactionsRefreshRequest.md)|  | 

### Return type

[**TransactionsRefreshResponse**](TransactionsRefreshResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionssync"></a>
# **TransactionsSync**
> TransactionsSyncResponse TransactionsSync (TransactionsSyncRequest transactionsSyncRequest)

Get incremental transaction updates on an Item

The `/transactions/sync` endpoint returns item transactions as a set of delta updates. Subsequent calls to the endpoint using the cursor returned in the response will return new added, modified, and removed transactions since the last call to the endpoint  The product is currently in beta. To request access, contact transactions-feedback@plaid.com.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransactionsSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transactionsSyncRequest = new TransactionsSyncRequest(); // TransactionsSyncRequest | 

            try
            {
                // Get incremental transaction updates on an Item
                TransactionsSyncResponse result = apiInstance.TransactionsSync(transactionsSyncRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransactionsSync: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionsSyncRequest** | [**TransactionsSyncRequest**](TransactionsSyncRequest.md)|  | 

### Return type

[**TransactionsSyncResponse**](TransactionsSyncResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferauthorizationcreate"></a>
# **TransferAuthorizationCreate**
> TransferAuthorizationCreateResponse TransferAuthorizationCreate (TransferAuthorizationCreateRequest transferAuthorizationCreateRequest)

Create a transfer authorization

Use the `/transfer/authorization/create` endpoint to determine transfer failure risk.  In Plaid's sandbox environment the decisions will be returned as follows:    - To approve a transfer, make an authorization request with an `amount` less than the available balance in the account.    - To decline a transfer with the rationale code `NSF`, the available balance on the account must be less than the authorization `amount`. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.    - To decline a transfer with the rationale code `RISK`, the available balance on the account must be exactly $0. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.    - To permit a transfer with the rationale code `MANUALLY_VERIFIED_ITEM`, create an Item in Link through the [Same Day Micro-deposits flow](https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits).    - To permit a transfer with the rationale code `LOGIN_REQUIRED`, [reset the login for an Item](https://plaid.com/docs/sandbox/#item_login_required).  All username/password combinations other than the ones listed above will result in a decision of permitted and rationale code `ERROR`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferAuthorizationCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferAuthorizationCreateRequest = new TransferAuthorizationCreateRequest(); // TransferAuthorizationCreateRequest | 

            try
            {
                // Create a transfer authorization
                TransferAuthorizationCreateResponse result = apiInstance.TransferAuthorizationCreate(transferAuthorizationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferAuthorizationCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferAuthorizationCreateRequest** | [**TransferAuthorizationCreateRequest**](TransferAuthorizationCreateRequest.md)|  | 

### Return type

[**TransferAuthorizationCreateResponse**](TransferAuthorizationCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfercancel"></a>
# **TransferCancel**
> TransferCancelResponse TransferCancel (TransferCancelRequest transferCancelRequest)

Cancel a transfer

Use the `/transfer/cancel` endpoint to cancel a transfer.  A transfer is eligible for cancelation if the `cancellable` property returned by `/transfer/get` is `true`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferCancelRequest = new TransferCancelRequest(); // TransferCancelRequest | 

            try
            {
                // Cancel a transfer
                TransferCancelResponse result = apiInstance.TransferCancel(transferCancelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferCancelRequest** | [**TransferCancelRequest**](TransferCancelRequest.md)|  | 

### Return type

[**TransferCancelResponse**](TransferCancelResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfercreate"></a>
# **TransferCreate**
> TransferCreateResponse TransferCreate (TransferCreateRequest transferCreateRequest)

Create a transfer

Use the `/transfer/create` endpoint to initiate a new transfer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferCreateRequest = new TransferCreateRequest(); // TransferCreateRequest | 

            try
            {
                // Create a transfer
                TransferCreateResponse result = apiInstance.TransferCreate(transferCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferCreateRequest** | [**TransferCreateRequest**](TransferCreateRequest.md)|  | 

### Return type

[**TransferCreateResponse**](TransferCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfereventlist"></a>
# **TransferEventList**
> TransferEventListResponse TransferEventList (TransferEventListRequest transferEventListRequest)

List transfer events

Use the `/transfer/event/list` endpoint to get a list of transfer events based on specified filter criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferEventListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferEventListRequest = new TransferEventListRequest(); // TransferEventListRequest | 

            try
            {
                // List transfer events
                TransferEventListResponse result = apiInstance.TransferEventList(transferEventListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferEventList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferEventListRequest** | [**TransferEventListRequest**](TransferEventListRequest.md)|  | 

### Return type

[**TransferEventListResponse**](TransferEventListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfereventsync"></a>
# **TransferEventSync**
> TransferEventSyncResponse TransferEventSync (TransferEventSyncRequest transferEventSyncRequest)

Sync transfer events

`/transfer/event/sync` allows you to request up to the next 25 transfer events that happened after a specific `event_id`. Use the `/transfer/event/sync` endpoint to guarantee you have seen all transfer events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferEventSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferEventSyncRequest = new TransferEventSyncRequest(); // TransferEventSyncRequest | 

            try
            {
                // Sync transfer events
                TransferEventSyncResponse result = apiInstance.TransferEventSync(transferEventSyncRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferEventSync: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferEventSyncRequest** | [**TransferEventSyncRequest**](TransferEventSyncRequest.md)|  | 

### Return type

[**TransferEventSyncResponse**](TransferEventSyncResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferget"></a>
# **TransferGet**
> TransferGetResponse TransferGet (TransferGetRequest transferGetRequest)

Retrieve a transfer

The `/transfer/get` fetches information about the transfer corresponding to the given `transfer_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferGetRequest = new TransferGetRequest(); // TransferGetRequest | 

            try
            {
                // Retrieve a transfer
                TransferGetResponse result = apiInstance.TransferGet(transferGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferGetRequest** | [**TransferGetRequest**](TransferGetRequest.md)|  | 

### Return type

[**TransferGetResponse**](TransferGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferintentcreate"></a>
# **TransferIntentCreate**
> TransferIntentCreateResponse TransferIntentCreate (TransferIntentCreateRequest transferIntentCreateRequest)

Create a transfer intent object to invoke the Transfer UI

Use the `/transfer/intent/create` endpoint to generate a transfer intent object and invoke the Transfer UI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferIntentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferIntentCreateRequest = new TransferIntentCreateRequest(); // TransferIntentCreateRequest | 

            try
            {
                // Create a transfer intent object to invoke the Transfer UI
                TransferIntentCreateResponse result = apiInstance.TransferIntentCreate(transferIntentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferIntentCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferIntentCreateRequest** | [**TransferIntentCreateRequest**](TransferIntentCreateRequest.md)|  | 

### Return type

[**TransferIntentCreateResponse**](TransferIntentCreateResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferintentget"></a>
# **TransferIntentGet**
> TransferIntentGetResponse TransferIntentGet (Dictionary<string, Object> requestBody)

Retrieve more information about a transfer intent

Use the `/transfer/intent/get` endpoint to retrieve more information about a transfer intent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferIntentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                // Retrieve more information about a transfer intent
                TransferIntentGetResponse result = apiInstance.TransferIntentGet(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferIntentGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md)|  | 

### Return type

[**TransferIntentGetResponse**](TransferIntentGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferlist"></a>
# **TransferList**
> TransferListResponse TransferList (TransferListRequest transferListRequest)

List transfers

Use the `/transfer/list` endpoint to see a list of all your transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired transfers. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferListRequest = new TransferListRequest(); // TransferListRequest | 

            try
            {
                // List transfers
                TransferListResponse result = apiInstance.TransferList(transferListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferListRequest** | [**TransferListRequest**](TransferListRequest.md)|  | 

### Return type

[**TransferListResponse**](TransferListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferrepaymentlist"></a>
# **TransferRepaymentList**
> TransferRepaymentListResponse TransferRepaymentList (TransferRepaymentListRequest transferRepaymentListRequest)

Lists historical repayments

The `/transfer/repayment/list` endpoint fetches repayments matching the given filters. Repayments are returned in reverse-chronological order (most recent first) starting at the given `start_time`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferRepaymentListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferRepaymentListRequest = new TransferRepaymentListRequest(); // TransferRepaymentListRequest | 

            try
            {
                // Lists historical repayments
                TransferRepaymentListResponse result = apiInstance.TransferRepaymentList(transferRepaymentListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferRepaymentList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferRepaymentListRequest** | [**TransferRepaymentListRequest**](TransferRepaymentListRequest.md)|  | 

### Return type

[**TransferRepaymentListResponse**](TransferRepaymentListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferrepaymentreturnlist"></a>
# **TransferRepaymentReturnList**
> TransferRepaymentReturnListResponse TransferRepaymentReturnList (TransferRepaymentReturnListRequest transferRepaymentReturnListRequest)

List the returns included in a repayment

The `/transfer/repayment/return/list` endpoint retrieves the set of returns that were batched together into the specified repayment. The sum of amounts of returns retrieved by this request equals the amount of the repayment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferRepaymentReturnListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferRepaymentReturnListRequest = new TransferRepaymentReturnListRequest(); // TransferRepaymentReturnListRequest | 

            try
            {
                // List the returns included in a repayment
                TransferRepaymentReturnListResponse result = apiInstance.TransferRepaymentReturnList(transferRepaymentReturnListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferRepaymentReturnList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferRepaymentReturnListRequest** | [**TransferRepaymentReturnListRequest**](TransferRepaymentReturnListRequest.md)|  | 

### Return type

[**TransferRepaymentReturnListResponse**](TransferRepaymentReturnListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfersweepget"></a>
# **TransferSweepGet**
> TransferSweepGetResponse TransferSweepGet (TransferSweepGetRequest transferSweepGetRequest)

Retrieve a sweep

The `/transfer/sweep/get` endpoint fetches a sweep corresponding to the given `sweep_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferSweepGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferSweepGetRequest = new TransferSweepGetRequest(); // TransferSweepGetRequest | 

            try
            {
                // Retrieve a sweep
                TransferSweepGetResponse result = apiInstance.TransferSweepGet(transferSweepGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferSweepGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferSweepGetRequest** | [**TransferSweepGetRequest**](TransferSweepGetRequest.md)|  | 

### Return type

[**TransferSweepGetResponse**](TransferSweepGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfersweeplist"></a>
# **TransferSweepList**
> TransferSweepListResponse TransferSweepList (TransferSweepListRequest transferSweepListRequest)

List sweeps

The `/transfer/sweep/list` endpoint fetches sweeps matching the given filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferSweepListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var transferSweepListRequest = new TransferSweepListRequest(); // TransferSweepListRequest | 

            try
            {
                // List sweeps
                TransferSweepListResponse result = apiInstance.TransferSweepList(transferSweepListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.TransferSweepList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferSweepListRequest** | [**TransferSweepListRequest**](TransferSweepListRequest.md)|  | 

### Return type

[**TransferSweepListResponse**](TransferSweepListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletget"></a>
# **WalletGet**
> WalletGetResponse WalletGet (WalletGetRequest walletGetRequest)

Fetch an e-wallet

Fetch an e-wallet. The response includes the current balance. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var walletGetRequest = new WalletGetRequest(); // WalletGetRequest | 

            try
            {
                // Fetch an e-wallet
                WalletGetResponse result = apiInstance.WalletGet(walletGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.WalletGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **walletGetRequest** | [**WalletGetRequest**](WalletGetRequest.md)|  | 

### Return type

[**WalletGetResponse**](WalletGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactionexecute"></a>
# **WalletTransactionExecute**
> WalletTransactionExecuteResponse WalletTransactionExecute (WalletTransactionExecuteRequest walletTransactionExecuteRequest)

Execute a transaction using an e-wallet

Execute a transaction using the specified e-wallet. Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate payouts, the amount and reference for the payout. The payouts are executed over the Faster Payment rails, where settlement usually only takes a few seconds. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletTransactionExecuteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var walletTransactionExecuteRequest = new WalletTransactionExecuteRequest(); // WalletTransactionExecuteRequest | 

            try
            {
                // Execute a transaction using an e-wallet
                WalletTransactionExecuteResponse result = apiInstance.WalletTransactionExecute(walletTransactionExecuteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.WalletTransactionExecute: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **walletTransactionExecuteRequest** | [**WalletTransactionExecuteRequest**](WalletTransactionExecuteRequest.md)|  | 

### Return type

[**WalletTransactionExecuteResponse**](WalletTransactionExecuteResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactionslist"></a>
# **WalletTransactionsList**
> WalletTransactionsListResponse WalletTransactionsList (WalletTransactionsListRequest walletTransactionsListRequest)

List e-wallet transactions

This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the `created_at` time. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletTransactionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var walletTransactionsListRequest = new WalletTransactionsListRequest(); // WalletTransactionsListRequest | 

            try
            {
                // List e-wallet transactions
                WalletTransactionsListResponse result = apiInstance.WalletTransactionsList(walletTransactionsListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.WalletTransactionsList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **walletTransactionsListRequest** | [**WalletTransactionsListRequest**](WalletTransactionsListRequest.md)|  | 

### Return type

[**WalletTransactionsListResponse**](WalletTransactionsListResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookverificationkeyget"></a>
# **WebhookVerificationKeyGet**
> WebhookVerificationKeyGetResponse WebhookVerificationKeyGet (WebhookVerificationKeyGetRequest webhookVerificationKeyGetRequest)

Get webhook verification key

Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the `Plaid-Verification` header.  The `/webhook_verification_key/get` endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookVerificationKeyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://production.plaid.com";
            // Configure API key authorization: clientId
            config.AddApiKey("PLAID-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-CLIENT-ID", "Bearer");
            // Configure API key authorization: plaidVersion
            config.AddApiKey("Plaid-Version", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Plaid-Version", "Bearer");
            // Configure API key authorization: secret
            config.AddApiKey("PLAID-SECRET", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("PLAID-SECRET", "Bearer");

            var apiInstance = new PlaidApi(config);
            var webhookVerificationKeyGetRequest = new WebhookVerificationKeyGetRequest(); // WebhookVerificationKeyGetRequest | 

            try
            {
                // Get webhook verification key
                WebhookVerificationKeyGetResponse result = apiInstance.WebhookVerificationKeyGet(webhookVerificationKeyGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaidApi.WebhookVerificationKeyGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookVerificationKeyGetRequest** | [**WebhookVerificationKeyGetRequest**](WebhookVerificationKeyGetRequest.md)|  | 

### Return type

[**WebhookVerificationKeyGetResponse**](WebhookVerificationKeyGetResponse.md)

### Authorization

[clientId](../README.md#clientId), [plaidVersion](../README.md#plaidVersion), [secret](../README.md#secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

