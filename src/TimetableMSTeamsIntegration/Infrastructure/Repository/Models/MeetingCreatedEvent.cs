using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class MeetingCreatedEvent : AuditableEntity
    {
        // same as meeting ID in MS Teams/Calendar
        [Key]
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
    }
}