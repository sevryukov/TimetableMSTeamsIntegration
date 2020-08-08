using System;

namespace TimetableQueringSandbox.Entities
{
    /// <summary>
    /// Describes mapping between data from Timetable app to ids of MS Teams created Teams
    /// </summary>
    public class TeamMapping
    {
        public Guid Division { get; set; }
        public Guid Subject { get; set; }
        // public 
    }
}