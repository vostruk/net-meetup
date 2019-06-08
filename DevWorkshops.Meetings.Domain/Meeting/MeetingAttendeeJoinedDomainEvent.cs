
using DevWorkshops.Meetings.Domain.Common;
using System;

namespace DevWorkshops.Meetings.Domain.Meeting
{
    public class MeetingAttendeeJoinedDomainEvent : DomainEvent
    {
        public MeetingAttendeeJoinedDomainEvent(
            Guid meetingGroupId,
            Guid memberId,
            MeetingAttendeeRole role,
            int guestsNumber,
            DateTime rsvp)
        {
            MeetingGroupId = meetingGroupId;
            MemberId = memberId;
            Role = role;
            GuestsNumber = guestsNumber;
            Rsvp = rsvp;

        }
        public Guid MeetingGroupId { get; }
        public Guid MemberId { get; }
        public MeetingAttendeeRole Role { get; }
        public int GuestsNumber { get; }
        public DateTime Rsvp { get; }
    }
}
