# Org.OpenAPITools.Model.InstitutionStatus
The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Liabilities updates, Auth requests, Balance requests, Identity requests, Investments requests, and Liabilities requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return null rather than potentially inaccurate data.  Institution status is accessible in the Dashboard and via the API using the `/institutions/get_by_id` endpoint with the `include_status` option set to true. Note that institution status is not available in the Sandbox environment. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemLogins** | [**ProductStatus**](ProductStatus.md) |  | 
**TransactionsUpdates** | [**ProductStatus**](ProductStatus.md) |  | 
**Auth** | [**ProductStatus**](ProductStatus.md) |  | 
**Identity** | [**ProductStatus**](ProductStatus.md) |  | 
**InvestmentsUpdates** | [**ProductStatus**](ProductStatus.md) |  | 
**LiabilitiesUpdates** | [**ProductStatus**](ProductStatus.md) |  | [optional] 
**Liabilities** | [**ProductStatus**](ProductStatus.md) |  | [optional] 
**Investments** | [**ProductStatus**](ProductStatus.md) |  | [optional] 
**HealthIncidents** | [**List&lt;HealthIncident&gt;**](HealthIncident.md) | Details of recent health incidents associated with the institution. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

