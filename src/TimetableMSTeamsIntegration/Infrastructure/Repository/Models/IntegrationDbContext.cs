using Microsoft.EntityFrameworkCore;

namespace TimetableMSTeamsIntegration.Infrastructure.Repository.Models
{
    public class IntegrationDbContext : DbContext
    {
        public DbSet<MeetingCanceledEvent> MeetingCanceledEvents { get; set; }
        public DbSet<MeetingCreatedEvent> MeetingCreatedEvents { get; set; }
        public DbSet<MeetingShiftedEvent> MeetingShiftedEvents { get; set; }
        public DbSet<MemberAddedEvent> MemberAddedEvents { get; set; }
        public DbSet<MemberRemovedEvent> MemberRemovedEvents { get; set; }
        public DbSet<TeamClosedEvent> TeamClosedEvents { get; set; }
        public DbSet<TeamCreatedEvent> TeamCreatedEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=localhost;database=MSTeamsIntegration;Trusted_Connection=True;");
        }
    }
}