using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IMSGraphClient
    {
        Task InsertAddMemberEventAsync(Guid memberId, Guid teamId);
        Task InsertDeleteMemberEventAsync(Guid memberId, Guid teamId);
        Task InsertDeleteMembersEventAsync(IEnumerable<(Guid memberId, Guid teamId)> members);
        Task InsertCreateMeetingEventAsync(Guid meetingId, Guid teamId);
        Task InsertCancelMeetingEventAsync(Guid meetingId, Guid teamId);
        Task InsertFinishMeetingEventAsync(Guid meetingId, Guid teamId);
        Task InsertShiftMeetingEventAsync(Guid meetingId, Guid teamId, DateTime newStartTime);
        Task<Guid> InsertCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null);
        Task InsertCloseTeamEventAsync(Guid teamId);
    }
}