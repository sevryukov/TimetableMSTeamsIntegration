namespace TimetableMSTeamsIntegration.Common.Domain
{
    public interface IIdentifiable<TKey>
    {
        TKey Id { get; set; }
    }
}