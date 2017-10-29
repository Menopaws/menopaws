using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clockwork;

namespace Menopaws.Texting
{
    public class ClockworkTexting : ITexting
    {
        public String SendText(String phoneNumber)
        {
            return "Success!";
        }
    }
}
