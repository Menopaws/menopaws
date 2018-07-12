using NUnit.Framework;
using System;
using Menopaws.Data;
using Menopaws.Models;
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
			Assert.AreEqual(menopausalEvent.Description, allEvents[1].Description);
		}
	}
}
