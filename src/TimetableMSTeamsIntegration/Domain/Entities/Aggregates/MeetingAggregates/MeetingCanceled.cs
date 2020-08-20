using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates
{
    public class MeetingCancelled : IAggregate<Meeting>
    {
        public MeetingCancelled(Guid meetingGraphId)
        {
            MeetingGraphId = meetingGraphId;
        }
        public Guid MeetingGraphId { get; private set; }
        public Meeting Commit(Meeting aggr)
        {
            if (aggr.GraphId != MeetingGraphId)
                throw new Exception(/*TODO: put exception message here*/);

            aggr.Canceled = true;

            return aggr;
        }
    }
}