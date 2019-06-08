
using DevWorkshops.Meetings.Domain.Common;
using System;

namespace DevWorkshops.Meetings.Domain.Meeting
{
    public class MeetinCreatedDomainEvent : DomainEvent
    {
        public MeetinCreatedDomainEvent(Guid meetingId)
        {
            MeetingId = meetingId;
        }
        public Guid MeetingId { get; }
    }
}
