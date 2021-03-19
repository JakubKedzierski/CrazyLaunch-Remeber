using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Net.Http;
using System.Net.Http.Headers;

using System.Runtime.InteropServices;
using Nancy.Json;
using Nancy.Json.Simple;
using System.Net;


namespace CrazyRL
{
    public class APIParser
    {
        private const string URL = "https://lldev.thespacedevs.com/2.0.0/launch";
        private const string URLparametr = "?format=json";

        private string APIresponse = null;


        /// <summary>
        /// Connects to thespacedevs API and download launch info in json format
        /// 
        /// If connection failes throws WebException 
        /// If connection is stable download api response
        /// </summary>
        public async void getApiResponse()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.GetAsync(URLparametr).Result;
            if (response.IsSuccessStatusCode)
            {
                APIresponse = await response.Content.ReadAsStringAsync();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                throw new WebException("Api connection failed.");
            }

            client.Dispose();

        }

        /// <summary>
        /// Start parsing launch request using api response that have to be earlier downloaded 
        /// </summary>
        public List<Launch> parseLaunchRequest()
        {
            var launchList = new List<Launch>();
            if (APIresponse != null)
                launchList = parseLaunchRequest(APIresponse);
            else
                throw new InvalidOperationException("APIresponse is null");

            return launchList;
        }


        /// <summary>
        /// Parse jsonResponse and create Launch objects 
        /// 
        /// </summary>
        /// <param name="jsonApiResponse"></param> json response for launch request. Response must have proper composition
        public List<Launch> parseLaunchRequest(String jsonApiResponse)
        {
            JsonArray results = new JsonArray();
            try
            {
                var serializer = new JavaScriptSerializer();
                var response = serializer.Deserialize<dynamic>(jsonApiResponse);
                results = response["results"];
            }
            catch (System.Runtime.Serialization.SerializationException exception)
            {
                Console.WriteLine("Parsing goes wrong, not proper json file");
                Console.WriteLine("Exception message:" + exception.ToString());
                throw new InvalidOperationException("Parsing goes wrong, not proper json file");
            }

            var launchList = new List<Launch>();

            foreach (JsonObject launchData in results)
            {

                Launch launch = new Launch();
                try
                {
                    launch.name = launchData["name"].ToString();
                    JsonObject nestedLaunchInfo = (JsonObject)launchData["status"];
                    launch.status = nestedLaunchInfo["name"].ToString();
                    
                    launch.windowStart = launchData["window_start"].ToString();
                    launch.windowEnd = launchData["window_end"].ToString();
                    
                    nestedLaunchInfo = (JsonObject)launchData["launch_service_provider"];
                    launch.launchProvider = nestedLaunchInfo["name"].ToString();
                    
                    nestedLaunchInfo = (JsonObject)launchData["rocket"];
                    nestedLaunchInfo = (JsonObject)nestedLaunchInfo["configuration"];
                    launch.rocketFullName = nestedLaunchInfo["full_name"].ToString();

                    JsonObject padInfo = (JsonObject)launchData["pad"];
                    launch.locationGoogleMapsUrl = padInfo["map_url"].ToString();

                    padInfo = (JsonObject)padInfo["location"];
                    launch.location = padInfo["name"].ToString();

                    launchList.Add(launch);
                }
                catch (System.Collections.Generic.KeyNotFoundException exception)
                {
                    Console.WriteLine("Parsing goes wrong, key not found in dictionary");
                    Console.WriteLine("Exception message:" + exception.ToString());
                    throw new InvalidOperationException("Parsing goes wrong, key not found in dictionary");
                }
            }

            return launchList;
            

        }
    }
}
