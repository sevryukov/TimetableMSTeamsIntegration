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
        Task<Team> GetTeamEvent(Guid teamGraphId);
        Task<Meeting> GetMeetingEvent(Guid meetingGraphId);
        Task<TeamMember> GetMemberEvent(Guid teamGraphId);
        Task<IEnumerable<IAggregate<Team>>> GetTeamEventsAsync(Guid teamId);

        Task InsertCloseTeamEventAsync(Guid teamId);
        Task InsertCancelMeetingEventAsync(Guid meetingId);
        Task InsertFinishMeetingEventAsync(Guid meetingId);
        
        Task InsertCreateMeetingEventAsync(string subject, DateTime start, DateTime end, List<Attendee> аttendees);
        

        Task InsertShiftMeetingEventAsync(Guid meetingId, DateTime newStartTime);


        Task InsertAddMemberEventAsync(Guid memberId, Guid teamId);
        Task InsertRangeAddMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task InsertDeleteMemberEventAsync(Guid memberId, Guid teamId);
        Task InsertRangeDeleteMemberEventAsync(IEnumerable<(Guid memberId, Guid teamId)> events);
        Task InsertCreateTeamEventAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester);
    }
}