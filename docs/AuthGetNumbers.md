# Org.OpenAPITools.Model.AuthGetNumbers
An object containing identifying numbers used for making electronic transfers to and from the `accounts`. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any `accounts` for which data has been requested, the array for that type will be empty.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ach** | [**List&lt;NumbersACH&gt;**](NumbersACH.md) | An array of ACH numbers identifying accounts. | 
**Eft** | [**List&lt;NumbersEFT&gt;**](NumbersEFT.md) | An array of EFT numbers identifying accounts. | 
**International** | [**List&lt;NumbersInternational&gt;**](NumbersInternational.md) | An array of IBAN numbers identifying accounts. | 
**Bacs** | [**List&lt;NumbersBACS&gt;**](NumbersBACS.md) | An array of BACS numbers identifying accounts. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

