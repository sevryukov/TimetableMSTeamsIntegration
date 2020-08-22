using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class MemberRemovedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Team>
    {
        // auto-generated key
        public Guid Id { get; set; }
        // AAD user id
        public Guid UserId { get; set; }
        // from which team member was removed
        public Guid TeamId { get; set; }

        public Team ApplyEvent(Team aggr)
        {
            if (aggr.GraphId != TeamId)
                throw new Exception($"Cannot apply {GetType().Name} with Team Id {TeamId} to aggregate with Id {aggr.GraphId}");

            aggr.Members.Remove(UserId);

            return aggr;
        }
    }
}