using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates
{
    public class TeamClosed : IAggregate<Team>
    {
        public Guid GraphId { get; private set; }
        public DateTime? ClosedAt { get; private set; }
        public TeamClosed(Guid graphId, DateTime? closedAt = null)
        {
            GraphId = graphId;
            ClosedAt = closedAt ?? DateTime.UtcNow;
        }

        public Team Commit(Team aggr)
        {
            if (aggr.GraphId != GraphId)
                throw new Exception($"Team Graph Id mismatch at closing\nTeam Id : {aggr.GraphId}\nPassed Id: {GraphId}");

            aggr.ClosedAt = ClosedAt;

            return aggr;
        }
    }
}