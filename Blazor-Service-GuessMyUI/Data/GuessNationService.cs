using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Blazor_Service_GuessMyUI.Data
{
    public class GuessNationService
    {
        private readonly HttpClient client = new HttpClient();
        private string BASEURL = "http://" + EnvironmentHelper.GetNationServiceIP() + ":" + EnvironmentHelper.GetNationServicePort();

        public async Task<GuessNationData> GetGuessNationData(String username)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GuessMyUI", "1.0"));

            var streamTask = client.GetStreamAsync(BASEURL + "?username=" + username);
            var result = await streamTask;
            var repository = await JsonSerializer.DeserializeAsync<GuessNationData>(result);
            return repository;
        }
    }
}
