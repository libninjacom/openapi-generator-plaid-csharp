# Org.OpenAPITools.Model.MortgageLiability
Contains details about a mortgage account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The ID of the account that this liability belongs to. | 
**AccountNumber** | **string** | The account number of the loan. | 
**CurrentLateFee** | **decimal?** | The current outstanding amount charged for late payment. | 
**EscrowBalance** | **decimal?** | Total amount held in escrow to pay taxes and insurance on behalf of the borrower. | 
**HasPmi** | **bool?** | Indicates whether the borrower has private mortgage insurance in effect. | 
**HasPrepaymentPenalty** | **bool?** | Indicates whether the borrower will pay a penalty for early payoff of mortgage. | 
**InterestRate** | [**MortgageInterestRate**](MortgageInterestRate.md) |  | 
**LastPaymentAmount** | **decimal?** | The amount of the last payment. | 
**LastPaymentDate** | **DateTime?** | The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**LoanTypeDescription** | **string** | Description of the type of loan, for example &#x60;conventional&#x60;, &#x60;fixed&#x60;, or &#x60;variable&#x60;. This field is provided directly from the loan servicer and does not have an enumerated set of possible values. | 
**LoanTerm** | **string** | Full duration of mortgage as at origination (e.g. &#x60;10 year&#x60;). | 
**MaturityDate** | **DateTime?** | Original date on which mortgage is due in full. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**NextMonthlyPayment** | **decimal?** | The amount of the next payment. | 
**NextPaymentDueDate** | **DateTime?** | The due date for the next payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**OriginationDate** | **DateTime?** | The date on which the loan was initially lent. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**OriginationPrincipalAmount** | **decimal?** | The original principal balance of the mortgage. | 
**PastDueAmount** | **decimal?** | Amount of loan (principal + interest) past due for payment. | 
**PropertyAddress** | [**MortgagePropertyAddress**](MortgagePropertyAddress.md) |  | 
**YtdInterestPaid** | **decimal?** | The year to date (YTD) interest paid. | 
**YtdPrincipalPaid** | **decimal?** | The YTD principal paid. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

