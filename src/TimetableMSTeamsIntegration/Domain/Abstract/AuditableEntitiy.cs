using System;
using System.ComponentModel.DataAnnotations;

namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public abstract class AuditableEntity : IAuditable
    {
        [DataType(DataType.Date)]
        public virtual DateTime CreatedAt { get; set; }
    }
}