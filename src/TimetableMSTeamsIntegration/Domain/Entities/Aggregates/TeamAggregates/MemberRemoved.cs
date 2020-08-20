using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates
{
    public class MemberRemoved : IAggregate<Team>
    {
        public Guid GraphMemberId { get; private set; }

        public MemberRemoved(Guid graphMemberId)
        {
            GraphMemberId = graphMemberId;
        }

        public Team Commit(Team aggr)
        {
            // ? should we check if member is in team
            aggr.Members.Remove(GraphMemberId);

            return aggr;
        }
    }
}