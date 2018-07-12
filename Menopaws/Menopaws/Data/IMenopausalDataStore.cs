using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menopaws.Models;
using Syncfusion.SfSchedule.XForms;

namespace Menopaws.Data
{
	public interface IMenopausalDataStore
	{
		void AddEvent(MenopausalEvent menopausalEvent);

		List<MenopausalEvent> GetAllMenopausalEvents();

		ScheduleAppointmentCollection CreateAppointmentCollection();
	}
}
