# Org.OpenAPITools.Model.Numbers
Account and bank identifier number data used to configure the test account. All values are optional.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Will be used for the account number. | [optional] 
**AchRouting** | **string** | Must be a valid ACH routing number. | [optional] 
**AchWireRouting** | **string** | Must be a valid wire transfer routing number. | [optional] 
**EftInstitution** | **string** | EFT institution number. Must be specified alongside &#x60;eft_branch&#x60;. | [optional] 
**EftBranch** | **string** | EFT branch number. Must be specified alongside &#x60;eft_institution&#x60;. | [optional] 
**InternationalBic** | **string** | Bank identifier code (BIC). Must be specified alongside &#x60;international_iban&#x60;. | [optional] 
**InternationalIban** | **string** | International bank account number (IBAN). If no account number is specified via &#x60;account&#x60;, will also be used as the account number by default. Must be specified alongside &#x60;international_bic&#x60;. | [optional] 
**BacsSortCode** | **string** | BACS sort code | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

