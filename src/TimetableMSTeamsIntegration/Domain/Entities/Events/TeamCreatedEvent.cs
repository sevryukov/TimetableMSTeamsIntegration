using System;
using TimetableMSTeamsIntegration.Common.Domain;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities.Events
{
    public class TeamCreatedEvent : 
        AuditableEntity, 
        IIdentifiable<Guid>, 
        IAggregationEvent<Team>
    {
        // id of the team in MS Teams
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid Discipline { get; set; }
        public Guid Division { get; set; }
        public Guid ContingentUnit { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public Team ApplyEvent(Team aggr)
        {
            aggr.GraphId = Id;
            aggr.CreatedAt = DateTime.UtcNow;
            aggr.Discipline = Discipline;
            aggr.Division = Division;
            aggr.ContingentUnit = ContingentUnit;
            aggr.Year = Year;
            aggr.Semester = Semester;
            aggr.Title = Title;

            return aggr;
        }
    }
}