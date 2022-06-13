# Org.OpenAPITools.Model.OwnerOverride
Data about the owner or owners of an account. Any fields not specified will be filled in with default Sandbox information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Names** | **List&lt;string&gt;** | A list of names associated with the account by the financial institution. These should always be the names of individuals, even for business accounts. Note that the same name data will be used for all accounts associated with an Item. | 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) | A list of phone numbers associated with the account. | 
**Emails** | [**List&lt;Email&gt;**](Email.md) | A list of email addresses associated with the account. | 
**Addresses** | [**List&lt;Address&gt;**](Address.md) | Data about the various addresses associated with the account. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

