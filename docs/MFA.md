# Org.OpenAPITools.Model.MFA
Specifies the multi-factor authentication settings to use with this test account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Possible values are &#x60;device&#x60;, &#x60;selections&#x60;, or &#x60;questions&#x60;.  If value is &#x60;device&#x60;, the MFA answer is &#x60;1234&#x60;.  If value is &#x60;selections&#x60;, the MFA answer is always the first option.  If value is &#x60;questions&#x60;, the MFA answer is  &#x60;answer_&lt;i&gt;_&lt;j&gt;&#x60; for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is &#x60;answer_1_0&#x60;. | 
**QuestionRounds** | **decimal** | Number of rounds of questions. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;.  | 
**QuestionsPerRound** | **decimal** | Number of questions per round. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. If value of type is &#x60;selections&#x60;, default value is 2. | 
**SelectionRounds** | **decimal** | Number of rounds of selections, used if &#x60;type&#x60; is &#x60;selections&#x60;. Defaults to 1. | 
**SelectionsPerQuestion** | **decimal** | Number of available answers per question, used if &#x60;type&#x60; is &#x60;selection&#x60;. Defaults to 2.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

