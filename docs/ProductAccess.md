# Org.OpenAPITools.Model.ProductAccess
The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Statements** | **bool?** | Allow access to statements. Only used by certain partners. If relevant to the partner and unset, defaults to &#x60;true&#x60;. | [optional] [default to true]
**Identity** | **bool?** | Allow access to the Identity product (name, email, phone, address). Only used by certain partners. If relevant to the partner and unset, defaults to &#x60;true&#x60;. | [optional] [default to true]
**Auth** | **bool?** | Allow access to account number details. Only used by certain partners. If relevant to the partner and unset, defaults to &#x60;true&#x60;. | [optional] [default to true]
**Transactions** | **bool?** | Allow access to transaction details. Only used by certain partners. If relevant to the partner and unset, defaults to &#x60;true&#x60;. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

