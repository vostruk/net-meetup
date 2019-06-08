using DevWorkshops.Meetings.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevWorkshops.Meetings.Domain.MeetingGroups
{
    public class MeetingGroupMember : Entity
    {
        public Guid MemberId { get; private set; }

        public Guid _memberGroupId;

        private MeetingGroupMemberRole _role;

        internal MeetingGroupMember(Guid memberGroupId, Guid memberId, MeetingGroupMemberRole role)
        {
            this.MemberId = memberId;
            _memberGroupId = memberGroupId;
            _role = role;

            this.AddDomainEvent(new MeetingGroupMemberJoinedDomainEvent(_memberGroupId, 
                this.MemberId, 
                _role));
        }
    }
}
