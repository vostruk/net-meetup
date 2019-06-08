
using Starfish.CRM.Organizations.Domain.Common;

namespace DevWorkshops.Meetings.Domain.Meeting
{
    public class MeetingAttendeeRole : ValueObject
    {
        public static MeetingAttendeeRole Host()
        {
            return new MeetingAttendeeRole("Host");
        }

        public static MeetingAttendeeRole Atendee()
        {
            return new MeetingAttendeeRole("Atendee");
        }

        public static MeetingAttendeeRole Pending()
        {
            return new MeetingAttendeeRole("Pending");
        }

        public string Code { get; }

        public MeetingAttendeeRole(string code)
        {
            this.Validate(code);
            this.Code = code;
        }

        private void Validate(string code)
        {

        }
    }
}
