using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates
{
    public class MeetingShifted : IAggregate<Meeting>
    {
        public MeetingShifted(Guid meetingGraphId, DateTime shiftedTo)
        {
            MeetingGraphId = meetingGraphId;
            ShiftedTo = shiftedTo;
        }
        public Guid MeetingGraphId { get; set; }
        public DateTime ShiftedTo { get; private set; }
        public Meeting Commit(Meeting aggr)
        {
            if (aggr.GraphId != MeetingGraphId)
                throw new Exception(/* TODO: put message here*/);

            aggr.StartsAt = ShiftedTo;

            return aggr;
        }
    }
}