# Org.OpenAPITools.Model.IncomeVerificationPrecheckRequest
IncomeVerificationPrecheckRequest defines the request schema for `/income/verification/precheck`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. | [optional] 
**Secret** | **string** | Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. | [optional] 
**User** | [**IncomeVerificationPrecheckUser**](IncomeVerificationPrecheckUser.md) |  | [optional] 
**Employer** | [**IncomeVerificationPrecheckEmployer**](IncomeVerificationPrecheckEmployer.md) |  | [optional] 
**TransactionsAccessToken** | **string** |  | [optional] 
**TransactionsAccessTokens** | **List&lt;string&gt;** | An array of access tokens corresponding to Items belonging to the user whose eligibility is being checked. Note that if the Items specified here are not already initialized with &#x60;transactions&#x60;, providing them in this field will cause these Items to be initialized with (and billed for) the Transactions product. | [optional] 
**UsMilitaryInfo** | [**IncomeVerificationPrecheckMilitaryInfo**](IncomeVerificationPrecheckMilitaryInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

