using System;
using System.ComponentModel.DataAnnotations;
using TimetableMSTeamsIntegration.Infrastructure.Abstract;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class TeamCreatedEvent : AuditableEntity
    {
        // id of the team in MS Teams
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid Discipline { get; set; }
        public Guid Division { get; set; }
        public Guid ContingentUnit { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
    }
}