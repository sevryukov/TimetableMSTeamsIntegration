using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates
{
    public class MemberAdded : IAggregate<Team>
    {
        public Guid GraphMemberId { get; private set; }

        public MemberAdded(Guid graphMemberId)
        {
            GraphMemberId = graphMemberId;
        }

        public Team Commit(Team next)
        {
            next.Members.Add(GraphMemberId);

            return next;
        }
    }
}