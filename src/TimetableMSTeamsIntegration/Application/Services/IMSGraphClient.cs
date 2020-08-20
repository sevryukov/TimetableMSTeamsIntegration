using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IMSGraphClient
    {
        Task AddMemberAsync(Guid memberId, Guid teamId);
        Task RemoveMemberAsync(Guid memberId, Guid teamId);
        Task RemoveMembersAsync(IEnumerable<(Guid memberId, Guid teamId)> members);
        Task CreateMeetingAsync(string subject,DataTimeTimeZone start, DataTimeTimeZone end, List<Attendee> antendees);
        Task CancelMeetingAsync(Guid meetingId);
        Task InsertFinishMeetingEventAsync(Guid meetingId);
        Task ShiftMeetingAsync(Guid meetingId, DateTime newStartTime);
        Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null);
        Task CloseTeamAsync(Guid teamId);
    }
}