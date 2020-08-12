using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class MemberRemovedEvent : AuditableEntity
    {
        // auto-generated key
        [Key]
        public Guid Id { get; set; }
        // AAD user id
        public Guid UserId { get; set; }
        // from which team member was removed
        public Guid TeamId { get; set; }
    }
}