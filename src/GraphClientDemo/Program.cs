using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;

namespace GraphClientDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var clientId = "1adeb6e1-faad-4a5a-b1f7-2480fea94e70";
            var tenantID = "35420a39-fe6d-4eff-8ae7-f94291e1693d";
            var clientSecret = "yuq__1R4EZ0CnhYoKD1H2_D~-VG44G6X-v";
            var scopes = new string[]
            {
                // "Directory.ReadWrite.All",
                // "Group.Create",
                // "Group.ReadWrite.All",
                // "Team.Create",
                // "Team.ReadBasic.All",
                "https://graph.microsoft.com/.default"
            };

            var authProvider = new ConfidentialClientAuthenticationProvider(clientId, tenantID, clientSecret, scopes);

            var graphClient = new GraphServiceClient(authProvider);

            Console.WriteLine(graphClient.BaseUrl);

            // graphClient.BaseUrl = "https://graph.microsoft.com/beta";

            Console.WriteLine(graphClient.Directory.Request().RequestUrl);
            Console.WriteLine(graphClient.Teams.Request().RequestUrl);
            Console.WriteLine(graphClient.Users.Request().RequestUrl);
            Console.WriteLine(graphClient.Applications.Request().RequestUrl);

            await graphClient.Groups["cc37ee8c-34ce-4893-9c74-c108165dc2d5"]
                .Team
                .Request()
                .PutAsync(new Team
                {
                    MemberSettings = new TeamMemberSettings
                    {
                        AllowCreateUpdateChannels = true
                    },
                    MessagingSettings = new TeamMessagingSettings
                    {
                        AllowUserEditMessages = true,
                        AllowUserDeleteMessages = true
                    },
                    FunSettings = new TeamFunSettings
                    {
                        AllowGiphy = true,
                        GiphyContentRating = GiphyRatingType.Strict
                    }
                });

        }
    }

    class ConfidentialClientAuthenticationProvider : IAuthenticationProvider
    {
        private AuthenticationResult _authResult = null;
        private string[] _scopes;
        private IConfidentialClientApplication _app;
        public ConfidentialClientAuthenticationProvider(
            string clientId,
            string tenantID,
            string clientSecret,
            string[] scopes)
        {
            _scopes = scopes;

            _app = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithTenantId(tenantID)
                .WithClientSecret(clientSecret)
                .Build();
        }

        public async Task<string> GetAccessToken()
        {
            if (_authResult == null)
            {
                try
                {
                    _authResult = await _app.AcquireTokenForClient(_scopes)
                                     .ExecuteAsync();

                    Console.WriteLine(_authResult.AccessToken);

                    return _authResult.AccessToken;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error getting access token: {exception.Message}");
                    return null;
                }
            }
            else
            {
                _authResult = await _app
                    .AcquireTokenSilent(_scopes, _authResult.Account)
                    .ExecuteAsync();

                return _authResult.AccessToken;
            }
        }

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            request.Headers.Authorization =
                new AuthenticationHeaderValue("bearer", await GetAccessToken());
        }
    }
}
