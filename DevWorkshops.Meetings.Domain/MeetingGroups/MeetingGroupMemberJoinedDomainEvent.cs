
using DevWorkshops.Meetings.Domain.Common;
using System;

namespace DevWorkshops.Meetings.Domain.MeetingGroups
{
    public class MeetingGroupMemberJoinedDomainEvent : DomainEvent
    {
        public MeetingGroupMemberJoinedDomainEvent(
            Guid meetingGroupId, 
            Guid memberId,
            MeetingGroupMemberRole role)
        {
            MeetingGroupId = meetingGroupId;
            MemberId = memberId;
            Role = role;
        }
        public Guid MeetingGroupId { get; }
        public Guid MemberId { get; }
        public MeetingGroupMemberRole Role { get; }
    }
}
