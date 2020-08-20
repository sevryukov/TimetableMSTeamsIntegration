using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class MeetingShiftedEvent : AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid MeetingId { get; set; }
    }
}