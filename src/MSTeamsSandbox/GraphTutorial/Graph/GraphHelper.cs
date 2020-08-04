using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphTutorial
{
    public class GraphHelper
    {
        private static GraphServiceClient graphClient;
        public static void Initialize(IAuthenticationProvider authProvider)
        {
            graphClient = new GraphServiceClient(authProvider);
        }

        public static async Task<User> GetMeAsync()
        {
            try
            {
                // GET /me
                return await graphClient.Me.Request().GetAsync();
            }
            catch (ServiceException ex)
            {
                Console.WriteLine($"Error getting signed-in user: {ex.Message}");
                return null;
            }
        }

        // <GetEventsSnippet>
        public static async Task<IEnumerable<Event>> GetEventsAsync()
        {
            try
            {
                // GET /me/events
                var resultPage = await graphClient.Me.Events.Request()
                    // Only return the fields used by the application
                    .Select(e => new {
                      e.Subject,
                      e.Organizer,
                      e.Start,
                      e.End
                    })
                    // Sort results by when they were created, newest first
                    .OrderBy("createdDateTime DESC")
                    .GetAsync();

                return resultPage.CurrentPage;
            }
            catch (ServiceException ex)
            {
                Console.WriteLine($"Error getting events: {ex.Message}");
                return null;
            }
        }
        // </GetEventsSnippet>

        public static async Task<Team> CreateTeam()
        {
            var _team = new Team
            {
               DisplayName = "First team",
               Description = "First team created to try Graph",
               MemberSettings = new TeamMemberSettings
               {
                   AllowCreateUpdateChannels = false,
                   AllowAddRemoveApps = false,
                   AllowDeleteChannels = false,
                   AllowCreateUpdateRemoveTabs = false,
                   AllowCreateUpdateRemoveConnectors = false
               }
               /*AdditionalData = new Dictionary<string,object>()
               {
                   {"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"},
                   {"group@odata.bind", "https://graph.microsoft.com/v1.0/groups('groupId')"}
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
               }*/
            };
            
            var result = await graphClient.Teams
                   .Request()
                   .AddAsync(_team);
            return result;
        }
    }
}