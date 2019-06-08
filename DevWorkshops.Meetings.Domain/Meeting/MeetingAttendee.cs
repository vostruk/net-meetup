using DevWorkshops.Meetings.Domain.Common;
using System;

namespace DevWorkshops.Meetings.Domain.Meeting
{
    public class MeetingAttendee : Entity
    {
        public Guid AttendeeId { get; private set; }

        public Guid _attendeeMeetingId;

        private MeetingAttendeeRole _role;

        private int _guestsNumber;

        private DateTime _rsvp;

        internal MeetingAttendee(
            Guid attendeeMeetingId, 
            Guid attendeeId, 
            MeetingAttendeeRole role, 
            int guestsNumber,
            DateTime rsvp)
        {
            this.AttendeeId = attendeeId;
            _attendeeMeetingId = attendeeMeetingId;
            _role = role;
            _guestsNumber = guestsNumber;
            _rsvp = rsvp;

            this.AddDomainEvent(new MeetingAttendeeJoinedDomainEvent(
                _attendeeMeetingId,
                this.AttendeeId,
                _role,
                _guestsNumber,
                _rsvp));
        }
    }
}
