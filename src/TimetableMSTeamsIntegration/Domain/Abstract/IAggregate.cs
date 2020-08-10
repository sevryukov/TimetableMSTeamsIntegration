namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public interface IAggregate<T> where T : class, IAggregate<T>, new()
    {
        T Commit(T aggr);
    }
}