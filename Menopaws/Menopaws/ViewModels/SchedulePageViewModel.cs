using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Menopaws.Data;
using Menopaws.Models;
using Xamarin.Forms;

namespace Menopaws
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
