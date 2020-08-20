using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class MemberAddedEvent : AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }
        // id of the user in AAD
        public Guid UserId { get; set; }
        // team where member was added
        public Guid TeamId { get; set; }
        
        // ? should we put here info about user role?
    }
}