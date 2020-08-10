namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public interface IAggregate<T> where T : IAggregate<T>
    {
        T Commit(T aggr);
    }
}