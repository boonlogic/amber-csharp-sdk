# BoonAmber.Model.GetConfigResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeatureCount** | **int?** | number of features per sample | 
**StreamingWindowSize** | **int?** | streaming window size | 
**Features** | [**List&lt;FeatureConfig&gt;**](FeatureConfig.md) |  | 
**PercentVariation** | **float?** | the percent variation (for instance, 0.025 gives 2.5% variation) used for clustering | 
**SamplesToBuffer** | [**decimal?**](BigDecimal.md) | the number of samples to be applied before autotuning begins | 
**PercentVariationOverride** | **float?** | override autotuned percent variation with this value | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

