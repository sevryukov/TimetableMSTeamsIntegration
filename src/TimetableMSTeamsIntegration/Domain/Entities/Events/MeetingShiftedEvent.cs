using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class MeetingShiftedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Meeting>
    {
        public Guid Id { get; set; }
        public Guid MeetingId { get; set; }
        public DateTime NewStartTime { get; set; }
        public DateTime NewEndTime { get; set; }

        public Meeting ApplyEvent(Meeting aggr)
        {
            if (aggr.GraphId != MeetingId)
                throw new Exception($"Cannot apply {GetType().Name} with Meeting Id {MeetingId} to aggregate with Id {aggr.GraphId}");

            (aggr.StartsAt, aggr.EndsAt) = (NewStartTime, NewEndTime);

            return aggr;
        }
    }
}