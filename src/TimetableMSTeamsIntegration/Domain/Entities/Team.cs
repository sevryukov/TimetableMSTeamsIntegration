using System;
using System.Collections.Generic;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities
{
    // this entity is made for aggregating information in system and future analysis
    public class Team
    {
        // unique identifier give to team by MS Teams app
        public Guid GraphId { get; set; }
        // title of the team to be displayed
        public string Title { get; set; }
        // when team was created
        public DateTime CreatedAt { get; set; }
        // when team was closed
        public DateTime? ClosedAt { get; set; }
        public Guid Discipline { get; set; }
        public Guid Division { get; set; }
        public Guid ContingentUnit { get; set; }
        // for 2019-2020 year of education we pick 2019
        public int Year { get; set; }
        // 1-8 semester of education
        public int Semester { get; set; }
        // collection of guids for each member of the team (guids from graph)
        public ICollection<Guid> Members { get; set; }
    }
}