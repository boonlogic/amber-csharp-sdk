# BoonAmber.Model.PostConfigRequest

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
**Features** | [**List&lt;FeatureConfig&gt;**](FeatureConfig.md) |  | [optional] 
**SamplesToBuffer** | **int** | the number of samples to be applied before autotuning begins | [optional] 
**PercentVariationOverride** | **float** | override autotuned percent variation with this value | [optional] [default to -1.0F]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

