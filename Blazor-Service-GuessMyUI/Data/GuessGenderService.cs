using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Blazor_Service_GuessMyUI.Data
{
    public class GuessGenderService
    {
        private readonly HttpClient client = new HttpClient();
        private string BASEURL = "http://" + EnvironmentHelper.GetGenderServiceIP() + ":" + EnvironmentHelper.GetGenderServicePort();

        public async Task<GuessGenderData> GetGuessGenderData(String username)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GuessMyUI", "1.0"));

            var streamTask = client.GetStreamAsync(BASEURL + "?username=" + username);
            var result = await streamTask;
            var repository = await JsonSerializer.DeserializeAsync<GuessGenderData>(result);
            return repository;
        }
    }
}
