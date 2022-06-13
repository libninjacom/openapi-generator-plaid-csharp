# Org.OpenAPITools.Model.NumbersACH
Identifying information for transferring money to or from a US account via ACH or wire transfer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The Plaid account ID associated with the account numbers | 
**Account** | **string** | The ACH account number for the account.  Note that when using OAuth with Chase Bank (&#x60;ins_56&#x60;), Chase will issue \&quot;tokenized\&quot; routing and account numbers, which are not the user&#39;s actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the &#x60;mask&#x60; field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the &#x60;mask&#x60; rather than truncating the &#x60;account&#x60; number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals. | 
**Routing** | **string** | The ACH routing number for the account. If the institution is &#x60;ins_56&#x60;, this may be a tokenized routing number. For more information, see the description of the &#x60;account&#x60; field. | 
**WireRouting** | **string** | The wire transfer routing number for the account, if available | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

