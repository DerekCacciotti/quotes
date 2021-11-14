using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using quotes.Data.Model;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace quotes.Data
{
    public class DataManager {
        private readonly string baseURL = "https://api.tronalddump.io/";
        public async Task<List<Trump>> getDataAsync()
        {
           // Thread.Sleep(30000);
            List<Trump> Quotes = new List<Trump>();
            var clinet = new RestClient(baseURL + "random/quote");
            var request = new RestRequest(Method.GET);
            var response = await clinet.ExecuteGetAsync(request);
            if(response.IsSuccessful)
            {
                var quote = JsonConvert.DeserializeObject<Trump>(response.Content);
                Quotes.Add(quote);
            }

            return Quotes;

        }

    }
}