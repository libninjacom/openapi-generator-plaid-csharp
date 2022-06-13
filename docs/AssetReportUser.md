# Org.OpenAPITools.Model.AssetReportUser
The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The `first_name`, `last_name`, and `ssn` fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientUserId** | **string** | An identifier you determine and submit for the user. | [optional] 
**FirstName** | **string** | The user&#39;s first name. Required for the Fannie Mae Day 1 Certainty™ program. | [optional] 
**MiddleName** | **string** | The user&#39;s middle name | [optional] 
**LastName** | **string** | The user&#39;s last name.  Required for the Fannie Mae Day 1 Certainty™ program. | [optional] 
**Ssn** | **string** | The user&#39;s Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.  Format: \&quot;ddd-dd-dddd\&quot; | [optional] 
**PhoneNumber** | **string** | The user&#39;s phone number, in E.164 format: +{countrycode}{number}. For example: \&quot;+14151234567\&quot;. Phone numbers provided in other formats will be parsed on a best-effort basis. | [optional] 
**Email** | **string** | The user&#39;s email address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

