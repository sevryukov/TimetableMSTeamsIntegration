using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class TeamClosedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Team>
    {
        public Guid Id { get; set; }
        // which team was closed
        public Guid TeamId { get; set; }
        public Team ApplyEvent(Team aggr)
        {
            if (aggr.GraphId != Id)
                throw new Exception($"Cannot apply {GetType().Name} with Id {Id} to aggregate with Id {aggr.GraphId}");

            aggr.ClosedAt = DateTime.UtcNow;

            return aggr;
        }
    }
}