/* 
 * Amber API Server
 *
 * Boon Logic Amber API Server
 *
 * OpenAPI spec version: 1.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using BoonAmber.Api;
using BoonAmber.Model;
using BoonAmber.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace BoonAmber.Test
{
    /// <summary>
    ///  Class for testing GetSummaryResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetSummaryResponseTests
    {
        // TODO uncomment below to declare an instance variable for GetSummaryResponse
        //private GetSummaryResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetSummaryResponse
            //instance = new GetSummaryResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetSummaryResponse
        /// </summary>
        [Test]
        public void GetSummaryResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetSummaryResponse
            //Assert.IsInstanceOfType<GetSummaryResponse> (instance, "variable 'instance' is a GetSummaryResponse");
        }


        /// <summary>
        /// Test the property 'MagicNumber'
        /// </summary>
        [Test]
        public void MagicNumberTest()
        {
            // TODO unit test for the property 'MagicNumber'
        }
        /// <summary>
        /// Test the property 'VersionNumber'
        /// </summary>
        [Test]
        public void VersionNumberTest()
        {
            // TODO unit test for the property 'VersionNumber'
        }
        /// <summary>
        /// Test the property 'MNano'
        /// </summary>
        [Test]
        public void MNanoTest()
        {
            // TODO unit test for the property 'MNano'
        }
        /// <summary>
        /// Test the property 'MBufferStats'
        /// </summary>
        [Test]
        public void MBufferStatsTest()
        {
            // TODO unit test for the property 'MBufferStats'
        }
        /// <summary>
        /// Test the property 'MAutotune'
        /// </summary>
        [Test]
        public void MAutotuneTest()
        {
            // TODO unit test for the property 'MAutotune'
        }
        /// <summary>
        /// Test the property 'MAutotuningElbowClusterCounts'
        /// </summary>
        [Test]
        public void MAutotuningElbowClusterCountsTest()
        {
            // TODO unit test for the property 'MAutotuningElbowClusterCounts'
        }
        /// <summary>
        /// Test the property 'MAutotuningElbowPVArray'
        /// </summary>
        [Test]
        public void MAutotuningElbowPVArrayTest()
        {
            // TODO unit test for the property 'MAutotuningElbowPVArray'
        }
        /// <summary>
        /// Test the property 'MStreamingParameters'
        /// </summary>
        [Test]
        public void MStreamingParametersTest()
        {
            // TODO unit test for the property 'MStreamingParameters'
        }
        /// <summary>
        /// Test the property 'MAmberStatus'
        /// </summary>
        [Test]
        public void MAmberStatusTest()
        {
            // TODO unit test for the property 'MAmberStatus'
        }
        /// <summary>
        /// Test the property 'MTraining'
        /// </summary>
        [Test]
        public void MTrainingTest()
        {
            // TODO unit test for the property 'MTraining'
        }
        /// <summary>
        /// Test the property 'MAnomalyThreshold'
        /// </summary>
        [Test]
        public void MAnomalyThresholdTest()
        {
            // TODO unit test for the property 'MAnomalyThreshold'
        }
        /// <summary>
        /// Test the property 'MAmberWarningCriticalValue'
        /// </summary>
        [Test]
        public void MAmberWarningCriticalValueTest()
        {
            // TODO unit test for the property 'MAmberWarningCriticalValue'
        }
        /// <summary>
        /// Test the property 'MAmberAlertCriticalValue'
        /// </summary>
        [Test]
        public void MAmberAlertCriticalValueTest()
        {
            // TODO unit test for the property 'MAmberAlertCriticalValue'
        }
        /// <summary>
        /// Test the property 'MErrorStringBuffer'
        /// </summary>
        [Test]
        public void MErrorStringBufferTest()
        {
            // TODO unit test for the property 'MErrorStringBuffer'
        }
        /// <summary>
        /// Test the property 'MClusteringParametersInitialized'
        /// </summary>
        [Test]
        public void MClusteringParametersInitializedTest()
        {
            // TODO unit test for the property 'MClusteringParametersInitialized'
        }
        /// <summary>
        /// Test the property 'MStreamingMode'
        /// </summary>
        [Test]
        public void MStreamingModeTest()
        {
            // TODO unit test for the property 'MStreamingMode'
        }
        /// <summary>
        /// Test the property 'MStreamingModeStatus'
        /// </summary>
        [Test]
        public void MStreamingModeStatusTest()
        {
            // TODO unit test for the property 'MStreamingModeStatus'
        }
        /// <summary>
        /// Test the property 'MModifiedAt'
        /// </summary>
        [Test]
        public void MModifiedAtTest()
        {
            // TODO unit test for the property 'MModifiedAt'
        }
        /// <summary>
        /// Test the property 'MAnomalyMetricByAnomalyCount'
        /// </summary>
        [Test]
        public void MAnomalyMetricByAnomalyCountTest()
        {
            // TODO unit test for the property 'MAnomalyMetricByAnomalyCount'
        }
        /// <summary>
        /// Test the property 'MRecentAnomalyCount'
        /// </summary>
        [Test]
        public void MRecentAnomalyCountTest()
        {
            // TODO unit test for the property 'MRecentAnomalyCount'
        }
        /// <summary>
        /// Test the property 'MResultsIDArray'
        /// </summary>
        [Test]
        public void MResultsIDArrayTest()
        {
            // TODO unit test for the property 'MResultsIDArray'
        }
        /// <summary>
        /// Test the property 'MTrainingSamples'
        /// </summary>
        [Test]
        public void MTrainingSamplesTest()
        {
            // TODO unit test for the property 'MTrainingSamples'
        }
        /// <summary>
        /// Test the property 'MRecentSamples'
        /// </summary>
        [Test]
        public void MRecentSamplesTest()
        {
            // TODO unit test for the property 'MRecentSamples'
        }
        /// <summary>
        /// Test the property 'MRecentRawSamples'
        /// </summary>
        [Test]
        public void MRecentRawSamplesTest()
        {
            // TODO unit test for the property 'MRecentRawSamples'
        }
        /// <summary>
        /// Test the property 'MRecentTimes'
        /// </summary>
        [Test]
        public void MRecentTimesTest()
        {
            // TODO unit test for the property 'MRecentTimes'
        }
        /// <summary>
        /// Test the property 'MRecentSIs'
        /// </summary>
        [Test]
        public void MRecentSIsTest()
        {
            // TODO unit test for the property 'MRecentSIs'
        }
        /// <summary>
        /// Test the property 'MRecentRIs'
        /// </summary>
        [Test]
        public void MRecentRIsTest()
        {
            // TODO unit test for the property 'MRecentRIs'
        }
        /// <summary>
        /// Test the property 'MRecentADs'
        /// </summary>
        [Test]
        public void MRecentADsTest()
        {
            // TODO unit test for the property 'MRecentADs'
        }
        /// <summary>
        /// Test the property 'MRecentAHs'
        /// </summary>
        [Test]
        public void MRecentAHsTest()
        {
            // TODO unit test for the property 'MRecentAHs'
        }
        /// <summary>
        /// Test the property 'MRecentIDs'
        /// </summary>
        [Test]
        public void MRecentIDsTest()
        {
            // TODO unit test for the property 'MRecentIDs'
        }
        /// <summary>
        /// Test the property 'MRecentAMs'
        /// </summary>
        [Test]
        public void MRecentAMsTest()
        {
            // TODO unit test for the property 'MRecentAMs'
        }
        /// <summary>
        /// Test the property 'MRecentAWs'
        /// </summary>
        [Test]
        public void MRecentAWsTest()
        {
            // TODO unit test for the property 'MRecentAWs'
        }

    }

}