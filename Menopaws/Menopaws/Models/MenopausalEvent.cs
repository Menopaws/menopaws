using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menopaws.Models
{
	public class MenopausalEvent
	{
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public String Description { get; set; }
	}
}
