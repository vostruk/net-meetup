
using DevWorkshops.Meetings.Domain.Common;
using System;

namespace DevWorkshops.Meetings.Domain.MeetingGroups
{
    public class MeetingGroupCreatedDomainEvent: DomainEvent
    {
        public MeetingGroupCreatedDomainEvent(Guid meetingGroupId)
        {
            MeetingGroupId = meetingGroupId;
        }
        public Guid MeetingGroupId { get; }
    }
}
