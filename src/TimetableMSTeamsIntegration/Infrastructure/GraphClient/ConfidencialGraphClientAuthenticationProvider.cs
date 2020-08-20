using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace TimetableMSTeamsIntegration.Infrastructure.GraphClient
{
    public class ConfidentialGraphClientAuthenticationProvider : IAuthenticationProvider
    {
        private string _token = null;
        private readonly ConfidentialGraphClientAuthenticationProviderConfiguration _config;
        private readonly IConfidentialClientApplication _app;
        public ConfidentialGraphClientAuthenticationProvider(
            ConfidentialGraphClientAuthenticationProviderConfiguration config)
        {
            _config = config;

            _app = ConfidentialClientApplicationBuilder
                .Create(_config.ClientId)
                .WithTenantId(_config.TenantId)
                .WithClientSecret(_config.ClientSecret)
                .Build();
        }

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            request.Headers.Authorization =
                new AuthenticationHeaderValue("bearer", await GetAccessToken());
        }

        private async Task<string> GetAccessToken()
        {
            if (_token is null)
            {
                try
                {
                    var authResult = await _app
                        .AcquireTokenForClient(_config.Scopes)
                        .ExecuteAsync();

                    _token = authResult.AccessToken;

                    return _token;
                }
                catch (Exception)
                {
                    return null;
                    // ! actually we need to throw some kind of error here
                }
            }
            else return _token;
        }
    }
}