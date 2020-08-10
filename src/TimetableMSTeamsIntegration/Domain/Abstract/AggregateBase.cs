namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public abstract class AggregateBase<T> : IAggregate<T> where T : class, IAggregate<T>, new()
    {
        public virtual T Commit(T aggr) => this as T;
    }
}