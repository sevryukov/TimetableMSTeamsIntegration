using System;
using TimetableMSTeamsIntegration.Domain.Entities;

namespace TimetableMSTeamsIntegration.Application.Services
{
    public interface ITimetableRepository
    {
        // TODO: put behavior here 
        Team GetTeamFromTimetable(Guid teamTimetableId);
        Meeting GetMeetingFromTimetable(Guid meetingTimetableId);
        TeamMember GetTeamMemberFromTimetable(Guid memberTimetableId);
  
    }
}