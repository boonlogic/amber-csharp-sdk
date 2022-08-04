# BoonAmber.Model.FeatureConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxVal** | **float?** | corresponding maximum value | [optional] 
**MinVal** | **float?** | the value that should be considered the minimum value for this feature. This can be set to a value larger than the actual min if you want to treat all value less than that as the same (for instance, to keep a noise spike from having undue influence in the clustering | [optional] 
**Weight** | **int?** | corresponding weight | [optional] 
**Label** | **string** | label associated with feature | [optional] 
**SubmitRule** | **string** | policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

