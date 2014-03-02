using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cheesebaron.MvxPlugins.ModernHttpClient;
using LoLRank.Core.Constants;
using Newtonsoft.Json.Linq;

namespace LoLRank.Core.Services
{
    public class LeagueOfLegendsApiService : ILeagueOfLegendsApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private CancellationTokenSource _currentToken;

        public LeagueOfLegendsApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Request(string url, CancellationTokenSource token = null)
        {
            _currentToken = token ?? new CancellationTokenSource();

            var httpClient = _httpClientFactory.Get();
            var msg = await httpClient.GetAsync(url, _currentToken.Token);

            if (!msg.IsSuccessStatusCode) return "Something derped";

            var result = await msg.Content.ReadAsStringAsync();
            return result;
        }

        public void CancelCurrent()
        {
            if (_currentToken != null)
                _currentToken.Cancel();
        }

        public void Cancel(CancellationTokenSource token)
        {
            if (token == null)
                CancelCurrent();
            else
                token.Cancel();
        }
    }
}
