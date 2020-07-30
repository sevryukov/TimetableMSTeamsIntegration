﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Microsoft.Graph.Auth;
using Microsoft.Graph;
namespace MSTeamsSandbox.Application
{
    public class CreateTeamService
    {
        private string clientSecret = "5_P2z2ZtMG624F6iegoGpq1R-~-IHFJya9";
        private string clientId = "b80af835-246e-4e4b-973c-8711672e4399";

        private ClientCredentialProvider authProvider;

        public CreateTeamService()
        {
            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(clientId).WithClientSecret(clientSecret).Build();
            authProvider = new ClientCredentialProvider(confidentialClientApplication);
        }

        public async Task<Team> TryCreateTeam()
        {
            GraphServiceClient graphClient = new GraphServiceClient(authProvider);
            var team = new Team
            {
                Channels = (ITeamChannelsCollectionPage)new List<Channel>()
                {
                     new Channel
                     {
                         DisplayName = "Main channel",

                     }

                },
                MemberSettings = new TeamMemberSettings
                {
                    AllowCreateUpdateChannels = false,
                    AllowDeleteChannels = false,
                    AllowAddRemoveApps = false,
                    AllowCreateUpdateRemoveTabs = false,
                    AllowCreateUpdateRemoveConnectors = false
                },
                InstalledApps = (ITeamInstalledAppsCollectionPage)new List<TeamsAppInstallation>()
                 {
                     new TeamsAppInstallation
                     {
                         AdditionalData = new Dictionary<string, object>()
                         {
                             {"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"}
                         }
                     },
                     new TeamsAppInstallation
                     {
                         AdditionalData = new Dictionary<string, object>()
                         {
                             {"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"}
                         }
                     }

                 },
                AdditionalData = new Dictionary<string, object>()
                 {
                     {"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"},
                     {"group@odata.bind", "https://graph.microsoft.com/v1.0/groups('groupId')"}
                 }

            };

            var result = await graphClient.Teams
                  .Request()
                  .AddAsync(team);
            return result;



        }



    }
}
