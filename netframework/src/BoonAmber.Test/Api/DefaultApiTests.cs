/* 
 * Amber API Server
 *
 * Boon Logic Amber API Server
 *
 * OpenAPI spec version: 1.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BoonAmber.Client;
using BoonAmber.Api;
using BoonAmber.Model;

namespace BoonAmber.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;
        private string amber_license_file;
        private string amber_license_id;

        private void RestoreEnvironment(){
            //License File
            amber_license_file = Environment.GetEnvironmentVariable("AMBER_TEST_LICENSE_FILE");
            amber_license_id = Environment.GetEnvironmentVariable("AMBER_TEST_LICENSE_ID");

            //defaults
            if (string.IsNullOrEmpty(amber_license_file)){
                amber_license_file = "../test.Amber.license";
            }
            if (string.IsNullOrEmpty(amber_license_id)){
                amber_license_id = "default";
            }

            //clear env
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "");
        }

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            RestoreEnvironment();
            instance = new DefaultApi(amber_license_id, amber_license_file, false, 300000);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsType' DefaultApi
            Assert.IsInstanceOf<DefaultApi> (instance, "instance is DefaultApi");
        }

        /// <summary>
        /// Test authentication methods
        /// </summary>
        [Test]
        public void AuthenticationTest()
        {
            // Test with the good instance
            var body = new PostAuth2Request(instance.username, instance.password);
            var response = instance.PostOauth2(body);

            // Check Token and Expiration
            Assert.False(string.IsNullOrEmpty(response.IdToken));
            Assert.False(string.IsNullOrEmpty(response.ExpiresIn));

            //Set the License Info with env
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "admin");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "admin");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://localhost:5007/v1");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "https://localhost:5007/v1");
            var instance1 = new DefaultApi("", "", false, 300000);
            Assert.AreEqual("admin", instance1.username);
            Assert.AreEqual("admin", instance1.password);
            Assert.AreEqual("https://localhost:5007/v1", instance1.server);
            Assert.AreEqual("https://localhost:5007/v1", instance1.oauth_server);
            

            // Test With license file
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "");
            var instance2 = new DefaultApi(amber_license_id, amber_license_file, true, 300000);
            Assert.False(string.IsNullOrEmpty(instance2.username));
            Assert.False(string.IsNullOrEmpty(instance2.password));
            Assert.False(string.IsNullOrEmpty(instance2.server));
            Assert.False(string.IsNullOrEmpty(instance2.oauth_server));

            // override items in license file through environment
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "xyyyAmberUser");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "bogus_password");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://temp.amber.boonlogic.com/v1");
            Environment.SetEnvironmentVariable("AMBER_OAUTH_SERVER", "https://auth.amber.boonlogic.com/v1");
            var instance3 = new DefaultApi(amber_license_id, amber_license_file, true, 300000);
            Assert.AreEqual("xyyyAmberUser", instance3.username);
            Assert.AreEqual("bogus_password", instance3.password);
            Assert.AreEqual("https://temp.amber.boonlogic.com/v1", instance3.server);
            Assert.AreEqual("https://auth.amber.boonlogic.com/v1", instance3.oauth_server);

            //test auth with garbage credentials
            var instance4 = new DefaultApi("garbage", amber_license_file, false, 300000);
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
        [Test]
        public void PostSensorTest()
        {

            //create sensor 
            var postSensorRequest = new PostSensorRequest("test_sensor_1");
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsInstanceOf<PostSensorResponse> (post_response, "response is PostSensorResponse");
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test PutSensor
        /// </summary>
        [Test]
        public void UpdateLabelTest(){
            //create sensor 
            var postSensorRequest = new PostSensorRequest("test_sensor_2");
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsInstanceOf<PostSensorResponse> (post_response, "post_response is PostSensorResponse");
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //update
            string newlabel = "test_sensor_2_updated";
            var putSensorRequest = new PutSensorRequest(newlabel);
            var put_response = instance.PutSensor(putSensorRequest, post_response.SensorId);
            Assert.IsInstanceOf<PutSensorResponse> (put_response, "put_response is PutSensorResponse");
            Assert.False(string.IsNullOrEmpty(put_response.SensorId));
            Assert.AreEqual(newlabel, put_response.Label);

            //delete sensor
            var delete_response = instance.DeleteSensor(put_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test PutSensor Negative
        /// </summary>
        [Test]
        public void UpdateLabelTestNegative(){
            //update
            var putSensorRequest = new PutSensorRequest("test_sensor_garbage");
             try {
                var put_response = instance.PutSensor(putSensorRequest, "nonexistent-sensor-id"); // should throw
                Assert.True(false, "Update with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }
        }

        /// <summary>
        /// Test GetSensor
        /// </summary>
        [Test]
        public void GetSensorTest()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsInstanceOf<PostSensorResponse> (post_response, "post_response is PostSensorResponse");
            Assert.False(string.IsNullOrEmpty(post_response.SensorId));

            //get sensor 
            var get_response = instance.GetSensor(post_response.SensorId);
            Assert.IsInstanceOf<GetSensorResponse> (get_response, "post_response is GetSensorResponse");
            Assert.False(string.IsNullOrEmpty(get_response.Label));
            Assert.AreEqual(label, get_response.Label);

            //delete sensor
            var delete_response = instance.DeleteSensor(get_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test GetSensor Negative
        /// </summary>
        [Test]
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
        [Test]
        public void ListSensorTest()
        {
            //create sensors
            string[] labels = { "test_sensor_1", "test_sensor_2", "test_sensor_3" };
            foreach (string label in labels)
            {
                var postSensorRequest = new PostSensorRequest(label);
                var post_response = instance.PostSensor(postSensorRequest);
                Assert.IsInstanceOf<PostSensorResponse> (post_response, "post_response is PostSensorResponse");
                Assert.False(string.IsNullOrEmpty(post_response.SensorId));
            } 

            
            //get sensor 
            var get_response = instance.GetSensors();
            Assert.IsInstanceOf<GetSensorsResponse> (get_response, "get_response is GetSensorsResponse");
            Assert.True(get_response.Count >= 3, "Expected #sensors to be greater than or euqal to 3.");

            //delete sensor
            foreach (SensorInstance sensor in get_response)
            {
                var delete_response = instance.DeleteSensor(sensor.SensorId);
                Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
            } 
        }

        /// <summary>
        /// Test PostConfig and GetConfig
        /// </summary>
        [Test]
        public void PostConfigTest()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsInstanceOf<PostSensorResponse> (post_response, "post_response is PostSensorResponse");
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
            var config_response = instance.PostConfig(postConfigRequest, post_response.SensorId);
            Assert.AreEqual(postConfigRequest.FeatureCount, config_response.FeatureCount);
            Assert.AreEqual(postConfigRequest.StreamingWindowSize, config_response.StreamingWindowSize);
            Assert.AreEqual(postConfigRequest.AnomalyHistoryWindow, config_response.AnomalyHistoryWindow);
            Assert.AreEqual(postConfigRequest.LearningRateNumerator, config_response.LearningRateNumerator);
            Assert.AreEqual(postConfigRequest.LearningRateDenominator, config_response.LearningRateDenominator);
            Assert.AreEqual(postConfigRequest.LearningMaxClusters, config_response.LearningMaxClusters);
            Assert.AreEqual(postConfigRequest.LearningMaxSamples, config_response.LearningMaxSamples);
            Assert.AreEqual(postConfigRequest.SamplesToBuffer, config_response.SamplesToBuffer);

            //Get the config
            var get_config_response = instance.GetConfig(post_response.SensorId);
            Assert.IsInstanceOf<GetConfigResponse> (get_config_response, "get_config_response is GetConfigResponse");
            Assert.AreEqual(postConfigRequest.FeatureCount, get_config_response.FeatureCount);
            Assert.AreEqual(postConfigRequest.StreamingWindowSize, get_config_response.StreamingWindowSize);
            Assert.AreEqual(postConfigRequest.AnomalyHistoryWindow, get_config_response.AnomalyHistoryWindow);
            Assert.AreEqual(postConfigRequest.LearningRateNumerator, get_config_response.LearningRateNumerator);
            Assert.AreEqual(postConfigRequest.LearningRateDenominator, get_config_response.LearningRateDenominator);
            Assert.AreEqual(postConfigRequest.LearningMaxClusters, get_config_response.LearningMaxClusters);
            Assert.AreEqual(postConfigRequest.LearningMaxSamples, get_config_response.LearningMaxSamples);
            Assert.AreEqual(postConfigRequest.SamplesToBuffer, get_config_response.SamplesToBuffer);

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test PostConfig with invalid configuration
        /// </summary>
        [Test]
        public void PostConfigTestNegative()
        {
            //create sensor 
            string label = "test_sensor_1";
            var postSensorRequest = new PostSensorRequest(label);
            var post_response = instance.PostSensor(postSensorRequest);
            Assert.IsInstanceOf<PostSensorResponse> (post_response, "post_response is PostSensorResponse");
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
                var config_response = instance.PostConfig(postConfigRequest, post_response.SensorId); // should throw
                Assert.True(false, "PostConfig with bad feature countshould have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Test]
        public void GetVersionTest()
        {
            // test get version
            var response = instance.GetVersion();
            Assert.IsInstanceOf<BoonAmber.Model.Version> (response, "response is ModelVersion");
        }

        /// <summary>
        /// Test GetConfig Negative
        /// </summary>
        [Test]
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
        [Test]
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
            var config_response = instance.PostConfig(postConfigRequest, post_response.SensorId);

            
            //stream data
            float[] data = { 1.0f, 2.0f, 3.0f, 4.0f };
            var data_str = instance.FormatData(data);
            var postStreamRequest = new PostStreamRequest(data: data_str);

            var post_stream_response = instance.PostStream(postStreamRequest, post_response.SensorId);
            Assert.IsInstanceOf<PostStreamResponse> (post_stream_response, "post_stream_response is PostStreamResponse");
            Assert.AreEqual(0, post_stream_response.RI[0]);
            Assert.AreEqual(0, post_stream_response.SI[0]);
            Assert.AreEqual(0, post_stream_response.AD[0]);
            Assert.AreEqual(0, post_stream_response.AH[0]);
            Assert.AreEqual(0, post_stream_response.AM[0]);
            Assert.AreEqual(0, post_stream_response.AW[0]);
            Assert.AreEqual(0, post_stream_response.ID[0]);
            Assert.False(string.IsNullOrEmpty(post_stream_response.State));

            //delete sensor
            var delete_response = instance.DeleteSensor(post_response.SensorId);
            Assert.IsInstanceOf<Error> (delete_response, "delete_response is Error");
        }

        /// <summary>
        /// Test PostStream Negative
        /// </summary>
        [Test]
        public void PostStreamTestNegative()
        {
            float[] data = { 1.0f, 2.0f, 3.0f, 4.0f };
            var data_str = instance.FormatData(data);
            var postStreamRequest = new PostStreamRequest(data: data_str);

            try {
                 var post_stream_response = instance.PostStream(postStreamRequest, "nonexistent-sensor-id"); // should throw
                Assert.True(false, "PostStream with bad sensor ID should have raised exception");
            } catch (Exception) {
                // Catches the assertion exception, and the test passes
            }

        }

    }
    
}

