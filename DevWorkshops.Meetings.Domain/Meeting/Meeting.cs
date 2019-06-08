using DevWorkshops.Meetings.Domain.Common;
using System;
using System.Collections.Generic;

namespace DevWorkshops.Meetings.Domain.Meeting
{
    public class Meeting : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }

        private Guid _meetingGroupId;

        private string _description;

        private float _eventFee;

        private int _attendeesLimit;

        private int _guestsLimit;

        private string _location;

        private DateTime _rsvpTerm;

        private DateTime _term;

        private string _title;

        List<MeetingAttendee> _attendees;


        public Meeting(
            Guid meetingGroupId, 
            Guid creatorId,
            int attendeesLimit, 
            string description, 
            float eventFee, 
            int guestsLimit, 
            string location, 
            DateTime rsvpTerm,
            DateTime term,
            string title)
        {
            Id = Guid.NewGuid();

            _meetingGroupId = meetingGroupId;
            _attendeesLimit = attendeesLimit;
            _guestsLimit = guestsLimit;
            _rsvpTerm = rsvpTerm;

            this.AddDomainEvent(new MeetinCreatedDomainEvent(this.Id));

            _attendees = new List<MeetingAttendee>();
            _attendees.Add(new MeetingAttendee(this.Id, creatorId, MeetingAttendeeRole.Host(), 0, rsvpTerm));
        }

        public void JoinAttendee(Guid attendeeId, MeetingAttendeeRole role, int guestsNumber)
        {
            if(_attendees.Count<_attendeesLimit)
            {
                _attendees.Add(new MeetingAttendee(this.Id, attendeeId, role, guestsNumber, this._rsvpTerm));
                this.AddDomainEvent(new MeetingAttendeeJoinedDomainEvent(this.Id, attendeeId, role, guestsNumber, this._rsvpTerm));
            }
        }
    }
}
