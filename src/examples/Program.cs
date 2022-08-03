
using System;
using System.IO;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Examples
{
    public class AmberExamples
    {
        static void Main()
        {
            Console.WriteLine("Entered main");

            //Set the Amber License Info
            Environment.SetEnvironmentVariable("AMBER_USERNAME", "admin");
            Environment.SetEnvironmentVariable("AMBER_PASSWORD", "admin");
            Environment.SetEnvironmentVariable("AMBER_SERVER", "https://10.0.1.63/v1");

            var apiInstance = new DefaultApi("", "", false, 300000);

            try
            {
                // Try to get version
                var result = apiInstance.GetVersion();
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling DefaultApi.PostOauth2: " + e.Message );
            }
        }
    }
}