using System;
using TimetableMSTeamsIntegration.Domain.Abstract;
using TimetableMSTeamsIntegration.Common.Application;
using TimetableMSTeamsIntegration.Domain.Entities.Events;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface IEventRepository :
        IRepository<TeamCreatedEvent, Guid>,
        IRepository<TeamClosedEvent, Guid>,
        IRepository<MeetingCreatedEvent, Guid>,
        IRepository<MeetingShiftedEvent, Guid>,
        IRepository<MeetingCanceledEvent, Guid>,
        IRepository<MemberAddedEvent, Guid>,
        IRepository<MemberRemovedEvent, Guid>
    {
        // Task<IEnumerable<IAggregationEvent<Team>>> GetTeamEventsAsync(Guid teamId);
        // Task InsertCloseTeamEventAsync(Guid teamId);
        // Task InsertCancelMeetingEventAsync(Guid meetingId);
        // Task InsertFinishMeetingEventAsync(Guid meetingId);
        // Task InsertCreateMeetingEventAsync(string subject, DateTime start, DateTime end, List<TeamMember> аttendees);
        // //Task InsertCreateMeetingEventAsync(string subject, DateTime start, DateTime end, List<Guid> idAttendees);
        // Task InsertShiftMeetingEventAsync(Guid meetingId, DateTime newStartTime);
        // Task InsertAddMemberEventAsync(Guid memberId, Guid teamId);
        // Task InsertRangeAddMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        // Task InsertDeleteMemberEventAsync(Guid memberId, Guid teamId);
        // Task InsertRangeDeleteMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        // Task InsertCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester);
    }
}