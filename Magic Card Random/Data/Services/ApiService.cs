using Magic_Card_Random.Data.Models;
using Newtonsoft.Json;

namespace Magic_Card_Random.Data.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        string apiUrl = "https://api.scryfall.com/cards/";
        string apiUrlRandom = "https://api.scryfall.com/cards/random";

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Card> GetRandomCard()
        {

            using (var response = await _httpClient.GetAsync(apiUrlRandom))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Card>(apiResponse);
            }
        }

        public async Task<Card> GetCardByName(string name)
        {
            using (var response = await _httpClient.GetAsync($"{apiUrl}/named?fuzzy={name}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Card>(apiResponse);
            }
        }
    }
}
