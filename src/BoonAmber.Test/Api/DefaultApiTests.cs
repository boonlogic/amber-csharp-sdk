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
// uncomment below to import models
//using BoonAmber.Model;

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

        public DefaultApiTests()
        {
            instance = new DefaultApi();
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
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test DeleteSensor
        /// </summary>
        [Fact]
        public void DeleteSensorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.DeleteSensor(sensorId);
            //Assert.IsType<Error>(response);
        }

        /// <summary>
        /// Test GetAmberSummary
        /// </summary>
        [Fact]
        public void GetAmberSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.GetAmberSummary(sensorId);
            //Assert.IsType<GetSummaryResponse>(response);
        }

        /// <summary>
        /// Test GetConfig
        /// </summary>
        [Fact]
        public void GetConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.GetConfig(sensorId);
            //Assert.IsType<GetConfigResponse>(response);
        }

        /// <summary>
        /// Test GetPretrain
        /// </summary>
        [Fact]
        public void GetPretrainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.GetPretrain(sensorId);
            //Assert.IsType<GetPretrainResponse>(response);
        }

        /// <summary>
        /// Test GetRootCause
        /// </summary>
        [Fact]
        public void GetRootCauseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //string? clusterID = null;
            //string? pattern = null;
            //var response = instance.GetRootCause(sensorId, clusterID, pattern);
            //Assert.IsType<List<List>>(response);
        }

        /// <summary>
        /// Test GetSensor
        /// </summary>
        [Fact]
        public void GetSensorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.GetSensor(sensorId);
            //Assert.IsType<GetSensorResponse>(response);
        }

        /// <summary>
        /// Test GetSensors
        /// </summary>
        [Fact]
        public void GetSensorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSensors();
            //Assert.IsType<List<SensorInstance>>(response);
        }

        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Fact]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.GetStatus(sensorId);
            //Assert.IsType<GetStatusResponse>(response);
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Fact]
        public void GetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVersion();
            //Assert.IsType<ModelVersion>(response);
        }

        /// <summary>
        /// Test PostConfig
        /// </summary>
        [Fact]
        public void PostConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PostConfigRequest postConfigRequest = null;
            //var response = instance.PostConfig(sensorId, postConfigRequest);
            //Assert.IsType<PostConfigResponse>(response);
        }

        /// <summary>
        /// Test PostOauth2
        /// </summary>
        [Fact]
        public void PostOauth2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostAuth2Request postAuth2Request = null;
            //var response = instance.PostOauth2(postAuth2Request);
            //Assert.IsType<PostAuth2Response>(response);
        }

        /// <summary>
        /// Test PostOutage
        /// </summary>
        [Fact]
        public void PostOutageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //var response = instance.PostOutage(sensorId);
            //Assert.IsType<PostOutageResponse>(response);
        }

        /// <summary>
        /// Test PostPretrain
        /// </summary>
        [Fact]
        public void PostPretrainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PostPretrainRequest postPretrainRequest = null;
            //string? amberChunk = null;
            //string? amberTransaction = null;
            //var response = instance.PostPretrain(sensorId, postPretrainRequest, amberChunk, amberTransaction);
            //Assert.IsType<PostPretrainResponse>(response);
        }

        /// <summary>
        /// Test PostSensor
        /// </summary>
        [Fact]
        public void PostSensorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostSensorRequest postSensorRequest = null;
            //var response = instance.PostSensor(postSensorRequest);
            //Assert.IsType<PostSensorResponse>(response);
        }

        /// <summary>
        /// Test PostStream
        /// </summary>
        [Fact]
        public void PostStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PostStreamRequest postStreamRequest = null;
            //var response = instance.PostStream(sensorId, postStreamRequest);
            //Assert.IsType<PostStreamResponse>(response);
        }

        /// <summary>
        /// Test PutConfig
        /// </summary>
        [Fact]
        public void PutConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PutConfigRequest putConfigRequest = null;
            //var response = instance.PutConfig(sensorId, putConfigRequest);
            //Assert.IsType<PutConfigResponse>(response);
        }

        /// <summary>
        /// Test PutSensor
        /// </summary>
        [Fact]
        public void PutSensorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PutSensorRequest putSensorRequest = null;
            //var response = instance.PutSensor(sensorId, putSensorRequest);
            //Assert.IsType<PutSensorResponse>(response);
        }

        /// <summary>
        /// Test PutStream
        /// </summary>
        [Fact]
        public void PutStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sensorId = null;
            //PutStreamRequest putStreamRequest = null;
            //var response = instance.PutStream(sensorId, putStreamRequest);
            //Assert.IsType<PutStreamResponse>(response);
        }
    }
}
