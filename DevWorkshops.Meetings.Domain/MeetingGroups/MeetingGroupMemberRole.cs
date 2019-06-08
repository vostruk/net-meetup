
using Starfish.CRM.Organizations.Domain.Common;

namespace DevWorkshops.Meetings.Domain.MeetingGroups
{
    public class MeetingGroupMemberRole : ValueObject
    {
        public static MeetingGroupMemberRole Organizer()
        {
            return new MeetingGroupMemberRole("Organizer");
        }

        public static MeetingGroupMemberRole Coorganizer()
        {
            return new MeetingGroupMemberRole("Co-organizer");
        }

        public string Code { get; }

        public MeetingGroupMemberRole(string code)
        {
            this.Validate(code);
            this.Code = code;
        }

        private void Validate(string code)
        {

        }
    }
}
