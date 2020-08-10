using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates
{
    public class MeetingFinished : IAggregate<Meeting>
    {
        public MeetingFinished(Guid meetingGraphId)
        {
            MeetingGraphId = meetingGraphId;
        }
        public Guid MeetingGraphId { get; private set; }
        public Meeting Commit(Meeting aggr)
        {
            if (aggr.GraphId != MeetingGraphId)
                throw new Exception(/*TODO: put exception message here*/);

            aggr.Finished = true;

            return aggr;
        }
    }
}