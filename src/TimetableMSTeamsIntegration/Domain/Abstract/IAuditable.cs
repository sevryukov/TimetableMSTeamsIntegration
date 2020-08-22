using System;

namespace TimetableMSTeamsIntegration.Domain.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
    }
}