namespace UnitTests
{
	public class ScheduleViewModel
	{
		public ScheduleViewModel(IMenopausalDataStore menopausalDataStore)
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
