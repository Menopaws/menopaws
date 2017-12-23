namespace UnitTests
{
	public class SchedulePageViewModel
	{
		public SchedulePageViewModel(IMenopausalDataStore menopausalDataStore)
		{
			MenopausalDataStore = menopausalDataStore;
		}

		public IMenopausalDataStore MenopausalDataStore { get; }

		public void AddHotFlush(MenopausalEvent hotFlush)
		{
			MenopausalDataStore.AddEvent(hotFlush);
		}
	}
}
