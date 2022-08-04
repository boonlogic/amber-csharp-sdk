# BoonAmber.Model.PutStreamRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vector** | [**List&lt;PutStreamFeature&gt;**](PutStreamFeature.md) |  | 
**SubmitRule** | **string** | Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

