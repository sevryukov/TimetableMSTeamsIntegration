using System;

namespace TimetableMSTeamsIntegration.Infrastructure.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
    }
}