using NUnit.Framework;
using System;
using Menopaws.Models;
using Syncfusion.SfSchedule.XForms;
namespace Menopaws.UnitTests
{
    [TestFixture()]
    public class MenopawsEventsTests
    {
        [Test()]
        public void TestCase()
        {
            // Arrange
            var events = new MenopawsEvents();
            MenopausalEvent myEvent = new MenopausalEvent
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                Description = "Hot flush"
            };
            events.AddEvent(myEvent);

            // Act
            ScheduleAppointmentCollection newCollection = events.CreateAppointmentCollection();

            // Assert
            Assert.AreEqual(newCollection.Count, 1);
            Assert.AreEqual(newCollection[0].StartTime, myEvent.StartTime);
        }
    }
}
