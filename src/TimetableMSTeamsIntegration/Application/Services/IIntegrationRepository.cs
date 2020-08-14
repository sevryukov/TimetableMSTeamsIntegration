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

        void CloseTeam(TeamClosed teamClosedEvent);
        void CancelMeeting(MeetingCancelled meetingCancelledEvent);
        void FinishMeeting(MeetingFinished meetingFinishedEvent);
        Task<IEnumerable<IAggregate<Team>>> GetTeamEventsAsync(Guid teamId);
        void RemoveMember(MemberRemoved memberRemovedEvent);
        void CreateTeam(TeamCreated teamCreatedEvent);
        void CreateMeeting(MeetingCreated meetingCreatedEvent);
        void AddMember(MemberAdded memberAddedEvent);

        void ShiftMeeting(MeetingShifted meetingShiftedEvent);


        Task CreateAddMemberEventAsync(Guid memberId, Guid teamId);
        Task CreateRangeAddMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task CreateRemoveMemberEventAsync(Guid memberId, Guid teamId);
        Task CreateRangeRemoveMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task CreateCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester);
    }
}