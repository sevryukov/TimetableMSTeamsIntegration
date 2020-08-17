using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Graph;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Infrastructure.GraphClient
{
    public class MSGraphClient : IMSGraphClient
    {
        private readonly GraphServiceClient _graphClient;
        public MSGraphClient(GraphServiceClient graphClient)
            => _graphClient = graphClient;

        public Task AddMemberAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task CancelMeetingAsync(Guid meetingId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task CloseTeamAsync(Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task CreateMeetingAsync(Guid meetingId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task RemoveMemberAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task RemoveMembersAsync(IEnumerable<(Guid memberId, Guid teamId)> members)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertFinishMeetingEventAsync(Guid meetingId, Guid teamId)
        {
            // TODO: not implement
            throw new NotImplementedException();
        }

        public Task ShiftMeetingAsync(Guid meetingId, Guid teamId, DateTime newStartTime)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}