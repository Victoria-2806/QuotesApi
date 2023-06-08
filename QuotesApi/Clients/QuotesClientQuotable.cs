using Newtonsoft.Json;
using QuotesApi;
using QuotesApi.Models;

namespace TelegramQuotesBot.Client
{
    public class QuotesClientQuotable
    {
        private HttpClient httpClient;
        private static string? addressQuotable;

        public QuotesClientQuotable()
        {
            addressQuotable = Constants.addressQuotable;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(addressQuotable);
        }

        public async Task<QuoteQuotable> GetRandomQuoteAsync()
        {
            var responce = await httpClient.GetAsync($"https://api.quotable.io/random");
            responce.EnsureSuccessStatusCode();
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<QuoteQuotable>(content);
            return result;
        }
    }
}

