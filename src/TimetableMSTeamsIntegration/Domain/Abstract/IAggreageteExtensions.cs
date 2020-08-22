using System.Collections.Generic;
using System.Linq;

namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public static class IAggregateExtensions
    {
        public static T Aggregate<T>(this ICollection<IAggregationEvent<T>> aggregates) where T : class, new()
            => aggregates
                .OrderBy(x => x.CreatedAt)
                .Aggregate(new T(), (result, @event) => @event.ApplyEvent(result));

        public static T Aggregate<T>(this ICollection<IAggregationEvent<T>> aggregates, T aggregate) where T : class, new()
            => aggregates
                .OrderBy(x => x.CreatedAt)
                .Aggregate(aggregate, (result, @event) => @event.ApplyEvent(result));

        public static T Build<T>(this T aggr, ICollection<IAggregationEvent<T>> aggregates) where T : class, new()
            => aggregates.Aggregate(aggr);
    }
}