using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class MeetingCreatedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Meeting>
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public Guid TimetableEventId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Meeting ApplyEvent(Meeting aggr)
        {
            aggr.Canceled = false;
            aggr.StartsAt = StartsAt;
            aggr.EndsAt = EndsAt;
            aggr.TeamId = TeamId;
            aggr.GraphId = Id;
            aggr.Finished = false;
            aggr.TimetableEventId = TimetableEventId;

            return aggr;
        }
    }
}