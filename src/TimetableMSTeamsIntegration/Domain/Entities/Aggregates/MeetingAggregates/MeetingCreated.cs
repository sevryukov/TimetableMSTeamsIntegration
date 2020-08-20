using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates
{
    public class MeetingCreated : IAggregate<Meeting>
    {
        public MeetingCreated(
            Guid timetableEventId,
            Guid graphId,
            Guid teamId,
            DateTime startsAt,
            TimeSpan? duration = null)
        {
            TimetableEventId = timetableEventId;
            GraphId = graphId;
            TeamId = teamId;
            StartsAt = startsAt;
            Duration = duration;

        }
        public Guid TimetableEventId { get; private set; }
        public Guid GraphId { get; private set; }
        public Guid TeamId { get; private set; }
        public DateTime StartsAt { get; private set; }
        public TimeSpan? Duration { get; private set; }

        public Meeting Commit(Meeting aggr)
        {
            return new Meeting
            {
                TimetableEventId = TimetableEventId,
                GraphId = GraphId,
                TeamId = TeamId,
                StartsAt = StartsAt,
                Duration = Duration ?? new TimeSpan(1, 30, 0),
                Finished = false,
                Canceled = false,
            };
        }
    }
}