namespace TimetableMSTeamsIntegration.Infrastructure.GraphClient
{
    public class ConfidentialGraphClientAuthenticationProviderConfiguration
    {
        public string[] Scopes { get; set; }
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }

    }
}