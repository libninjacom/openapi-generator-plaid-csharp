# Org.OpenAPITools.Model.PaymentMeta
Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be `null`.  If the `transactions` object was returned by a Transactions endpoint such as `/transactions/get`, the `payment_meta` key will always appear, but no data elements are guaranteed. If the `transactions` object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceNumber** | **string** | The transaction reference number supplied by the financial institution. | 
**PpdId** | **string** | The ACH PPD ID for the payer. | 
**Payee** | **string** | For transfers, the party that is receiving the transaction. | 
**ByOrderOf** | **string** | The party initiating a wire transfer. Will be &#x60;null&#x60; if the transaction is not a wire transfer. | 
**Payer** | **string** | For transfers, the party that is paying the transaction. | 
**PaymentMethod** | **string** | The type of transfer, e.g. &#39;ACH&#39; | 
**PaymentProcessor** | **string** | The name of the payment processor | 
**Reason** | **string** | The payer-supplied description of the transfer. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

