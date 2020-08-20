namespace TimetableMSTeamsIntegration.Common.Infrastructure.Repository
{
    public class MSSQLRepositoryConfiguration : IMSSQLRepositoryConfiguration
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string ConnectionSettings { get; set; }
    }
}