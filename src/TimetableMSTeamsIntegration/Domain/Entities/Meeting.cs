using System;
using TimetableMSTeamsIntegration.Domain.Abstract;

namespace TimetableMSTeamsIntegration.Domain.Entities
{
    public class Meeting : AggregateBase<Meeting>
    {
        public Guid TimetableEventId { get; set; }
        public Guid GraphId { get; set; }
        public Guid TeamId { get; set; }
        public DateTime StartsAt { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Finished { get; set; }
        public bool Canceled { get; set; }
    }
}