/*
 * Stock Market Open Times API - Basic Usage Example
 *
 * This example demonstrates the basic usage of the Stock Market Open Times API.
 * API Documentation: https://docs.apiverve.com/ref/stockmarketopentimes
 */

using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace APIVerve.Examples
{
    class StockMarketOpenTimesExample
    {
        private static readonly string API_KEY = Environment.GetEnvironmentVariable("APIVERVE_API_KEY") ?? "YOUR_API_KEY_HERE";
        private static readonly string API_URL = "https://api.apiverve.com/v1/stockmarketopentimes";

        /// <summary>
        /// Make a GET request to the Stock Market Open Times API
        /// </summary>
        static async Task<JsonDocument> CallStockMarketOpenTimesAPI()
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("x-api-key", API_KEY);

                // Query parameters
                var queryParams &#x3D; new Dictionary&lt;string, string&gt; { [&quot;exchange&quot;] &#x3D; &quot;NYSE&quot; };

                var queryString = string.Join("&",
                    queryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
                var url = $"{API_URL}?{queryString}";

                var response = await client.GetAsync(url);

                // Check if response is successful
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var data = JsonDocument.Parse(responseBody);

                // Check API response status
                if (data.RootElement.GetProperty("status").GetString() == "ok")
                {
                    Console.WriteLine("✓ Success!");
                    Console.WriteLine("Response data: " + data.RootElement.GetProperty("data"));
                    return data;
                }
                else
                {
                    var error = data.RootElement.TryGetProperty("error", out var errorProp)
                        ? errorProp.GetString()
                        : "Unknown error";
                    Console.WriteLine($"✗ API Error: {error}");
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"✗ Request failed: {e.Message}");
                return null;
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("📤 Calling Stock Market Open Times API...\n");

            var result = await CallStockMarketOpenTimesAPI();

            if (result != null)
            {
                Console.WriteLine("\n📊 Final Result:");
                Console.WriteLine(result.RootElement.GetProperty("data"));
            }
            else
            {
                Console.WriteLine("\n✗ API call failed");
            }
        }
    }
}
