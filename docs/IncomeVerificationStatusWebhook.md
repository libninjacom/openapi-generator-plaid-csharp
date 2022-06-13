# Org.OpenAPITools.Model.IncomeVerificationStatusWebhook
Fired when the status of an income verification instance has changed. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookType** | **string** | &#x60;\&quot;INCOME\&quot;&#x60; | 
**WebhookCode** | **string** | &#x60;income_verification&#x60; | 
**IncomeVerificationId** | **string** | The &#x60;income_verification_id&#x60; of the verification instance whose status is being reported. | 
**ItemId** | **string** | The Item ID associated with the verification. | 
**VerificationStatus** | **string** | &#x60;VERIFICATION_STATUS_PROCESSING_COMPLETE&#x60;: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the &#x60;/income/verification/paystubs/get&#x60; endpoint and check the document metadata to see which documents were successfully parsed.  &#x60;VERIFICATION_STATUS_PROCESSING_FAILED&#x60;: A failure occurred when attempting to process the verification documentation.  &#x60;VERIFICATION_STATUS_PENDING_APPROVAL&#x60;: The income verification has been sent to the user for review. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

