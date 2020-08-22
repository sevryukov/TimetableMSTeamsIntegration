using System;

namespace TimetableMSTeamsIntegration.Domain.Entities
{
    public class Meeting
    {
        public Guid TimetableEventId { get; set; }
        public Guid GraphId { get; set; }
        public Guid TeamId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public bool Finished { get; set; }
        public bool Canceled { get; set; }
    }
}