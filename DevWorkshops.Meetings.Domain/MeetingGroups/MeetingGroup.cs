using DevWorkshops.Meetings.Domain.Common;
using System;
using System.Collections.Generic;

namespace DevWorkshops.Meetings.Domain.MeetingGroups
{
    public class MeetingGroup : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }

        private string _description;

        private string _name;

        private string _city;

        private string _countryCode;

        private List<MeetingGroupMember> _members;

        public MeetingGroup(
            string name, 
            string description, 
            string city, 
            string countryCode, 
            Guid creatorId)
        {
            this.Id = Guid.NewGuid();
            _name = name;
            _description = description;
            _city = city;
            _countryCode = countryCode;

            this.AddDomainEvent(new MeetingGroupCreatedDomainEvent(this.Id));

            _members = new List<MeetingGroupMember>();

            _members.Add(new MeetingGroupMember(this.Id, creatorId, MeetingGroupMemberRole.Organizer()));
        }

        
    }
}
