using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static LambdaBot.Models.RespnoseModel;

namespace LambdaBot.Clients
{
    internal class PirateTranslatorClient : IPirateTranslatorClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _settings;

        public PirateTranslatorClient(HttpClient httpClient, JsonSerializerSettings settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }

        public async Task<TranslateResponse> Translate(string text, CancellationToken cancellationToken = default)
        {
            var request = new TranslateRequest
            {
                Text = text
            };

            var content = new StringContent(JsonConvert.SerializeObject(request, _settings),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await _httpClient.PostAsync("/translate/pirate.json", content, cancellationToken);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonConvert.DeserializeObject<TranslateResponse>(result, _settings);
        }
    }
}