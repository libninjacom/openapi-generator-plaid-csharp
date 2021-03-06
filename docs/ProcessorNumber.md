# Org.OpenAPITools.Model.ProcessorNumber
An object containing identifying numbers used for making electronic transfers to and from the `account`. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the `account` for which auth data has been requested, a null value will be returned.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ach** | [**NumbersACHNullable**](NumbersACHNullable.md) |  | [optional] 
**Eft** | [**NumbersEFTNullable**](NumbersEFTNullable.md) |  | [optional] 
**International** | [**NumbersInternationalNullable**](NumbersInternationalNullable.md) |  | [optional] 
**Bacs** | [**NumbersBACSNullable**](NumbersBACSNullable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

