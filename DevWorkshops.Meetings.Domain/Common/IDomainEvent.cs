using System;

namespace DevWorkshops.Meetings.Domain.Common
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }
}