# BoonAmber.Model.GetStatusResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pca** | [**PCA**](PCA.md) |  | 
**ClusterGrowth** | [**Uint64Array**](Uint64Array.md) |  | 
**ClusterSizes** | [**Uint64Array**](Uint64Array.md) |  | 
**AnomalyIndexes** | [**Uint16Array**](Uint16Array.md) |  | 
**FrequencyIndexes** | [**Uint16Array**](Uint16Array.md) |  | 
**DistanceIndexes** | [**Uint16Array**](Uint16Array.md) |  | 
**TotalInferences** | [**decimal?**](BigDecimal.md) | inferences since the most recent restart | 
**NumClusters** | [**decimal?**](BigDecimal.md) |  | 
**AnomalyThreshold** | **int?** |  | 
**State** | **string** | state of the sensor. Possible state variables are: Error, Buffering, Autotuning, Learning, Monitoring | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

