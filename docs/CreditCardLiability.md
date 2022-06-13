# Org.OpenAPITools.Model.CreditCardLiability
An object representing a credit card account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The ID of the account that this liability belongs to. | 
**Aprs** | [**List&lt;APR&gt;**](APR.md) | The various interest rates that apply to the account. | 
**IsOverdue** | **bool?** | true if a payment is currently overdue. Availability for this field is limited. | 
**LastPaymentAmount** | **decimal** | The amount of the last payment. | 
**LastPaymentDate** | **DateTime?** | The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). Availability for this field is limited. | 
**LastStatementIssueDate** | **DateTime** | The date of the last statement. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**LastStatementBalance** | **decimal** | The total amount owed as of the last statement issued | 
**MinimumPaymentAmount** | **decimal** | The minimum payment due for the next billing cycle. | 
**NextPaymentDueDate** | **DateTime?** | The due date for the next payment. The due date is &#x60;null&#x60; if a payment is not expected. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

