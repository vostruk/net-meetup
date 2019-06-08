using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevWorkshops.Meetings.Domain.Common;

namespace DevWorkshop.Meetings.Domain.Tests.Common
{
    public class DomainEventsTestHelper
    {
        public static List<IDomainEvent> GetAllDomainEvents(Entity aggregate)
        {
            List<IDomainEvent> domainEvents = new List<IDomainEvent>();
            domainEvents.AddRange(aggregate.DomainEvents);
            var fields = aggregate.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).Concat(aggregate.GetType().BaseType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Public)).ToArray();

            foreach (var field in fields)
            {
                var isEntity = field.FieldType.IsAssignableFrom(typeof(Entity));

                if (isEntity)
                {
                    var entity = field.GetValue(aggregate) as Entity;
                    domainEvents.AddRange(GetAllDomainEvents(entity).ToList());
                }

                if (field.FieldType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(field.FieldType))
                {
                    IEnumerable enumerable = field.GetValue(aggregate) as IEnumerable;
                    if (enumerable != null)
                    {
                        foreach (var en in enumerable)
                        {
                            if (en is Entity entityItem)
                            {
                                domainEvents.AddRange(GetAllDomainEvents(entityItem));
                            }
                        }
                    }
                }
            }

            return domainEvents;
        }
    }
}