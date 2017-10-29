using System;
using Xamarin.Forms;
using Menopaws.Texting;
using Menopaws.Droid.Texting;

[assembly: Dependency(typeof(IOSTexting))]
namespace Menopaws.Droid.Texting
{
    class IOSTexting : ITexting
    {
        public IOSTexting() { }

        public String SendText(String phoneNumber)
        {
            return "Success!";
        }
    }
}