using NUnit.Framework;
using System;
using Menopaws.Data;
using Menopaws.Models;
using Syncfusion.SfSchedule.XForms;

namespace Menopaws.UnitTests
{
	[TestFixture()]
	public class MenopausalDataStoreTests
	{
		[Test()]
		public void ModelAddsEventToDataStore()
		{
			// Arrange
			IMenopausalDataStore menopausalDataStore = new MenopausalDataStore();
			var menopausalEvent = new MenopausalEvent
			{
				StartTime = DateTime.Now,
				EndTime = DateTime.Now.AddHours(1),
				Description = "Something new happened!"
			};

			// Act
			menopausalDataStore.AddEvent(menopausalEvent);
			var allEvents = menopausalDataStore.GetAllMenopausalEvents();

			// Assert
			Assert.AreEqual(1, allEvents.Count);
			Assert.AreEqual(menopausalEvent.Description, allEvents[0].Description);
		}

		[Test()]
		public void DataStoreShouldCreateAppointmentCollectionBasedOnEvents()
		{
			// Arrange
			var events = new MenopausalDataStore();
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
			Assert.AreEqual(1, newCollection.Count);
			Assert.AreEqual(myEvent.StartTime, newCollection[0].StartTime);
		}
	}
}
