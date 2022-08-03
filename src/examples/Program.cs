
using System;
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
            // Configure API key authorization: authorize-amber-pool
            //Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            Console.WriteLine("Entered main");

            var apiInstance = new DefaultApi("https://10.0.1.63/v1");

            // apiInstance.Configuration.CreateApiClient();
            // apiInstance.Configuration.BasePath = "https://10.0.1.63/v1";
            // apiInstance.Configuration.Timeout = 30000;
            // apiInstance.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromMilliseconds(30000);

            var body = new PostAuth2Request("admin", "admin");

            Console.WriteLine(body);

            try
            {
                // Delete a sensor instance
                var result = apiInstance.PostOauth2(body);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling DefaultApi.PostOauth2: " + e.Message );
            }
        }
    }
}