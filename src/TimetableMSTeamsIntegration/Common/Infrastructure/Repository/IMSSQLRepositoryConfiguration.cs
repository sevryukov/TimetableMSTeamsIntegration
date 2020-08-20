namespace TimetableMSTeamsIntegration.Common.Infrastructure.Repository
{
    public interface IMSSQLRepositoryConfiguration
    {
        string Server { get; set; }
        string Database { get; set; }
        string ConnectionSettings { get; set; }
        string ConnectionString => $@"Server={Server};Database={Database};{ConnectionSettings}";
    }
}