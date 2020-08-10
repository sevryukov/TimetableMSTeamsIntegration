using System;

namespace TimetableMSTeamsIntegration.Domain.Entities
{
    public class TeamMember
    {
        // unique identifier of user in MS Teams
        public Guid GraphId { get; set; }
        // unique identifier of team member in Timetables API
        public Guid TimetableId { get; set; }
        public string FullName { get; set; }
        // SPBU email
        public string Email { get; set; }
        // ? dow we need this field, or we don't bother
        public MemberRole Role { get; set; }
    }
}