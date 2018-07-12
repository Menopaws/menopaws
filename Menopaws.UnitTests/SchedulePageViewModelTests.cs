using NUnit.Framework;
using System;
using Menopaws.Data;
using Menopaws.Models;
namespace Menopaws.UnitTests
{
	[TestFixture()]
	public class SchedulePageViewModelTests
	{
		[Test()]
		public void ViewModelAddsEventToDataStore()
		{
			// Arrange
			IMenopausalDataStore menopausalDataStore = new MenopausalDataStore();
			var scheduleVM = new SchedulePageViewModel(menopausalDataStore);
			var menopausalEvent = new MenopausalEvent
			{
				StartTime = DateTime.Now,
				EndTime = DateTime.Now.AddHours(1),
				Description = "Something happened"
			};

			// Act
			scheduleVM.AddEvent(menopausalEvent);
			var allEvents = menopausalDataStore.GetAllMenopausalEvents();

			// Assert
			Assert.AreEqual(1, allEvents.Count);
			Assert.AreEqual(menopausalEvent.Description, allEvents[0].Description);
		}
	}
}
