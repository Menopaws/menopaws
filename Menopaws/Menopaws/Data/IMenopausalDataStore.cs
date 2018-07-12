using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menopaws.Models;

namespace Menopaws.Data
{
	public interface IMenopausalDataStore
	{
		void AddEvent(MenopausalEvent menopausalEvent);

		List<MenopausalEvent> GetAllMenopausalEvents();
	}
}
