using System.Collections.Generic;

namespace DevWorkshops.Meetings.Domain.Common
{
    public abstract class Entity
    {
        private List<IDomainEvent> _domainEvents;

        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            if (_domainEvents == null)
            {
                _domainEvents = new List<IDomainEvent>();
            }
            _domainEvents.Add(domainEvent);
        }
    }
}
