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

        public Task InsertAddMemberEventAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertCancelMeetingEventAsync(Guid meetingId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertCloseTeamEventAsync(Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertCreateMeetingEventAsync(Guid meetingId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task<Guid> InsertCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertDeleteMemberEventAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertDeleteMembersEventAsync(IEnumerable<(Guid memberId, Guid teamId)> members)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertFinishMeetingEventAsync(Guid meetingId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task InsertShiftMeetingEventAsync(Guid meetingId, Guid teamId, DateTime newStartTime)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}