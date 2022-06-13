# Org.OpenAPITools.Model.TransferSweep
Describes a sweep of funds to / from the sweep account.  A sweep is associated with many sweep events (events of type `swept` or `reverse_swept`) which can be retrieved by invoking the `/transfer/event/list` endpoint with the corresponding `sweep_id`.  `swept` events occur when the transfer amount is credited or debited from your sweep account, depending on the `type` of the transfer. `reverse_swept` events occur when a transfer is reversed and Plaid undoes the credit or debit.  The total sum of the `swept` and `reverse_swept` events is equal to the `amount` of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of the sweep. | 
**Created** | **DateTime** | The datetime when the sweep occurred, in RFC 3339 format. | 
**Amount** | **string** | Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. \&quot;-10.00\&quot;)  If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced. | 
**IsoCurrencyCode** | **string** | The currency of the sweep, e.g. \&quot;USD\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

