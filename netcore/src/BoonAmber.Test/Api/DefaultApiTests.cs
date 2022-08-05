/*
 * Amber API Server
 *
 * Boon Logic Amber API Server
 *
 * The version of the OpenAPI document: 1.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using BoonAmber.Client;
using BoonAmber.Api;
using BoonAmber.Model;

namespace BoonAmber.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        private void RestoreEnvironment(){
            //Set the Amber License Info
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "admin");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "admin");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://127.0.0.1/v1");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "https://127.0.0.1/v1");
        }

        public DefaultApiTests()
        {
            RestoreEnvironment();

            instance = new DefaultApi("", "", false, 300000);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // test 'IsType' DefaultApi
            Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test authentication methods
        /// </summary>
        [Fact]
        public void AuthenticatationTest()
        {
            // Test with the good instance
            var body = new PostAuth2Request(instance.username, instance.password);
            var response = instance.PostOauth2(body);

            // Check Token and Expiration
            Assert.False(string.IsNullOrEmpty(response.IdToken));
            Assert.False(string.IsNullOrEmpty(response.ExpiresIn));

            //License File
            string test_license_path = Environment.GetEnvironmentVariable("TEST_LICENSE_FILE");
            if (string.IsNullOrEmpty(test_license_path)){
                test_license_path = "../test.Amber.license";
            }

            // Test With license file
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "");
            var instance2 = new DefaultApi("default", test_license_path, true, 300000);
            Assert.Equal("admin", instance2.username);
            Assert.Equal("admin", instance2.password);
            Assert.Equal("https://localhost:5007/v1", instance2.server);
            Assert.Equal("https://localhost:5007/v1", instance2.oauth_server);

            // override items in license file through environment
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "xyyyAmberUser");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "bogus_password");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://temp.amber.boonlogic.com/v1");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "https://auth.amber.boonlogic.com/v1");
            var instance3 = new DefaultApi("default", test_license_path, true, 300000);
            Assert.Equal("xyyyAmberUser", instance3.username);
            Assert.Equal("bogus_password", instance3.password);
            Assert.Equal("https://temp.amber.boonlogic.com/v1", instance3.server);
            Assert.Equal("https://auth.amber.boonlogic.com/v1", instance3.oauth_server);

            //test auth with garbage credentials
            var instance4 = new DefaultApi("garbage", test_license_path, true, 300000);
            var body4 = new PostAuth2Request(instance4.username, instance4.password);
            try {
                instance4.PostOauth2(body4); // should except
                Assert.True(false, "Authorization with bad credentials should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }
        }

        /// <summary>
        /// Test PostSensor and DeleteSensor
        /// </summary>
        [Fact]
        public void PostSensorTest()
        {
            //create sensor 
            var postSensorRequest = new PostSensorRequest("test_sensor_1");
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsType<PostSensorResponse>(post_response);
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test PutSensor
        /// </summary>
        [Fact]
        public void UpdateLabelTest(){
            //create sensor 
            var postSensorRequest = new PostSensorRequest("test_sensor_2");
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsType<PostSensorResponse>(post_response);
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //update
            string newlabel = "test_sensor_2_updated";
            var putSensorRequest = new PutSensorRequest(newlabel);
            var put_response = instance.PutSensor(post_response.SensorId, putSensorRequest);
            Assert.IsType<PutSensorResponse>(put_response);
            Assert.False(string.IsNullOrEmpty(put_response.SensorId));
            Assert.Equal(newlabel, put_response.Label);

            //delete sensor
            var delete_response = instance.DeleteSensor(put_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test PutSensor Negative
        /// </summary>
        [Fact]
        public void UpdateLabelTestNegative(){
            //update
            var putSensorRequest = new PutSensorRequest("test_sensor_garbage");
             try {
                var put_response = instance.PutSensor("nonexistent-sensor-id", putSensorRequest); // should throw
                Assert.True(false, "Update with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }
        }

        /// <summary>
        /// Test GetSensor
        /// </summary>
        [Fact]
        public void GetSensorTest()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsType<PostSensorResponse>(post_response);
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //get sensor 
            var get_response = instance.GetSensor(post_response.SensorId);
            Assert.IsType<GetSensorResponse>(get_response);
            Assert.False(string.IsNullOrEmpty(get_response.Label));
            Assert.Equal(label, get_response.Label);

            //delete sensor
            var delete_response = instance.DeleteSensor(get_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test GetSensor Negative
        /// </summary>
        [Fact]
        public void GetSensorTestNegative(){

            try {
                var get_response = instance.GetSensor("nonexistent-sensor-id"); // should throw
                Assert.True(false, "GetSensor with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }
            
        }

        /// <summary>
        /// Test GetSensors
        /// </summary>
        [Fact]
        public void ListSensorTest()
        {
            //create sensors
            string[] labels = { "test_sensor_1", "test_sensor_2", "test_sensor_3" };
            foreach (string label in labels)
            {
                var postSensorRequest = new PostSensorRequest(label);
                var post_response = instance.PostSensor(postSensorRequest);
                Assert.IsType<PostSensorResponse>(post_response);
                Assert.False(string.IsNullOrEmpty(post_response.SensorId));
            } 

            
            //get sensor 
            var get_response = instance.GetSensors();
            Assert.IsType<GetSensorsResponse>(get_response);
            Assert.True(get_response.Count >= 3, "Expected #sensors to be greater than or euqal to 3.");

            //delete sensor
            foreach (SensorInstance sensor in get_response)
            {
                var delete_response = instance.DeleteSensor(sensor.SensorId);
                Assert.IsType<Error>(delete_response);
            } 
        }

        /// <summary>
        /// Test PostConfig and GetConfig
        /// </summary>
        [Fact]
        public void PostConfigTest()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsType<PostSensorResponse>(post_response);
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            // configure sensor with custom features
            List<FeatureConfig> features = new List<FeatureConfig>{ new FeatureConfig(50, 1, 1, "fancy-label", FeatureConfig.SubmitRuleEnum.Submit) };


            var postConfigRequest = new PostConfigRequest(anomalyHistoryWindow: 1000, 
                                                    learningRateNumerator: 10, 
                                                    learningRateDenominator: 10000, 
                                                    learningMaxClusters: 1000, 
                                                    learningMaxSamples: 10000000, 
                                                    featureCount: 1, 
                                                    streamingWindowSize: 25,
                                                    features: features, 
                                                    samplesToBuffer: 1000
                                                );

            //Post it
            var config_response = instance.PostConfig(post_response.SensorId, postConfigRequest);
            Assert.Equal(postConfigRequest.FeatureCount, config_response.FeatureCount);
            Assert.Equal(postConfigRequest.StreamingWindowSize, config_response.StreamingWindowSize);
            Assert.Equal(postConfigRequest.AnomalyHistoryWindow, config_response.AnomalyHistoryWindow);
            Assert.Equal(postConfigRequest.LearningRateNumerator, config_response.LearningRateNumerator);
            Assert.Equal(postConfigRequest.LearningRateDenominator, config_response.LearningRateDenominator);
            Assert.Equal(postConfigRequest.LearningMaxClusters, config_response.LearningMaxClusters);
            Assert.Equal(postConfigRequest.LearningMaxSamples, config_response.LearningMaxSamples);
            Assert.Equal(postConfigRequest.SamplesToBuffer, config_response.SamplesToBuffer);

            //Get the config
            var get_config_response = instance.GetConfig(post_response.SensorId);
            Assert.IsType<GetConfigResponse>(get_config_response);
            Assert.Equal(postConfigRequest.FeatureCount, get_config_response.FeatureCount);
            Assert.Equal(postConfigRequest.StreamingWindowSize, get_config_response.StreamingWindowSize);
            Assert.Equal(postConfigRequest.AnomalyHistoryWindow, get_config_response.AnomalyHistoryWindow);
            Assert.Equal(postConfigRequest.LearningRateNumerator, get_config_response.LearningRateNumerator);
            Assert.Equal(postConfigRequest.LearningRateDenominator, get_config_response.LearningRateDenominator);
            Assert.Equal(postConfigRequest.LearningMaxClusters, get_config_response.LearningMaxClusters);
            Assert.Equal(postConfigRequest.LearningMaxSamples, get_config_response.LearningMaxSamples);
            Assert.Equal(postConfigRequest.SamplesToBuffer, get_config_response.SamplesToBuffer);

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test PostConfig with invalid configuration
        /// </summary>
        [Fact]
        public void PostConfigTestNegative()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsType<PostSensorResponse>(post_response);
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            // configure sensor with invalid feature count
            List<FeatureConfig> features = new List<FeatureConfig>{ new FeatureConfig(50, 1, 1, "fancy-label", FeatureConfig.SubmitRuleEnum.Submit) };


            var postConfigRequest = new PostConfigRequest(anomalyHistoryWindow: 1000, 
                                                    learningRateNumerator: 10, 
                                                    learningRateDenominator: 10000, 
                                                    learningMaxClusters: 1000, 
                                                    learningMaxSamples: 10000000, 
                                                    featureCount: -1, 
                                                    streamingWindowSize: 25,
                                                    features: features, 
                                                    samplesToBuffer: 1000
                                                );
            try {
                var config_response = instance.PostConfig(post_response.SensorId, postConfigRequest); // should throw
                Assert.True(false, "PostConfig with bad feature countshould have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Fact]
        public void GetVersionTest()
        {
            // test get version
            var response = instance.GetVersion();
            Assert.IsType<ModelVersion>(response);
        }

        /// <summary>
        /// Test GetConfig Negative
        /// </summary>
        [Fact]
        public void GetConfigTestNegative(){

            try {
                var get_response = instance.GetConfig("nonexistent-sensor-id"); // should throw
                Assert.True(false, "GetConfig with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }
            
        }


        /// <summary>
        /// Test PostStream 
        /// </summary>
        [Fact]
        public void PostStreamTest()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);

            // configure sensor with invalid feature count
            List<FeatureConfig> features = new List<FeatureConfig>{ new FeatureConfig(50, 1, 1, "fancy-label", FeatureConfig.SubmitRuleEnum.Submit) };


            var postConfigRequest = new PostConfigRequest(anomalyHistoryWindow: 1000, 
                                                    learningRateNumerator: 10, 
                                                    learningRateDenominator: 10000, 
                                                    learningMaxClusters: 1000, 
                                                    learningMaxSamples: 10000000, 
                                                    featureCount: 1, 
                                                    streamingWindowSize: 25,
                                                    features: features, 
                                                    samplesToBuffer: 1000
                                                );

            //post a configuration
            var config_response = instance.PostConfig(post_response.SensorId, postConfigRequest);

            
            //stream data
            float[] data = { 1.0f, 2.0f, 3.0f, 4.0f };
            var data_str = instance.FormatData(data);
            var postStreamRequest = new PostStreamRequest(data: data_str);

            var post_stream_response = instance.PostStream(post_response.SensorId, postStreamRequest);
            Assert.IsType<PostStreamResponse>(post_stream_response);
            Assert.Equal(0, post_stream_response.RI[0]);
            Assert.Equal(0, post_stream_response.SI[0]);
            Assert.Equal(0, post_stream_response.AD[0]);
            Assert.Equal(0, post_stream_response.AH[0]);
            Assert.Equal(0, post_stream_response.AM[0]);
            Assert.Equal(0, post_stream_response.AW[0]);
            Assert.Equal(0, post_stream_response.ID[0]);
            Assert.False(string.IsNullOrEmpty(post_stream_response.State));
   
            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsType<Error>(delete_response);
        }

        /// <summary>
        /// Test PostStream Negative
        /// </summary>
        [Fact]
        public void PostStreamTestNegative()
        {
            float[] data = { 1.0f, 2.0f, 3.0f, 4.0f };
            var data_str = instance.FormatData(data);
            var postStreamRequest = new PostStreamRequest(data: data_str);

            try {
                 var post_stream_response = instance.PostStream("nonexistent-sensor-id", postStreamRequest); // should throw
                Assert.True(false, "PostStream with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }

        }

    }
    
}