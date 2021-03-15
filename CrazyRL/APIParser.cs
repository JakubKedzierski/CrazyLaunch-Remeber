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

namespace CrazyRL
{
    class APIParser
    {
        private const string URL = "https://lldev.thespacedevs.com/2.0.0/launch";

        public async void downloadAPI()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.GetAsync("?format=json").Result;  
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = await response.Content.ReadAsStringAsync();
                parseAPI(dataObjects);
                File.WriteAllText("dane_lotow.txt", dataObjects);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

        }

        public void parseAPI(String jsonApiResponse)
        {
            JsonArray results = new JsonArray();
            try
            {
                var serializer = new JavaScriptSerializer(); 
                var response = serializer.Deserialize<dynamic>(jsonApiResponse);
                results = response["results"];
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                Console.WriteLine("Parsing goes wrong, not proper json file");
            }
            Console.WriteLine(results[0]);
            
        }
    }
}
