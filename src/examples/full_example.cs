
using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Examples
{
    public class AmberExamples
    {
        //Entry Point
        static void Main()
        {
            Console.WriteLine("Boon Amber SDK Example...");

            //Set the Amber License Info
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "admin");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "admin");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://127.0.0.1/v1");

            var apiInstance = new DefaultApi("", "", false, 300000);

            // Get API version info
            try
            {
                var result = apiInstance.GetVersion();
                Console.WriteLine("Version: {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling GetVersion(): " + e.Message );
                return;
            }

            // Sensor label
            string label = "example_sensor";
            string sensorID = "";

            // Get  existing sensors
            GetSensorsResponse get_response;
            try {
                get_response = apiInstance.GetSensors();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling GetSensors(): " + e.Message );
                return;
            }

            // Find sensor
            bool found = false;
            foreach (SensorInstance sensor in get_response)
            {
                if (sensor.Label == label) {
                    sensorID = sensor.SensorId;
                    Console.WriteLine("Using existing sensor: {0}", sensorID);
                    found = true;
                    break;
                }
            } 

            if (!found) {
                // Create sensor 
                try{
                    var postSensorRequest = new PostSensorRequest(label);
                    var post_response = apiInstance.PostSensor(postSensorRequest);
                    sensorID = post_response.SensorId;
                    Console.WriteLine("Created new sensor: {0}", post_response);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when calling PostSensor(): " + e.Message );
                    return;
                }
            }
            


            // Populate sensor configuration
            int featureCount = 10;
            float maxVal = 1000.0f;
            int maxSamples = 2000;
            List<FeatureConfig> features = new List<FeatureConfig>();
            for (int ii =0; ii < featureCount; ii++) {
                label = "feature_" + ii.ToString();
                features.Add( new FeatureConfig(maxVal: maxVal, minVal: 0.0f, weight: 1, label: label, FeatureConfig.SubmitRuleEnum.Submit) );
            }

            var postConfigRequest = new PostConfigRequest(anomalyHistoryWindow: 1000, 
                                                    learningRateNumerator: 10, 
                                                    learningRateDenominator: 10000, 
                                                    learningMaxClusters: 1000, 
                                                    learningMaxSamples: maxSamples, 
                                                    featureCount: featureCount, 
                                                    streamingWindowSize: 1,
                                                    features: features, 
                                                    samplesToBuffer: maxSamples
                                                );

            // Post the sensor configuration
            try{
                var config_response = apiInstance.PostConfig(sensorID, postConfigRequest);
                Console.WriteLine("Sensor Configuration: {0}", config_response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling PostConfig(): " + e.Message );
                return;
            }


            // Create dataset
            int numClusters = 25;
            float noise = 5.0f;
            List<List<float>> dataset = new List<List<float>>(numClusters);
            for (int i = 0; i < numClusters; i ++){
                List<float> pattern = CreateRandomList(length: featureCount, min_val: 0.0f, max_val: maxVal);
                dataset.Add( pattern );
            }
            PrintList(dataset[0]);
            
            Console.WriteLine("Posting Data ...");

            // Stream regular data
            int iterations = maxSamples + 50;
            int clusterID = 0;
            string lastState = "Error";
            PostStreamResponse post_stream_response;
            for(int i = 0; i < iterations; i++){
                // select a cluster and add noise
                clusterID = i % numClusters; 
                List<float> data = ApplyNoise(dataset[clusterID], noise);

                // Inference data
                try{
                    var data_str = apiInstance.FormatData(data.ToArray());
                    var postStreamRequest = new PostStreamRequest(data: data_str);
                    post_stream_response = apiInstance.PostStream(sensorID, postStreamRequest);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when calling PostStream(): " + e.Message );
                    return;
                }


                if (post_stream_response.State != lastState){
                    lastState = post_stream_response.State;
                    Console.WriteLine("Amber State: {0}", lastState);
                }
                if (post_stream_response.State == "Monitoring"){
                    Console.WriteLine("Final Cluster Count: {0}", post_stream_response.ClusterCount);
                    break;
                }
            }

            // Test with new cluster
            List<float> new_data = CreateRandomList(length: featureCount, min_val: 0.0f, max_val: maxVal);
            try{
                var data_str = apiInstance.FormatData(new_data.ToArray());
                var postStreamRequest = new PostStreamRequest(data: data_str);
                post_stream_response = apiInstance.PostStream(sensorID, postStreamRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling PostStream(): " + e.Message );
                return;
            }
            Console.WriteLine("Anomaly Index: {0}", post_stream_response.RI[0] );

   
            // Delete sensor
            try{
                var delete_response = apiInstance.DeleteSensor(sensorID);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling DeleteSensor(): " + e.Message );
                return;
            }
        }

        //Print out a list
        private static void PrintList(List<float> array){
            string values = "";
            foreach(float val in array){
                values = values + val.ToString() + ",";
            }
            Console.WriteLine("{0}", values);
        }

        //Random float
        private static float NextFloat(float min_val, float max_val){
            System.Random random = new System.Random();
            double val = (random.NextDouble() * (max_val-min_val)+min_val);
            return (float)val;
        }

        //Apply noise to a list
        private static List<float> ApplyNoise(List<float> array, float noise = 1.0f){
            List<float> new_array = new List<float>(array.Count);
            float modifier = 0.0f;
            for (int i = 0; i < array.Count; i++){
                modifier = NextFloat(-noise, noise);
                new_array.Add(array[i] + modifier);
            }
            return new_array;
        }

        //Create a random list of floats
        private static List<float> CreateRandomList(int length, float min_val = 0.0f, float max_val = 1.0f){
            List<float> arr = new List<float>();
            for (int i = 0; i < length; i++)
            {
                arr.Add( NextFloat(min_val, max_val) );
            }
            return arr;
        }
    }
}