using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Directus_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://localhost/Directus/api/1.1/tables/first_table/rows");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Bearer 1Po1FSAKtbIpnWZgqPQ9i7BxGtLbvCln");
            IRestResponse response = client.Execute(request);

            JToken parsedJson = JToken.Parse(response.Content.ToString());
            Console.WriteLine(parsedJson.ToString(Formatting.Indented));
        }
    }
}
