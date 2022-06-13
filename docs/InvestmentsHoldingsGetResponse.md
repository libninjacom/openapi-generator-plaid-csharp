# Org.OpenAPITools.Model.InvestmentsHoldingsGetResponse
InvestmentsHoldingsGetResponse defines the response schema for `/investments/holdings/get`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accounts** | [**List&lt;AccountBase&gt;**](AccountBase.md) | The accounts associated with the Item | 
**Holdings** | [**List&lt;Holding&gt;**](Holding.md) | The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the &#x60;securities&#x60; field.  | 
**Securities** | [**List&lt;Security&gt;**](Security.md) | Objects describing the securities held in the accounts associated with the Item.  | 
**Item** | [**Item**](Item.md) |  | 
**RequestId** | **string** | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

