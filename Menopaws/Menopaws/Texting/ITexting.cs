using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menopaws.Texting
{
	public interface ITexting
	{
		String SendText(String phoneNumber, String message);
	}
}
