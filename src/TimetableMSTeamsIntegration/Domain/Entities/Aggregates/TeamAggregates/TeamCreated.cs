using System;
using System.Collections.Generic;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates
{
    public class TeamCreated : IAggregate<Team>
    {
        public TeamCreated(
            Guid graphId,
            string title,
            DateTime? createdAt = null,
            ICollection<Guid> members = null)
        {
            GraphId = graphId;
            Title = title;
            CreatedAt = createdAt;
            Members = members;
        }
        public Guid GraphId { get; private set; }
        public string Title { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public ICollection<Guid> Members { get; private set; }

        public Team Commit(Team aggr) => new Team()
        {
            GraphId = GraphId,
            Title = Title,
            CreatedAt = CreatedAt ?? DateTime.UtcNow,
            ClosedAt = null,
            Members = Members ?? new List<Guid>(),
        };
    }
}