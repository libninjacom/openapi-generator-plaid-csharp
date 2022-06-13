# Org.OpenAPITools.Model.SimulatedTransferSweep
A sweep returned from the `/sandbox/transfer/sweep/simulate` endpoint. Can be null if there are no transfers to include in a sweep.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of the sweep. | 
**Created** | **DateTime** | The datetime when the sweep occurred, in RFC 3339 format. | 
**Amount** | **string** | Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. \&quot;-10.00\&quot;)  If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced. | 
**IsoCurrencyCode** | **string** | The currency of the sweep, e.g. \&quot;USD\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

