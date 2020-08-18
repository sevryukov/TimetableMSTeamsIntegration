using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
using System;
using TimetableMSTeamsIntegration.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IMSGraphClient
    {
        Task AddMemberAsync(Guid memberId, Guid teamId);
        Task RemoveMemberAsync(Guid memberId, Guid teamId);
        Task RemoveMembersAsync(IEnumerable<(Guid memberId, Guid teamId)> members);
        Task CreateMeetingAsync(string subject, DateTime start, DateTime end,  List<TeamMember> аttendees);
        //Task CreateMeetingAsync(string subject, DateTime start, DateTime end,  List<Guid> idAttendees);
        Task CancelMeetingAsync(Guid meetingId);
        Task FinishMeetingAsync(Guid meetingId);
        Task ShiftMeetingAsync(Guid meetingId, DateTime newStartTime);
        Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null);
        Task CloseTeamAsync(Guid teamId);
    }
}