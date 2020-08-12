using System;
using System.ComponentModel.DataAnnotations;

namespace TimetableMSTeamsIntegration.Infrastructure.Abstract
{
    public class AuditableEntity : IAuditable
    {
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}