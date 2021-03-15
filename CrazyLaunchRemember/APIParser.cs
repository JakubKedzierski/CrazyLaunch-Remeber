using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CrazyLaunchRemember
{
    class APIParser
    { 

        private const string URL = "https://lldev.thespacedevs.com/2.0.0/launch";
    
        public async void parseAPI() {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.GetAsync("?format=json").Result;  
            if (response.IsSuccessStatusCode)
            {
                var dataObjects =await response.Content.ReadAsStringAsync();  
                Console.WriteLine(dataObjects);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();
        }


    }
}
