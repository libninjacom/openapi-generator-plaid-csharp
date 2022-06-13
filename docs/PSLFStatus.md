# Org.OpenAPITools.Model.PSLFStatus
Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is Fedloan (`ins_116527`). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EstimatedEligibilityDate** | **DateTime?** | The estimated date borrower will have completed 120 qualifying monthly payments. Returned in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). | 
**PaymentsMade** | **decimal?** | The number of qualifying payments that have been made. | 
**PaymentsRemaining** | **decimal?** | The number of qualifying payments remaining. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

