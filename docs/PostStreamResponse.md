# BoonAmber.Model.PostStreamResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | state of the sensor, states will be prefixed with a state variable  followed by a colon followed by a message indicating progress.  Possible state variables  are: Not streaming, Buffering, Autotuning, Learning, Learning Complete, Monitoring,  Streaming error,  Autotuning error, Autotuning retry | 
**Message** | **string** | message to accompany the current state | 
**Progress** | **int** | completion percentage (applies to Buffering and Autotuning states) | 
**ClusterCount** | **int** | current cluster count (applies to Learning and Monitoring states) | 
**RetryCount** | **int** | number of restarts that have happened during autotuning | 
**StreamingWindowSize** | **int** | the current streaming window size that is being used | 
**TotalInferences** | **int** | inferences since the most recent restart | 
**RI** | [**Uint16Array**](Uint16Array.md) |  | 
**SI** | [**Uint16Array**](Uint16Array.md) |  | 
**AD** | [**Uint16Array**](Uint16Array.md) |  | 
**AH** | [**Uint16Array**](Uint16Array.md) |  | 
**AM** | [**Float32Array**](Float32Array.md) |  | 
**AW** | [**Uint16Array**](Uint16Array.md) |  | 
**ID** | [**Int32Array**](Int32Array.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

