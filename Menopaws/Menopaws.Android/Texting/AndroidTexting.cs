using System;
using Xamarin.Forms;
using Menopaws.Texting;
using Menopaws.Droid.Texting;

[assembly: Dependency(typeof(AndroidTexting))]
namespace Menopaws.Droid.Texting
{
	class AndroidTexting : ITexting
	{
		public AndroidTexting() { }

		public String SendText(String phoneNumber, String message)
		{
			return "Success!";
		}
	}
}