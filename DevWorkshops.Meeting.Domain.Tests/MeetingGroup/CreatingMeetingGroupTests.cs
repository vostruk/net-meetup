using DevWorkshop.Meetings.Domain.Tests.Common;
using DevWorkshops.Meetings.Domain.MeetingGroups;
using NUnit.Framework;
using System;

namespace DevWorkshops.Meeting.Domain.Tests.MeetingGroup
{
    [TestFixture]
    class CreatingMeetingGroupTests
    {
        [Test]
        public void CreateMeetingGroupTest()
        {
            // Arrange

            Guid creatorId = Guid.NewGuid();


            Meetings.Domain.MeetingGroups.MeetingGroup meetingGroup =  new Meetings.Domain.MeetingGroups.MeetingGroup("testName", 
                "description", "Warsaw", "PL", creatorId);

            var allDomainEvents = DomainEventsTestHelper.GetAllDomainEvents(meetingGroup);

            //Assert

            Assert.That(allDomainEvents, Is.Not.Null);
            Assert.That(allDomainEvents[0], Is.TypeOf<MeetingGroupCreatedDomainEvent>());

            var meetingGroupCreated = allDomainEvents[0] as MeetingGroupCreatedDomainEvent;

            Assert.That(meetingGroupCreated.MeetingGroupId, Is.EqualTo(meetingGroup.Id));

            Assert.That(allDomainEvents[1], Is.TypeOf<MeetingGroupMemberJoinedDomainEvent>());
        }
    }
}
