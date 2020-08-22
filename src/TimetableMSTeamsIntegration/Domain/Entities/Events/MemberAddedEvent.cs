using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class MemberAddedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Team>
    {
        public Guid Id { get; set; }
        // id of the user in AAD
        public Guid UserId { get; set; }
        // team where member was added
        public Guid TeamId { get; set; }
        public MemberRole UserRole { get; set; }

        public Team ApplyEvent(Team aggr)
        {
            if (aggr.GraphId != TeamId)
                throw new Exception($"Cannot apply {GetType().Name} with Team Id {TeamId} to aggregate with Id {aggr.GraphId}");

            aggr.Members.Add(UserId);

            return aggr;
        }
    }
}