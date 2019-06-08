using System;

namespace DevWorkshops.Meetings.Domain.Common
{
    public abstract class DomainEvent : IDomainEvent
    {
        public DateTime OccurredOn { get;  }
        protected DomainEvent()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}