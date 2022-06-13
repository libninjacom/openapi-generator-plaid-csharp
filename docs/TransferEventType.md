# Org.OpenAPITools.Model.TransferEventType
The type of event that this transfer represents.  `pending`: A new transfer was created; it is in the pending state.  `cancelled`: The transfer was cancelled by the client.  `failed`: The transfer failed, no funds were moved.  `posted`: The transfer has been successfully submitted to the payment network.  `reversed`: A posted transfer was reversed.  `swept`: The transfer was swept to / from the sweep account.  `reverse_swept`: Due to the transfer reversing, funds were pulled from or pushed back to the sweep account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

