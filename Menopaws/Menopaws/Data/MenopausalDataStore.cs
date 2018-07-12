using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menopaws.Models;
using Menopaws.Data;

namespace Menopaws.Data
{
	public class MenopausalDataStore : IMenopausalDataStore
	{
		public String AddEvent(MenopausalEvent menopausalEvent)
		{
			return "Success!";
		}

		public List<MenopausalEvent> GetAllMenopausalEvents()
		{
			return new List<MenopausalEvent>();
		}
	}
}
