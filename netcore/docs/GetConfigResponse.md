# BoonAmber.Model.GetConfigResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnomalyHistoryWindow** | **int** | the number of samples to use when calculating AH | [optional] 
**LearningRateNumerator** | **int** | enables graduation requirements for learning | [optional] 
**LearningRateDenominator** | **int** | enables graduation requirements for learning | [optional] 
**LearningMaxClusters** | **int** | learning graduation requirement for stopping learning upon reaching this cluster count | [optional] 
**LearningMaxSamples** | **int** | learning graduation requirement for stopping learning after acquiring this many samples | [optional] 
**FeatureCount** | **int** | number of features per sample | 
**StreamingWindowSize** | **int** | streaming window size | 
**Features** | [**List&lt;FeatureConfig&gt;**](FeatureConfig.md) |  | 
**PercentVariation** | **float** | the percent variation (for instance, 0.025 gives 2.5% variation) used for clustering | 
**SamplesToBuffer** | **int** | the number of samples to be applied before autotuning begins | 
**PercentVariationOverride** | **float** | override autotuned percent variation with this value | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

