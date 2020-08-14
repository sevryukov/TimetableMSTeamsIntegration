using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;
namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IMSGraphClient
    {
        void CreateTeam(TeamCreated teamCreatedEvent);
        void AddMember(MemberAdded memberAddedEvent);
        void RemoveMember(MemberRemoved memberRemovedEvent);
        void CreateMeeting(MeetingCreated meetingCreatedEvent);
        void CancelMeeting(MeetingCancelled meetingCancelledEvent);
        void FinishMeeting(MeetingFinished meetingFinishedEvent);
        void ShiftMeeting(MeetingShifted meetingShiftedEvent);
        
        
    }
}