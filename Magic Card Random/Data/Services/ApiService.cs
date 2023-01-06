using Magic_Card_Random.Data.Models;
using Newtonsoft.Json;

namespace Magic_Card_Random.Data.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Card> GetRandomCard()
        {
            string url = "https://api.scryfall.com/cards/random";

            using (var response = await _httpClient.GetAsync(url))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Card>(apiResponse);
            }
        }
    }
}
