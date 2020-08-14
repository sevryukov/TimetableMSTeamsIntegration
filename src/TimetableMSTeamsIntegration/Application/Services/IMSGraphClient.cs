using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IMSGraphClient
    {
        void CreateTeam(TeamCreated teamCreatedEvent);
        void AddMember(MemberAdded memberAddedEvent);
        Task AddMemberAsync(Guid memberId, Guid teamId);
        void RemoveMember(MemberRemoved memberRemovedEvent);
        void CreateMeeting(MeetingCreated meetingCreatedEvent);
        void CancelMeeting(MeetingCancelled meetingCancelledEvent);
        void FinishMeeting(MeetingFinished meetingFinishedEvent);
        void ShiftMeeting(MeetingShifted meetingShiftedEvent);
        Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null);
    }
}