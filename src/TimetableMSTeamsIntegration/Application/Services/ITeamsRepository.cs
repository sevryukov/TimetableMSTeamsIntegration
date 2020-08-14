using System;
using TimetableMSTeamsIntegration.Domain.Entities;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
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
        void RemoveMember(MemberRemoved memberRemovedEvent);

        void CreateTeam(TeamCreated teamCreatedEvent);
        void CreateMeeting(MeetingCreated meetingCreatedEvent);
        void AddMember(MemberAdded memberAddedEvent);

        void ShiftMeeting(MeetingShifted meetingShiftedEvent);




    }
}