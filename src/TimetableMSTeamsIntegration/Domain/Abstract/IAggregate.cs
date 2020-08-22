using System;

namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public interface IAggregationEvent<T> where T : class, new()
    {
        DateTime CreatedAt { get; set; }
        T ApplyEvent(T aggr);
    }
}