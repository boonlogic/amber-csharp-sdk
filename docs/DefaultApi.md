# BoonAmber.Api.DefaultApi

All URIs are relative to *http://amber.boonlogic.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSensor**](DefaultApi.md#deletesensor) | **DELETE** /sensor | Delete a sensor instance
[**GetAmberSummary**](DefaultApi.md#getambersummary) | **GET** /__summary | Get the JSON block of the amber image
[**GetConfig**](DefaultApi.md#getconfig) | **GET** /config | Get the current configuration of a sensor instance
[**GetPretrain**](DefaultApi.md#getpretrain) | **GET** /pretrain | Get status of pretrain operation
[**GetRootCause**](DefaultApi.md#getrootcause) | **GET** /rootCause | Get root cause analysis information from a sensor
[**GetSensor**](DefaultApi.md#getsensor) | **GET** /sensor | Get basic information about a sensor instance
[**GetSensors**](DefaultApi.md#getsensors) | **GET** /sensors | List all sensors for this user
[**GetStatus**](DefaultApi.md#getstatus) | **GET** /status | Get analytic information from a sensor
[**GetVersion**](DefaultApi.md#getversion) | **GET** /version | Retrieves API version information
[**PostConfig**](DefaultApi.md#postconfig) | **POST** /config | Apply configuration to a sensor instance
[**PostOauth2**](DefaultApi.md#postoauth2) | **POST** /oauth2 | Request a bearer token using Amber account credentials
[**PostOutage**](DefaultApi.md#postoutage) | **POST** /outage | Informs the server of an outage
[**PostPretrain**](DefaultApi.md#postpretrain) | **POST** /pretrain | Pretrain a sensor using historical data
[**PostSensor**](DefaultApi.md#postsensor) | **POST** /sensor | Create a new a sensor instance
[**PostStream**](DefaultApi.md#poststream) | **POST** /stream | Stream data to a sensor
[**PutConfig**](DefaultApi.md#putconfig) | **PUT** /config | Update configuration for a sensor instance
[**PutSensor**](DefaultApi.md#putsensor) | **PUT** /sensor | Update label for a sensor instance
[**PutStream**](DefaultApi.md#putstream) | **PUT** /stream | Stream data to a sensor fusion vector

<a name="deletesensor"></a>
# **DeleteSensor**
> Error DeleteSensor (string sensorId)

Delete a sensor instance

Deletes the sensor instance with the specified sensorId.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class DeleteSensorExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Delete a sensor instance
                Error result = apiInstance.DeleteSensor(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSensor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**Error**](Error.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getambersummary"></a>
# **GetAmberSummary**
> GetSummaryResponse GetAmberSummary (string sensorId)

Get the JSON block of the amber image

Returns the json block of the amber sensor

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetAmberSummaryExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Get the JSON block of the amber image
                GetSummaryResponse result = apiInstance.GetAmberSummary(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAmberSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**GetSummaryResponse**](GetSummaryResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getconfig"></a>
# **GetConfig**
> GetConfigResponse GetConfig (string sensorId)

Get the current configuration of a sensor instance

Returns the current configuration of the sensor instance specified.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetConfigExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Get the current configuration of a sensor instance
                GetConfigResponse result = apiInstance.GetConfig(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**GetConfigResponse**](GetConfigResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpretrain"></a>
# **GetPretrain**
> GetPretrainResponse GetPretrain (string sensorId)

Get status of pretrain operation

Get status of a sensor which is currently pretraining.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetPretrainExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Get status of pretrain operation
                GetPretrainResponse result = apiInstance.GetPretrain(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPretrain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**GetPretrainResponse**](GetPretrainResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrootcause"></a>
# **GetRootCause**
> GetRootCauseResponse GetRootCause (string sensorId, string clusterID = null, string pattern = null)

Get root cause analysis information from a sensor

Returns analytic information on the root cause for the clusters provided.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetRootCauseExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor
            var clusterID = clusterID_example;  // string | An array of cluster IDs (optional) 
            var pattern = pattern_example;  // string | Patterns to compare to the nano model for the root cause analysis (optional) 

            try
            {
                // Get root cause analysis information from a sensor
                GetRootCauseResponse result = apiInstance.GetRootCause(sensorId, clusterID, pattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRootCause: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 
 **clusterID** | **string**| An array of cluster IDs | [optional] 
 **pattern** | **string**| Patterns to compare to the nano model for the root cause analysis | [optional] 

### Return type

[**GetRootCauseResponse**](GetRootCauseResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsensor"></a>
# **GetSensor**
> GetSensorResponse GetSensor (string sensorId)

Get basic information about a sensor instance

Returns basic information about an existing sensor instance.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetSensorExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Get basic information about a sensor instance
                GetSensorResponse result = apiInstance.GetSensor(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSensor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**GetSensorResponse**](GetSensorResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsensors"></a>
# **GetSensors**
> GetSensorsResponse GetSensors ()

List all sensors for this user

Returns a list of all current sensor instances for this user.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetSensorsExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // List all sensors for this user
                GetSensorsResponse result = apiInstance.GetSensors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSensors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSensorsResponse**](GetSensorsResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatus"></a>
# **GetStatus**
> GetStatusResponse GetStatus (string sensorId)

Get analytic information from a sensor

Returns analytic information derived from data processed by a sensor thus far.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Get analytic information from a sensor
                GetStatusResponse result = apiInstance.GetStatus(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**GetStatusResponse**](GetStatusResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getversion"></a>
# **GetVersion**
> Version GetVersion ()

Retrieves API version information

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class GetVersionExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Retrieves API version information
                Version result = apiInstance.GetVersion();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Version**](Version.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postconfig"></a>
# **PostConfig**
> PostConfigResponse PostConfig (PostConfigRequest body, string sensorId)

Apply configuration to a sensor instance

Applies the provided configuration to the sensor instance specified.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostConfigExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PostConfigRequest(); // PostConfigRequest | Sensor configuration to be applied
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Apply configuration to a sensor instance
                PostConfigResponse result = apiInstance.PostConfig(body, sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostConfigRequest**](PostConfigRequest.md)| Sensor configuration to be applied | 
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PostConfigResponse**](PostConfigResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postoauth2"></a>
# **PostOauth2**
> PostAuth2Response PostOauth2 (PostAuth2Request body)

Request a bearer token using Amber account credentials

Requests a bearer token using Amber account credentials. The requested bearer token is returned as the \"id-token\" response attribute. This token is to be used for authenticating API requests throughout a usage session and expires after 60 minutes.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostOauth2Example
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new PostAuth2Request(); // PostAuth2Request | Account credentials to be used for authentication

            try
            {
                // Request a bearer token using Amber account credentials
                PostAuth2Response result = apiInstance.PostOauth2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostOauth2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostAuth2Request**](PostAuth2Request.md)| Account credentials to be used for authentication | 

### Return type

[**PostAuth2Response**](PostAuth2Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postoutage"></a>
# **PostOutage**
> PostOutageResponse PostOutage (string sensorId)

Informs the server of an outage

Clears the load buffer of streaming window and resets statistics. Returns stream status

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostOutageExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Informs the server of an outage
                PostOutageResponse result = apiInstance.PostOutage(sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostOutage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PostOutageResponse**](PostOutageResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postpretrain"></a>
# **PostPretrain**
> PostPretrainResponse PostPretrain (PostPretrainRequest body, string sensorId, string amberChunk = null, string amberTransaction = null)

Pretrain a sensor using historical data

Pretrains a sensor. Ingoing data should be formatted as a simple string of comma-separated numbers with no spaces.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostPretrainExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PostPretrainRequest(); // PostPretrainRequest | Data to be streamed to sensor. Should be formatted as a simple string of comma-separated numbers with no spaces (e.g. "0,0.5,1,1.5,2").
            var sensorId = sensorId_example;  // string | Unique identifier for sensor
            var amberChunk = amberChunk_example;  // string | Specification of chunk, 1:3 2:3 3:3 for example (optional) 
            var amberTransaction = amberTransaction_example;  // string | Unique identifier for chunk transactions (optional) 

            try
            {
                // Pretrain a sensor using historical data
                PostPretrainResponse result = apiInstance.PostPretrain(body, sensorId, amberChunk, amberTransaction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostPretrain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostPretrainRequest**](PostPretrainRequest.md)| Data to be streamed to sensor. Should be formatted as a simple string of comma-separated numbers with no spaces (e.g. &quot;0,0.5,1,1.5,2&quot;). | 
 **sensorId** | **string**| Unique identifier for sensor | 
 **amberChunk** | **string**| Specification of chunk, 1:3 2:3 3:3 for example | [optional] 
 **amberTransaction** | **string**| Unique identifier for chunk transactions | [optional] 

### Return type

[**PostPretrainResponse**](PostPretrainResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsensor"></a>
# **PostSensor**
> PostSensorResponse PostSensor (PostSensorRequest body)

Create a new a sensor instance

Spawns a new sensor instance, returning its unique sensorId.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostSensorExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PostSensorRequest(); // PostSensorRequest | Label for new sensor instance to be created

            try
            {
                // Create a new a sensor instance
                PostSensorResponse result = apiInstance.PostSensor(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostSensor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostSensorRequest**](PostSensorRequest.md)| Label for new sensor instance to be created | 

### Return type

[**PostSensorResponse**](PostSensorResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="poststream"></a>
# **PostStream**
> PostStreamResponse PostStream (PostStreamRequest body, string sensorId)

Stream data to a sensor

Sends data to a sensor. Ingoing data should be formatted as a simple string of comma-separated numbers with no spaces.  The following analytic results are returned: - state : sensor state as of this call (one of: \"Buffering\", \"Autotuning\", \"Learning\", \"Monitoring\", \"Error\") - ID : array of cluster IDs. These correspond one-to-one with input samples, indicating the cluster to which each input pattern was assigned. - SI : array of smoothed anomaly index values. These values correspond one-to-one with the input samples and range between 0 and 1000. Values closer to 0 represent input patterns which are ordinary given the data seen so far on this sensor. Values closer to 1000 represent novel patterns which are anomalous with respect to data seen before. - AD : array of 0's and 1's as anomaly detection indicators. These correspond one-to-one with input samples and are produced by thresholding the smoothed anomaly index (SI). The threshold is determined automatically from the SI values. A value of 0 indicates that the SI has not exceeded the anomaly detection threshold. A value of 1 indicates it has, signaling an anomaly at the corresponding input sample. - AH : array of anomaly history values. These values are a moving-window sum of the AD, giving the number of anomaly detections (1's) present in the AD signal over a \"recent history\" window whose length is the buffer size. - AM : array of Amber Metric values. These are floating-point values between 0.0 and 1.0 indicating the extent to which the AH contains an unusually high number of anomalies in recent history. The values are derived statistically from a Poisson model, with values close to 0.0 signaling a lower, and values close to 1.0 signaling a higher, frequency of anomalies than usual. - AW : array of Amber Warning Level values. This index is produced by thresholding the Amber Metric (AM) and takes on the values 0, 1 or 2 representing a discrete \"warning level\" for an asset based on the frequency of anomalies within recent history. 0 = normal, 1 = asset changing, 2 = asset critical. The default thresholds for the two warning levels are the standard statistical values of 0.95 (outlier, asset changing) and 0.997 (extreme outlier, asset critical).

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PostStreamExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PostStreamRequest(); // PostStreamRequest | Data to be streamed to sensor. Should be formatted as a simple string of comma-separated numbers with no spaces (e.g. "0,0.5,1,1.5,2").
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Stream data to a sensor
                PostStreamResponse result = apiInstance.PostStream(body, sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostStreamRequest**](PostStreamRequest.md)| Data to be streamed to sensor. Should be formatted as a simple string of comma-separated numbers with no spaces (e.g. &quot;0,0.5,1,1.5,2&quot;). | 
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PostStreamResponse**](PostStreamResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putconfig"></a>
# **PutConfig**
> PutConfigResponse PutConfig (PutConfigRequest body, string sensorId)

Update configuration for a sensor instance

Updates the configuration for the sensor instance specified.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PutConfigExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PutConfigRequest(); // PutConfigRequest | Updates to sensor configuration
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Update configuration for a sensor instance
                PutConfigResponse result = apiInstance.PutConfig(body, sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PutConfigRequest**](PutConfigRequest.md)| Updates to sensor configuration | 
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PutConfigResponse**](PutConfigResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsensor"></a>
# **PutSensor**
> PutSensorResponse PutSensor (PutSensorRequest body, string sensorId)

Update label for a sensor instance

Changes the label of an existing sensor instance to the new label specified.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PutSensorExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PutSensorRequest(); // PutSensorRequest | New label to apply to sensor instance
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Update label for a sensor instance
                PutSensorResponse result = apiInstance.PutSensor(body, sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutSensor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PutSensorRequest**](PutSensorRequest.md)| New label to apply to sensor instance | 
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PutSensorResponse**](PutSensorResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putstream"></a>
# **PutStream**
> PutStreamResponse PutStream (PutStreamRequest body, string sensorId)

Stream data to a sensor fusion vector

Update fusion vector with new values for the given features, and optionally submit to Amber. Analytic results returned are the same as POST /stream.

### Example
```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class PutStreamExample
    {
        public void main()
        {
            // Configure API key authorization: authorize-amber-pool
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new PutStreamRequest(); // PutStreamRequest | New values for sensor fusion vector.
            var sensorId = sensorId_example;  // string | Unique identifier for sensor

            try
            {
                // Stream data to a sensor fusion vector
                PutStreamResponse result = apiInstance.PutStream(body, sensorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PutStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PutStreamRequest**](PutStreamRequest.md)| New values for sensor fusion vector. | 
 **sensorId** | **string**| Unique identifier for sensor | 

### Return type

[**PutStreamResponse**](PutStreamResponse.md)

### Authorization

[authorize-amber-pool](../README.md#authorize-amber-pool)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
