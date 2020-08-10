using System.Collections.Generic;
using System.Linq;

namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public static class IAggregateExtensions
    {
        public static T Aggregate<T>(this ICollection<IAggregate<T>> aggregates) where T : class, IAggregate<T>, new()
        {
            var aggr = new T();

            return aggregates
                .Aggregate(aggr, (now, next) => next.Commit(now));
        }
    }
}