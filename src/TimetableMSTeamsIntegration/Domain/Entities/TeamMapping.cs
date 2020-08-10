using System;

namespace TimetableMSTeamsIntegration.Domain.Entities
{
    // this class represents how we map information from Timetables to MS Teams via storing both keys
    public class TeamMapping
    {
        public Guid Discipline { get; set; }
        public Guid Division { get; set; }
        public Guid ContingentUnit { get; set; }
        // for 2019-2020 year of education we pick 2019
        public int Year { get; set; }
        // 1-8 semester of education
        public int Semester { get; set; }
        // id of the team in MS Teams
        public Guid GraphId { get; set; }
    }
}