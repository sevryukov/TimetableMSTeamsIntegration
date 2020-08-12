using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class TeamClosedEvent : AuditableEntity
    {
        // auto-generated id of data entry
        [Key]
        public Guid Id { get; set; }
        // which team was closed
        public Guid TeamId { get; set; }
    }
}