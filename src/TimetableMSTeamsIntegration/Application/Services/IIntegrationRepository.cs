using System;
using TimetableMSTeamsIntegration.Domain.Entities;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
using System.Threading.Tasks;
using System.Collections.Generic;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IIntegrationRepository
    {
        // TODO: put behavior
        // * for each basic event we put behavior on CRUD basis
        Team GetTeam(Guid teamGraphId);
        Meeting GetMeeting(Guid meetingGraphId);
        TeamMember GetMember(Guid teamGraphId);
        Task<IEnumerable<IAggregate<Team>>> GetTeamEventsAsync(Guid teamId);

        Task CloseTeamAsync(Guid teamId);
        Task CancelMeetingAsync(Guid meetingId, Guid teamId);
        Task FinishMeetingAsync(Guid meetingId, Guid teamId);
        //Task RemoveMemberAsync(Guid memberId, Guid teamId);
        //Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null);
        Task CreateMeetingAsync(Guid meetingId, Guid teamId);
        //Task AddMemberAsync(Guid memberId, Guid teamId);

        Task ShiftMeetingAsync(Guid meetingId, Guid teamId, DateTime newStartTime);


        Task CreateAddMemberEventAsync(Guid memberId, Guid teamId);
        Task CreateRangeAddMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task CreateRemoveMemberEventAsync(Guid memberId, Guid teamId);
        Task CreateRangeRemoveMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task CreateCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester);
    }
}